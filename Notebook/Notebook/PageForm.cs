using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Notebook
{
    public partial class PageForm : Form
    {
        public String file { get; set; }
        public String filename { get; set; }
        PrintDocument def;

        public PageForm()
        {
            InitializeComponent();
            def = new PrintDocument();
            file = "";
            filename = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox temp = new RichTextBox();
            try
            {
                temp.LoadFile(file);
            }
            catch (Exception)
            {
                temp.Text = "";
            }

            String st = Text;
            if (file == "" && richTextBox1.Text != "" || richTextBox1.Rtf != temp.Rtf)
                if (st[st.Length - 1] != '*')
                    Text = st + "*";
            else
                if (st[st.Length - 1] == '*')
                    Text.Remove(st.Length - 1);
        }

        
    }
}
