using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Font_Comparison
{
    public partial class ListOutputForm : Form
    {
        public List<string> uniqueSourceList { get; set; }
        public List<string> uniqueTargetList { get; set; }
        public ListOutputForm()
        {
            uniqueSourceList = new List<string>();
            uniqueTargetList = new List<string>();
            InitializeComponent();
        }

        public void ShowLists(string sourceName, List<string> sourceList, string targetName, List<string> targetList)
        {
            label1.Text = sourceName.Replace('\\', '/');
            label2.Text = targetName.Replace('\\', '/');

            foreach(var entry in sourceList)
            {
                if (!targetList.Contains(entry))
                {
                    listView1.Items.Add(entry);
                    listView1.Items[listView1.Items.Count - 1].BackColor = Color.Aqua;
                    uniqueSourceList.Add(entry);
                }
                else listView1.Items.Add(entry);
            }

            foreach(var entry in targetList)
            {
                if (!sourceList.Contains(entry))
                {
                    listView2.Items.Add(entry);
                    listView2.Items[listView2.Items.Count - 1].BackColor = Color.Aqua;
                    uniqueTargetList.Add(entry);
                }
                else listView2.Items.Add(entry);
            }
        }

        private void sourceTransferButton_Click(object sender, EventArgs e)
        {
            var folderLocation = label2.Text.Replace("FontList.txt", string.Empty);

            var csv = "G:/Apps/MISFontList/fonts.csv";

            foreach (var entry in uniqueSourceList)
            {

            }
        }
    }
}
