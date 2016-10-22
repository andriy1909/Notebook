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
    public partial class PageForm : Form
    {
        public PageForm()
        {
            InitializeComponent();

            MainForm main = this.Owner as MainForm;
            /*if (main != null)
            {
                main.startPage = comboBox1.Text;
                main.search = comboBox2.Text;
            }*/
        }
    }
}
