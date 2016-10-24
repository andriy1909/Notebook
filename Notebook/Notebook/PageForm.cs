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

        //Відкрити документ
        public void open()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Notebook files (*.nb)|*.nb";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                richTextBox1.LoadFile(openFileDialog1.FileName);
                file = openFileDialog1.FileName;
                filename = openFileDialog1.SafeFileName;
                Text = filename;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Зберегти
        public void save()
        {
            if (file == "")
                saveAs();
            else
                try
                {
                    richTextBox1.SaveFile(file);
                    Text = filename;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
        }
        //Зберегти як
        public void saveAs()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "rb";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string filename = saveFileDialog1.FileName;
            try
            {
                richTextBox1.SaveFile(filename);
                this.file = filename;
                this.filename = System.IO.Path.GetFileName(filename);
                this.Text = this.filename;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Друк
        public void print()
        {
            PrintDialog printDialog1 = new PrintDialog();
            if(printDialog1.ShowDialog()!=DialogResult.OK)
                return;

            def.PrintPage += new PrintPageEventHandler(PRD);
            def.DocumentName = "Document1";
            def.PrinterSettings = printDialog1.PrinterSettings;
        }
        void PRD(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString(richTextBox1.Text, Font, new SolidBrush(Color.Black), 10, 10);
        }
        //Попередній перегляд
        public void printPreview()
        {
            PrintDialog printDialog1 = new PrintDialog();

            def.PrintPage += new PrintPageEventHandler(PRD);
            def.DocumentName = "Document1";
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.WindowState = FormWindowState.Maximized;
            dlg.Document = def;
            dlg.ShowDialog();
        }

        //Котекстне меню - Шрифт...
        public void ChangeFont()
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = richTextBox1.SelectionFont;
            if(fontDialog.ShowDialog()==DialogResult.OK);
            richTextBox1.SelectionFont = fontDialog.Font;
        }
        //Вирізати
        public void cut()
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
            richTextBox1.SelectedText = "";
        }
        //Скопіювати
        public void copy()
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
        }
        //Вставити
        public void paste()
        {
            richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
        }
        //Вибрати все
        public void selectAll()
        {
            richTextBox1.SelectAll();
        }

        //Колір
        public void changeColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = richTextBox1.SelectionColor;
            if(colorDialog.ShowDialog()==DialogResult.OK);
            richTextBox1.SelectionColor = colorDialog.Color;
        }

        //Перевіряємо чи збережені зміни
        private void PageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool b = true;
            RichTextBox temp = new RichTextBox();
            try
            {
                temp.LoadFile(file);
            }
            catch (Exception)
            {
                temp.Text = "";
                b = false;
            }

            if (file == "" && richTextBox1.TextLength!=0 || b && richTextBox1.Rtf != temp.Rtf)
            {
                DialogResult = MessageBox.Show("Зберегти зміни", filename, MessageBoxButtons.YesNoCancel);
                if (DialogResult == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                    if (DialogResult == DialogResult.Yes)
                {
                    save();
                    Close();
                }
                else
                    e.Cancel = true;
            }
        }
    }
}
