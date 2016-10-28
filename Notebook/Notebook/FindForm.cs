using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class FindForm : Form
    {
        RichTextBox richTextBox1;
        PageForm page;
        MainForm main;

        public FindForm(PageForm page)
        {
            this.page = page;
            richTextBox1 =(RichTextBox)page.Controls[0];
            InitializeComponent();
        }

        //Пошук
        private void btnFind_Click(object sender, EventArgs e)
        {
            string s = tbFind.Text;
            //richTextBox1.Select(richTextBox1.Find(s),s.Length);
            foreach (PageForm item in MdiChildren)
            {
                if (item == page)
                    ((RichTextBox)item.Controls[0]).Select(richTextBox1.Find(s), s.Length);
            }
        }
        //Пошук і заміна
        private void btnFindAndReplase_Click(object sender, EventArgs e)
        {

        }
    }
}
