using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Notebook
{
    public partial class MainForm : Form
    {
        PrintDocument def;
        int m_PrintPageNumber = 1;
        StringReader m_myReader;

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
            page.FormClosing += PageForm_FormClosing;
            page.Controls[0].ContextMenuStrip = contextMenuStrip1;
            page.Show();
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
            PageForm pageFotm = ((PageForm)this.ActiveMdiChild);
            RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Notebook files (*.nb)|*.nb";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                richTextBox1.LoadFile(openFileDialog1.FileName);
                pageFotm.file = openFileDialog1.FileName;
                pageFotm.filename = openFileDialog1.SafeFileName;
                pageFotm.Text = pageFotm.filename;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Зберегти
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                PageForm pageFotm = ((PageForm)this.ActiveMdiChild);
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                if (pageFotm.file == "")
                    saveAsToolStripMenuItem.PerformClick();
                else
                    try
                    {
                        richTextBox1.SaveFile(pageFotm.file);
                        Text = pageFotm.filename;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
            }
        }
        //Зберегти як
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                PageForm pageFotm = ((PageForm)this.ActiveMdiChild);
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = "rb";
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                string filename = saveFileDialog1.FileName;
                try
                {
                    richTextBox1.SaveFile(filename);
                    pageFotm.file = filename;
                    pageFotm.filename = System.IO.Path.GetFileName(filename);
                    pageFotm.Text = pageFotm.filename;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        //Друк
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                PageForm pageFotm = ((PageForm)this.ActiveMdiChild);
                //PrintDialog printDialog1 = new PrintDialog();
                if (printDialog1.ShowDialog() != DialogResult.OK)
                    return;

                def.PrintPage += new PrintPageEventHandler(PRD);
                def.DocumentName = "Document1";
                def.PrinterSettings = printDialog1.PrinterSettings;
            }
            //MenuFilePrint();
        }
        void PRD(object sender, PrintPageEventArgs e)
        {
            /*e.Graphics.DrawLine(colontitulPen,
               leftMargin,
               e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
               e.MarginBounds.Right, e.MarginBounds.Top +
               printFont.GetHeight(e.Graphics) + 3);*/
            RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
            Graphics g = e.Graphics;
            g.DrawString(richTextBox1.Text, Font, new SolidBrush(Color.Black), 10, 10);
        }
        //Попередній перегляд
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                PrintDialog printDialog2 = new PrintDialog();

                def.PrintPage += new PrintPageEventHandler(PRD);
                def.DocumentName = "Document1";
                PrintPreviewDialog printPreviewDialog2 = new PrintPreviewDialog();
                printPreviewDialog2.WindowState = FormWindowState.Maximized;
                printPreviewDialog2.Document = def;
                printPreviewDialog2.ShowDialog();
            }
            //MenuFilePrintPreview();
        }
        //Вихід
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Котекстне меню - Шрифт...
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                FontDialog fontDialog = new FontDialog();
                fontDialog.Font = richTextBox1.SelectionFont;
                if (fontDialog.ShowDialog() == DialogResult.OK) ;
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }
        //Вирізати
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
                richTextBox1.SelectedText = "";
            }
        }
        //Скопіювати
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
            }
        }
        //Вставити
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }
        //Вибрати все
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                richTextBox1.SelectAll();
            }
        }
        //Колір
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.Color = richTextBox1.SelectionColor;
                if (colorDialog.ShowDialog() == DialogResult.OK) ;
                richTextBox1.SelectionColor = colorDialog.Color;
            }
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
            if (MdiChildren.Length > 0)
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

        //Пошук і заміна -
        private void пошукІЗамінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (MdiChildren.Length > 0)
            {
                PageForm page = (PageForm)ActiveMdiChild;
                FindForm find = new FindForm(page);
                find.TopLevel = false;
                find.MdiParent = this;
                find.Show();
            }*/
        }

        //Перевіряємо чи збережені зміни
        private void PageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PageForm pageFotm = ((PageForm)this.ActiveMdiChild);
            RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
            bool b = true;
            RichTextBox temp = new RichTextBox();
            try
            {
                temp.LoadFile(pageFotm.file);
            }
            catch (Exception)
            {
                temp.Text = "";
                b = false;
            }

            if (pageFotm.file == "" && richTextBox1.TextLength != 0 || b && richTextBox1.Rtf != temp.Rtf)
            {
                DialogResult = MessageBox.Show("Зберегти зміни", pageFotm.filename, MessageBoxButtons.YesNoCancel);
                if (DialogResult == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                    if (DialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem.PerformClick();
                }
                else
                    e.Cancel = true;
            }
        }

        //Пошук і заміна
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                string s = toolStripTextBox1.Text;
                RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];

                if (toolStripTextBox2.Text == "")
                {
                    int index = richTextBox1.Find(s);
                    if (index >= 0)
                        richTextBox1.Select(richTextBox1.Find(s), s.Length);
                    else
                    {
                        MessageBox.Show("Не знайдено", "", MessageBoxButtons.OK);
                    }
                    /*bool b = true;
                    while (b)
                    {

                        int index = richTextBox1.Find(s);
                        if (index >= 0)
                        {
                            richTextBox1.Select(richTextBox1.Find(s), s.Length);
                            richTextBox1.SelectionColor = Color.Red;
                        }
                        else
                        {
                            b = false;
                        }
                    }*/
                }
                else
                {
                    bool b = true;
                    while (b)
                    {

                        int index = richTextBox1.Find(s);
                        if (index >= 0)
                        {
                            richTextBox1.Select(richTextBox1.Find(s), s.Length);
                            richTextBox1.SelectedText = toolStripTextBox2.Text;
                        }
                        else
                        {
                            b = false;
                        }

                    }
                }
            }

        }

        /// <summary>
        /// Обработка события PrintPage
        /// </summary>
        private void PrintPageEventHandler(object sender,
          System.Drawing.Printing.PrintPageEventArgs e)
        {
            RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];
            StringReader m_myReader = new StringReader(richTextBox1.Text);
            int lineCount = 0;       // счетчик строк
            float linesPerPage = 0;  // количество строк на одной странице
            float yLinePosition = 0; // текущая позиция при печати по 
                                     // вертикальной оси
            string currentLine = null;  // текст текущей строки

            // Шрифт для печати текста
            Font printFont = richTextBox1.Font;

            // Кисть для печати текста
            SolidBrush printBrush = new SolidBrush(Color.Black);

            // Размер отступа слева
            float leftMargin = e.MarginBounds.Left;

            // Размер отступа сверху
            float topMargin = e.MarginBounds.Top +
               3 * printFont.GetHeight(e.Graphics);

            // Вычисляем количество строк на одной странице с учетом отступа
            linesPerPage = (e.MarginBounds.Height -
               6 * printFont.GetHeight(e.Graphics)) /
               printFont.GetHeight(e.Graphics);

            // Цикл печати всех строк страницы
            while (lineCount < linesPerPage &&
               ((currentLine = m_myReader.ReadLine()) != null))
            {
                // Вычисляем позицию очередной распечатываемой строки
                yLinePosition = topMargin + (lineCount *
                  printFont.GetHeight(e.Graphics));

                // Печатаем очередную строку
                e.Graphics.DrawString(currentLine, printFont, printBrush,
                  leftMargin, yLinePosition, new StringFormat());

                // Переходим к следующей строке
                lineCount++;
            }

            // Печать колонтитулов страницы

            // Номер текущей страницы
            string sPageNumber = "Сторінка " + m_PrintPageNumber.ToString();

            // Вычисляем размеры прямоугольной области, занимаемой верхним 
            // колонтитулом страницы
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(sPageNumber, printFont,
               e.MarginBounds.Right - e.MarginBounds.Left);

            // Печатаем номер страницы
            e.Graphics.DrawString(sPageNumber, printFont, printBrush,
               e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top,
               new StringFormat());

            // Печатаем имя файла документа
            e.Graphics.DrawString(this.Text, printFont, printBrush,
               e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());

            // Кисть для рисования горизонтальной линии, 
            // отделяющей верхний колонтитул
            Pen colontitulPen = new Pen(Color.Black);
            colontitulPen.Width = 2;

            // Рисуем верхнюю линию
            e.Graphics.DrawLine(colontitulPen,
               leftMargin,
               e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
               e.MarginBounds.Right, e.MarginBounds.Top +
               printFont.GetHeight(e.Graphics) + 3);

            // Рисуем линию, отделяющую нижний колонтитул документа
            e.Graphics.DrawLine(colontitulPen,
               leftMargin, e.MarginBounds.Bottom - 3,
               e.MarginBounds.Right, e.MarginBounds.Bottom - 3);

            // Печатаем текст нижнего колонтитула
            e.Graphics.DrawString(
            "Notebook",
               printFont, printBrush,
               e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());

            // Если напечатаны не все строки документа, 
            // переходим к следующей странице
            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }

            // Иначе завершаем печать страницы
            else
                e.HasMorePages = false;

            // Освобождаем ненужные более ресурсы
            printBrush.Dispose();
            colontitulPen.Dispose();
            m_myReader.Close();
        }

        /// <summary>
        /// Печать документа
        /// </summary>
        private void MenuFilePrint()
        {
            RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];

            m_PrintPageNumber = 1;

            string strText = richTextBox1.Text;
            m_myReader = new StringReader(strText);

            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
            m_myReader.Close();
        }

        /*
            //Расскажем о том, как работает метод MenuFilePrint.
            //Печать нашего документа будет начинаться с первой страницы, поэтому в поле m_PrintPageNumber мы записываем значение 1:
            m_PrintPageNumber = 1;

            //Далее мы читаем текущее содержимое окна редактирования текста в поток m_myReader класса StringReader:
            string strText = richTextBox1.Text;
            StringReader m_myReader = new StringReader(strText);

            //Эта операция выполняется точно таким же способом, что и в только что описанном методе MenuFilePrintPreview, предназначенном для отображения окна предварительного просмотра документа.
            //Далее мы задаем границы отступов на распечатываемой странице и отображаем диалоговое окно печати документа.Если пользователь щелкает в этом окне кнопку OK, документ printDocument1 отправляется на печать методом Print:
            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }

            //Далее ненужный более поток m_myReader закрывается методом Close:
            m_myReader.Close();
        }*/

        /// <summary>
        /// Предварительный просмотр перед печатью документа
        /// </summary>
        private void MenuFilePrintPreview()
        {
            RichTextBox richTextBox1 = (RichTextBox)this.ActiveMdiChild.Controls[0];

            m_PrintPageNumber = 1;

            string strText = richTextBox1.Text;
            StringReader m_myReader = new StringReader(strText);
            Margins margins = new Margins(100, 50, 50, 50);

            printDocument1.DefaultPageSettings.Margins = margins;
            printPreviewDialog1.ShowDialog();

            m_myReader.Close();
        }

        //Кроме того, добавьте вызов метода MenuFilePrintPreview в тело обработчика события строки Print Preview меню File:


        //Как работает метод MenuFilePrintPreview?
//Прежде всего, этот метод записывает в поле m_PrintPageNumber значение 1, т.к.просмотр начнется с первой страницы документа:
/*m_PrintPageNumber = 1;

//Далее метод читает текущее содержимое окна редактирования в поток m_myReader класса StringReader:
string strText = richTextBox1.Text;
        m_myReader = new StringReader(strText);

        Затем метод MenuFilePrintPreview отображает окно предварительного просмотра, задавая для него размеры полей отступов на странице:
Margins margins = new Margins(100, 50, 50, 50);
        printDocument1.DefaultPageSettings.Margins = margins;
printPreviewDialog1.ShowDialog();

Конструктор Margins получает через свои параметры величину левого, правого, верхнего и нижнего отступа в сотых долях дюйма.
Отобразив панель предварительного просмотра, метод MenuFilePrintPreview закрывает поток m_myReader:
m_myReader.Close();*/
    }
}
