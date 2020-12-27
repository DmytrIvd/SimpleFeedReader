using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RSSientReader
{
    public partial class FeedReader : Form
    {
        private List<AddressFeed> Adreses = new List<AddressFeed>()
        {
          new AddressFeed("http://joeroganexp.joerogan.libsynpro.com/rss",true),
          new AddressFeed("http://k.img.com.ua/rss/ru/motors.xml",true),
          new AddressFeed("http://www.rbc.ua/static/rss/newsline.img.rus.rss.xml",true),
          new AddressFeed("http://www.rbc.ua/static/rss/ukrnet.accidents.rus.rss.xml",true),
          new AddressFeed("http://k.img.com.ua/rss/ru/all_news2.0.xml",true),
          new AddressFeed("http://habrahabr.ru/rss/feed/posts/46eb2c6ff2689bf20e58042227b43ca6/",true)

        };
        private WebClient webClient;

        public FeedReader()
        {
            InitializeComponent();
            webClient = new WebClient();
            webClient.DownloadDataCompleted += WebClient_DownloadDataCompleted;
            InitTreeView();
        }

        private void InitTreeView()
        {


            if (FeedsTreeView.Nodes.Count != 0)
            {
                FeedsTreeView.Nodes.Clear();
            }
            foreach (var item in Adreses.Where(a => a.IsEnabled).Select(a => a.Uri))
            {
                SyndicationFeed feed;
                try
                {
                    using (XmlReader reader = XmlReader.Create(item))
                    {
                        feed = SyndicationFeed.Load(reader);
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                    continue;
                }

                TreeNode treeNode = new TreeNode(item);
                foreach (var i in feed.Items)
                {
                    TreeNode subnode = new TreeNode(i.Title.Text);
                    subnode.Tag = i;
                    treeNode.Nodes.Add(subnode);
                }
                FeedsTreeView.Nodes.Add(treeNode);
            }

        }

        private void FeedsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!webClient.IsBusy)
            {
                ClearFields();
                //Is subnode
                if (e.Node.Parent != null)
                    SetFields(e.Node);
            }
            else
            {
                FeedsTreeView.SelectedNode = null;
            }

        }

        private void ClearFields()
        {
            feedCaption.Text = "";


            feedPublicationDate.Text = "";
            feedPicture.Image = null;
            feedText.Text = "";
        }

        private void SetFields(TreeNode node)
        {

            FeedsTreeView.BeginUpdate();

            feedCaption.Text = node.Text;

            var f = (SyndicationItem)node.Tag;
            feedPublicationDate.Text = f.PublishDate.DateTime.ToString();
            var val = FindImageSRC_InExtension(f.ElementExtensions);
            SetText(f, val);
            FeedsTreeView.EndUpdate();
            //foreach (var h in f.ElementExtensions)
            //{

            //   // h.GetObject();
            //}
            //GetImage(f.);
        }

        private void SetText(SyndicationItem f, bool GetImage)
        {
            string text = null;
            //Якщо є фулл текст

            if (f.ElementExtensions.Any(ext => ext.OuterName == "fulltext"))
            {
                var fulltextExtension = f.ElementExtensions.First(ext => ext.OuterName == "fulltext");
                var fullText = fulltextExtension.GetObject<XElement>();
                //var fullText = fulltextExtension.GetObject<Fulltext>();

                text = fullText.Value;
            }
            //Якщо нема контенту
            else if (f.Content == null)
                text = ((TextSyndicationContent)f.Summary).Text;
            else
                text = ((TextSyndicationContent)f.Content).Text;



            if (!GetImage)
                FindImageSRCInText(text);

            //Clear all html tags
            feedText.Text = Regex.Replace(text, @"<[^>]*>", String.Empty);
        }

        private void FindImageSRCInText(string text)
        {
            string uri = GetUrl(text);
            if (uri != null)
            {
                GetImageFromURI(uri);
            }
        }

        private void GetImageFromURI(string uri)
        {
            //Wait when client is not busy

            Uri webUri = null;
            if (Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out webUri))
            {

                webClient.DownloadDataAsync(webUri);//,waiter);

                //SetImage(val.Result);
                //waiter.WaitOne();
            }



        }
        private void SetImage(byte[] Result)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(Result))
                {
                    var img = Bitmap.FromStream(ms);

                    feedPicture.Image = img;


                }
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }
        private void WebClient_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {



            if (e.Error == null && !e.Cancelled)
                SetImage(e.Result);
            //var waiter = (AutoResetEvent)e.UserState;
            //    waiter.Set();

        }

        private bool FindImageSRC_InExtension(SyndicationElementExtensionCollection extensions)
        {
            if (extensions.Count != 0)
            {
                try
                {
                    var e = extensions.First(l => l.OuterName == "image");
                    var el = e.GetObject<XElement>();
                    var uri = GetUrl(el.Value);
                    if (uri != null)
                    {
                        GetImageFromURI(uri);
                    }
                    //  string matchString = Regex.Match(el.Value, "<img.+?src=[\"'](.+?)[\"'].+?>", RegexOptions.IgnoreCase).Groups[1].Value;
                    //var src1 = srcMaybe.Value;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        private string GetUrl(string text)
        {
            string pattern = @"<img.*?src=""(?<url>.*?)"".*?>";
            Regex rx = new Regex(pattern);
            foreach (Match m in rx.Matches(text))
            {
                //var tag = m.Value;
                var url = m.Groups["url"].Value;
                //Return first intance of url

                return url;
            }
            return null;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FeedsTreeView.SelectedNode != null)
            {
                if (FeedsTreeView.SelectedNode.Level != 0)
                {
                    var tag = (SyndicationItem)FeedsTreeView.SelectedNode.Tag;
                    try
                    {
                        Process.Start(tag.Id);
                        return;
                    }
                    catch (Win32Exception)
                    {

                    }
                    try
                    {
                        Process.Start(tag.Links[0].Uri.AbsoluteUri);
                        return;
                    }
                    catch (Win32Exception)
                    {

                    }
                }
                else
                {
                    Process.Start(FeedsTreeView.SelectedNode.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedsTreeView.BeginUpdate();
            InitTreeView();
            FeedsTreeView.EndUpdate();
        }

        private void setFeedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFeeds setFeeds = new SetFeeds(Adreses);


            if (setFeeds.ShowDialog() == DialogResult.OK)
            {
                Adreses = setFeeds.AddressFeeds;
                InitTreeView();
            }
        }
    }
}
