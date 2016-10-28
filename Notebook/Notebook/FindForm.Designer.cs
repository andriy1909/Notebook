namespace Notebook
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.tbFindAnd = new System.Windows.Forms.TextBox();
            this.btnFindAndReplase = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 115);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFind);
            this.tabPage1.Controls.Add(this.tbFind);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 89);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Найти";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(211, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(49, 33);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(127, 20);
            this.tbFind.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbReplace);
            this.tabPage2.Controls.Add(this.tbFindAnd);
            this.tabPage2.Controls.Add(this.btnFindAndReplase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 89);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Найти і замінити";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(212, 29);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(104, 20);
            this.tbReplace.TabIndex = 2;
            // 
            // tbFindAnd
            // 
            this.tbFindAnd.Location = new System.Drawing.Point(21, 29);
            this.tbFindAnd.Name = "tbFindAnd";
            this.tbFindAnd.Size = new System.Drawing.Size(104, 20);
            this.tbFindAnd.TabIndex = 1;
            // 
            // btnFindAndReplase
            // 
            this.btnFindAndReplase.Location = new System.Drawing.Point(131, 20);
            this.btnFindAndReplase.Name = "btnFindAndReplase";
            this.btnFindAndReplase.Size = new System.Drawing.Size(75, 37);
            this.btnFindAndReplase.TabIndex = 0;
            this.btnFindAndReplase.Text = "Знайти і замінити на";
            this.btnFindAndReplase.UseVisualStyleBackColor = true;
            this.btnFindAndReplase.Click += new System.EventHandler(this.btnFindAndReplase_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 115);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.TextBox tbFindAnd;
        private System.Windows.Forms.Button btnFindAndReplase;
    }
}