using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RSSientReader
{
    public partial class SetFeeds : Form
    {
        public List<AddressFeed> AddressFeeds = new List<AddressFeed>();
        public SetFeeds(List<AddressFeed> addressFeeds)
        {
            InitializeComponent();
            this.checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
            foreach (var item in addressFeeds)
            {
                checkedListBox1.Items.Add(item, item.IsEnabled);
            }
            //AddressFeeds = addressFeeds;
        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var af = (AddressFeed)checkedListBox1.Items[e.Index];
            if (e.NewValue != CheckState.Indeterminate)
            {
                if (e.NewValue == CheckState.Checked)
                    af.IsEnabled = true;
                else
                    af.IsEnabled = false;
            }

            // e.Index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                AddressFeed addressFeed = new AddressFeed(textBox1.Text, true);
                //checkedListBox1.Items.Add()
                checkedListBox1.Items.Add(addressFeed, true);
            }
        }

        private void SetFeeds_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                foreach (AddressFeed item in checkedListBox1.Items)
                {
                    AddressFeeds.Add(item);
                }
                DialogResult = DialogResult.OK;

            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }

}
