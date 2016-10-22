using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InstalledFontCollection FontFamilies = new InstalledFontCollection();
            ToolStripComboBox tsComboBox = new ToolStripComboBox();
            foreach (FontFamily Family in FontFamilies.Families)
            {
                tsComboBox.Items.Add(Family.Name);
                cbType.Items.Add(Family.Name);
            }
            tsComboBox.Text = "Arial";
            contextMenuStrip1.Items.Add(tsComboBox);
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageForm page = new PageForm();
            page.Owner = this;
            page.TopLevel = false; 
            page.ContextMenuStrip = contextMenuStrip1;
            page.MdiParent = this;
            //this.Controls.Add(page);
            page.Show();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
           // fontDialog1.Font=
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //textBox1.Text = ((RichTextBox)OwnedForms[0].Controls[0]).Text;
        }
    }
}
