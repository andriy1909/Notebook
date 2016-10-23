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
            foreach (FontFamily Family in FontFamilies.Families)
            {
                cbType.Items.Add(Family.Name);
            }
        }

        //Новий документ
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageForm page = new PageForm();
            page.Owner = this;
            page.TopLevel = false;
            page.Controls[0].ContextMenuStrip = contextMenuStrip1;
            page.ContextMenuStrip = contextMenuStrip1;
            page.MdiParent = this;
            page.Show();
        }
        //Відкрити документ
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //Зберегти
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //Зберегти як
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Вихід
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Котекстне меню - Шрифт...
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
        }
        //Вирізати
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Скопіювати
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Вставити
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Вибрати все
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Колір
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
        }

        //Про програму
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        //Напівжирний
        private void btnBold_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            RichTextBox text = (RichTextBox)this.ActiveMdiChild.Controls[0];
            oldFont = text.SelectionFont;
            if (oldFont.Bold == true)
                // якщо вже жирний то забираєм виділення
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold); // виділяєм жирним

            text.SelectionFont = newFont;
            text.Focus();
        }
        //Курсив
        private void btnCursive_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            RichTextBox text = (RichTextBox)this.ActiveMdiChild.Controls[0];
            oldFont = text.SelectionFont;
            if (oldFont.Italic == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic); 

            text.SelectionFont = newFont;
            text.Focus();
        }
        //Підкреслений
        private void btnEmphatic_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            RichTextBox text = (RichTextBox)this.ActiveMdiChild.Controls[0];
            oldFont = text.SelectionFont;
            if (oldFont.Underline == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            text.SelectionFont = newFont;
            text.Focus();
        }
        //Закреслений
        private void btnStrikeout_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            RichTextBox text = (RichTextBox)this.ActiveMdiChild.Controls[0];
            oldFont = text.SelectionFont;
            if (oldFont.Strikeout == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);

            text.SelectionFont = newFont;
            text.Focus();
        }

        //Розмістити вікна каскадно
        private void каскадноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //Розмістити вікна горизонтально
        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        //Розмістити вікна вертикально
        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        //Закрити вікно
        private void закритиВікноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageForm page = (PageForm)this.ActiveMdiChild;
            page.Close();
        }
        //Закрити всі вікна
        private void закритиВсіВікнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form page in this.MdiChildren)
            {
                page.Close();
            }
            
        }
    }
}
