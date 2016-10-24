using System;
using System.Drawing;
using System.Drawing.Text;
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
            cbType.SelectedIndex = 0;
        }

        //Створення пустого документа
        public void newPage()
        {
            PageForm page = new PageForm();
            page.TopLevel = false;
            page.MdiParent = this;
            page.Controls[0].ContextMenuStrip = contextMenuStrip1;
            page.Show();
        }
        public RichTextBox getRichTextBox()
        {
            return (RichTextBox)ActiveMdiChild.Controls[0];
        }
        public void setRichTextBox(RichTextBox rich)
        {
            ((RichTextBox)ActiveMdiChild.Controls[0]).Rtf = rich.Rtf;
        }

        //Копка - Новий документ
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newPage();
        }
        //Відкрити документ
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newPage();
            ((PageForm)this.ActiveMdiChild).open();
        }
        //Зберегти
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).save();
        }
        //Зберегти як
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).saveAs();
        }
        //Друк
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).print();
        }
        //Попередній перегляд
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).printPreview();
        }
        //Вихід
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Котекстне меню - Шрифт...
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((PageForm)this.ActiveMdiChild).ChangeFont();
        }        
        //Вирізати
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).cut();
        }
        //Скопіювати
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).copy();
        }
        //Вставити
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).paste();
        }
        //Вибрати все
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).selectAll();
        }
        //Колір
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ((PageForm)this.ActiveMdiChild).changeColor();
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
            if (MdiChildren.Length > 0)
            {
                Font oldFont, newFont;
                RichTextBox text = (RichTextBox)this.ActiveMdiChild.Controls[0];
                oldFont = text.SelectionFont;
                if (oldFont.Bold == true)
                    // якщо весь жирний то забираєм виділення
                    newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
                else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold); // виділяєм жирним

                text.SelectionFont = newFont;
                text.Focus();
            }
        }
        //Курсив
        private void btnCursive_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
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
        }
        //Підкреслений
        private void btnEmphatic_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
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
        }
        //Закреслений
        private void btnStrikeout_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
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
        }
        //Зміна шрифту
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MdiChildren.Length>0)
            {
                InstalledFontCollection FontFamilies = new InstalledFontCollection();
                foreach (FontFamily Family in FontFamilies.Families)
                {
                    if (Family.Name == cbType.Text)
                    {
                        RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                        richTextBox1.SelectionFont = new Font(Family, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                        richTextBox1.Focus();
                        break;
                    }
                }
            }
        }
        //Зміна розміру шрифту
        private void numSize_TextChanged(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, int.Parse(numSize.Text), richTextBox1.SelectionFont.Style);
                richTextBox1.Focus();
            }
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
            if (MdiChildren.Length > 0)
            {
                PageForm page = (PageForm)this.ActiveMdiChild;
                page.Close();
            }
        }
        //Закрити всі вікна
        private void закритиВсіВікнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form page in this.MdiChildren)
            {
                page.Close();
            }
            
        }

        private void пошукІЗамінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                FindForm find = new FindForm();
                find.Owner = this;
                find.ShowDialog();
            }
        }
    }
}
