namespace Notebook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вікнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закритиВікноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закритиВсіВікнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.btnBold = new System.Windows.Forms.Label();
            this.btnCursive = new System.Windows.Forms.Label();
            this.btnEmphatic = new System.Windows.Forms.Label();
            this.btnStrikeout = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPast = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.tbReplace);
            this.panel.Controls.Add(this.btnReplace);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.tbSearch);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnStrikeout);
            this.panel.Controls.Add(this.btnEmphatic);
            this.panel.Controls.Add(this.btnCursive);
            this.panel.Controls.Add(this.btnBold);
            this.panel.Controls.Add(this.numSize);
            this.panel.Controls.Add(this.cbType);
            this.panel.Controls.Add(this.btnCopy);
            this.panel.Controls.Add(this.btnCut);
            this.panel.Controls.Add(this.btnPast);
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(769, 61);
            this.panel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вікнаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            // 
            // вікнаToolStripMenuItem
            // 
            this.вікнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.горизонтальноToolStripMenuItem,
            this.вертикальноToolStripMenuItem,
            this.закритиВікноToolStripMenuItem,
            this.закритиВсіВікнаToolStripMenuItem});
            this.вікнаToolStripMenuItem.Name = "вікнаToolStripMenuItem";
            this.вікнаToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вікнаToolStripMenuItem.Text = "Вікна";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            // 
            // горизонтальноToolStripMenuItem
            // 
            this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.горизонтальноToolStripMenuItem.Text = "Горизонтально";
            // 
            // вертикальноToolStripMenuItem
            // 
            this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.вертикальноToolStripMenuItem.Text = "Вертикально";
            // 
            // закритиВікноToolStripMenuItem
            // 
            this.закритиВікноToolStripMenuItem.Name = "закритиВікноToolStripMenuItem";
            this.закритиВікноToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.закритиВікноToolStripMenuItem.Text = "Закрити вікно";
            // 
            // закритиВсіВікнаToolStripMenuItem
            // 
            this.закритиВсіВікнаToolStripMenuItem.Name = "закритиВсіВікнаToolStripMenuItem";
            this.закритиВсіВікнаToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.закритиВсіВікнаToolStripMenuItem.Text = "Закрити всі вікна";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(112, 7);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(109, 21);
            this.cbType.TabIndex = 4;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(227, 7);
            this.numSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(40, 20);
            this.numSize.TabIndex = 5;
            this.numSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnBold
            // 
            this.btnBold.AutoSize = true;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBold.Location = new System.Drawing.Point(131, 36);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(22, 17);
            this.btnBold.TabIndex = 6;
            this.btnBold.Text = "Ж";
            // 
            // btnCursive
            // 
            this.btnCursive.AutoSize = true;
            this.btnCursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCursive.Location = new System.Drawing.Point(162, 36);
            this.btnCursive.Name = "btnCursive";
            this.btnCursive.Size = new System.Drawing.Size(16, 16);
            this.btnCursive.TabIndex = 7;
            this.btnCursive.Text = "К";
            // 
            // btnEmphatic
            // 
            this.btnEmphatic.AutoSize = true;
            this.btnEmphatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmphatic.Location = new System.Drawing.Point(186, 36);
            this.btnEmphatic.Name = "btnEmphatic";
            this.btnEmphatic.Size = new System.Drawing.Size(18, 16);
            this.btnEmphatic.TabIndex = 8;
            this.btnEmphatic.Text = "П";
            // 
            // btnStrikeout
            // 
            this.btnStrikeout.AutoSize = true;
            this.btnStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStrikeout.Location = new System.Drawing.Point(213, 36);
            this.btnStrikeout.Name = "btnStrikeout";
            this.btnStrikeout.Size = new System.Drawing.Size(31, 16);
            this.btnStrikeout.TabIndex = 9;
            this.btnStrikeout.Text = "abc";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Text color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ctrl + C,V,X";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(633, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = global::Notebook.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(739, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::Notebook.Properties.Resources.copy;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(4, 28);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(31, 29);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnCut
            // 
            this.btnCut.BackgroundImage = global::Notebook.Properties.Resources.cut;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Location = new System.Drawing.Point(4, 1);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(31, 29);
            this.btnCut.TabIndex = 2;
            this.btnCut.UseVisualStyleBackColor = true;
            // 
            // btnPast
            // 
            this.btnPast.BackgroundImage = global::Notebook.Properties.Resources.paste;
            this.btnPast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPast.Location = new System.Drawing.Point(35, 0);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(62, 57);
            this.btnPast.TabIndex = 1;
            this.btnPast.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReplace.Location = new System.Drawing.Point(551, 34);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(107, 20);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "Найти і замінити на";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // tbReplace
            // 
            this.tbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplace.Location = new System.Drawing.Point(664, 34);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(100, 20);
            this.tbReplace.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 471);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Notebook";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вікнаToolStripMenuItem;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnPast;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закритиВікноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закритиВсіВікнаToolStripMenuItem;
        private System.Windows.Forms.Label btnStrikeout;
        private System.Windows.Forms.Label btnEmphatic;
        private System.Windows.Forms.Label btnCursive;
        private System.Windows.Forms.Label btnBold;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btnReplace;
    }
}

