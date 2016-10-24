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
        MainForm main;

        public FindForm()
        {
            main = Owner as MainForm;
            richTextBox1 = main.getRichTextBox();
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string s = tbFind.Text;
            richTextBox1.Find(s);
        }
    }
}
