namespace ЛР_3
{
    partial class MDIParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuantityOfFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusWindowsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolCloseAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolAboutAuthor = new System.Windows.Forms.ToolStripButton();
            this.ToolAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.toolStripSeparator1,
            this.MenuQuit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Image = global::ЛР_3.Properties.Resources.open_file_40455;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(156, 22);
            this.MenuOpen.Text = "Открыть папку";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Image = global::ЛР_3.Properties.Resources.Logout_37127;
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.Size = new System.Drawing.Size(156, 22);
            this.MenuQuit.Text = "Выход";
            this.MenuQuit.Click += new System.EventHandler(this.MenuQuit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCascade,
            this.MenuVertical,
            this.MenuHorizontal,
            this.toolStripSeparator2,
            this.MenuCloseAll});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem2.Text = "Окна";
            // 
            // MenuCascade
            // 
            this.MenuCascade.Image = global::ЛР_3.Properties.Resources.windows_cascade_15088;
            this.MenuCascade.Name = "MenuCascade";
            this.MenuCascade.Size = new System.Drawing.Size(158, 22);
            this.MenuCascade.Text = "Каскадом";
            // 
            // MenuVertical
            // 
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(158, 22);
            this.MenuVertical.Text = "Вертикально";
            this.MenuVertical.Click += new System.EventHandler(this.MenuVertical_Click);
            // 
            // MenuHorizontal
            // 
            this.MenuHorizontal.Name = "MenuHorizontal";
            this.MenuHorizontal.Size = new System.Drawing.Size(158, 22);
            this.MenuHorizontal.Text = "Горизонтально";
            this.MenuHorizontal.Click += new System.EventHandler(this.MenuHorizontal_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.Image = global::ЛР_3.Properties.Resources.icons8_закрыть_все_вкладки_16;
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.Size = new System.Drawing.Size(158, 22);
            this.MenuCloseAll.Text = "Закрыть все";
            this.MenuCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAboutAuthor,
            this.MenuAboutProgram});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem3.Text = "Справка";
            // 
            // MenuAboutAuthor
            // 
            this.MenuAboutAuthor.Image = global::ЛР_3.Properties.Resources.icons8_администратор_женщина_16;
            this.MenuAboutAuthor.Name = "MenuAboutAuthor";
            this.MenuAboutAuthor.Size = new System.Drawing.Size(149, 22);
            this.MenuAboutAuthor.Text = "Об авторе";
            this.MenuAboutAuthor.Click += new System.EventHandler(this.MenuAboutAuthor_Click);
            // 
            // MenuAboutProgram
            // 
            this.MenuAboutProgram.Image = global::ЛР_3.Properties.Resources.icons8_программирование_16;
            this.MenuAboutProgram.Name = "MenuAboutProgram";
            this.MenuAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.MenuAboutProgram.Text = "О программе";
            this.MenuAboutProgram.Click += new System.EventHandler(this.MenuAboutProgram_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuQuantityOfFiles});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem4.Text = "Файлы";
            // 
            // MenuQuantityOfFiles
            // 
            this.MenuQuantityOfFiles.Name = "MenuQuantityOfFiles";
            this.MenuQuantityOfFiles.Size = new System.Drawing.Size(177, 22);
            this.MenuQuantityOfFiles.Text = "Колиество файлов";
            this.MenuQuantityOfFiles.Click += new System.EventHandler(this.MenuQuantityOfFiles_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusPath,
            this.toolStripStatusLabel1,
            this.StatusWindowsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusPath
            // 
            this.StatusPath.Name = "StatusPath";
            this.StatusPath.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(769, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Готов";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusWindowsCount
            // 
            this.StatusWindowsCount.AutoSize = false;
            this.StatusWindowsCount.Name = "StatusWindowsCount";
            this.StatusWindowsCount.Size = new System.Drawing.Size(150, 17);
            this.StatusWindowsCount.Text = "Открыто окон: 0";
            this.StatusWindowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolOpen,
            this.toolStripSeparator3,
            this.ToolCloseAll,
            this.toolStripSeparator4,
            this.ToolAboutAuthor,
            this.ToolAboutProgram,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolOpen
            // 
            this.ToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolOpen.Image = global::ЛР_3.Properties.Resources.open_file_40455;
            this.ToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolOpen.Name = "ToolOpen";
            this.ToolOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolOpen.Text = "toolStripButton1";
            this.ToolOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolCloseAll
            // 
            this.ToolCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCloseAll.Image = global::ЛР_3.Properties.Resources.icons8_закрыть_все_вкладки_161;
            this.ToolCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCloseAll.Name = "ToolCloseAll";
            this.ToolCloseAll.Size = new System.Drawing.Size(23, 22);
            this.ToolCloseAll.Text = "toolStripButton2";
            this.ToolCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolAboutAuthor
            // 
            this.ToolAboutAuthor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutAuthor.Image = global::ЛР_3.Properties.Resources.icons8_администратор_женщина_16;
            this.ToolAboutAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutAuthor.Name = "ToolAboutAuthor";
            this.ToolAboutAuthor.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutAuthor.Text = "toolStripButton3";
            this.ToolAboutAuthor.Click += new System.EventHandler(this.MenuAboutAuthor_Click);
            // 
            // ToolAboutProgram
            // 
            this.ToolAboutProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutProgram.Image = global::ЛР_3.Properties.Resources.icons8_программирование_16;
            this.ToolAboutProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutProgram.Name = "ToolAboutProgram";
            this.ToolAboutProgram.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutProgram.Text = "toolStripButton4";
            this.ToolAboutProgram.Click += new System.EventHandler(this.MenuAboutProgram_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 421);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл Изображений";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 399);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 421);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.MenuQuantityOfFiles_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 492);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent";
            this.Text = "Обозреватель изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem3;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Splitter splitter1;
        private ToolStripMenuItem MenuOpen;
        private ToolStripMenuItem MenuQuit;
        private ToolStripMenuItem MenuCascade;
        private ToolStripMenuItem MenuVertical;
        private ToolStripMenuItem MenuHorizontal;
        private ToolStripMenuItem MenuCloseAll;
        private ToolStripMenuItem MenuAboutAuthor;
        private ToolStripMenuItem MenuAboutProgram;
        private ToolStripStatusLabel StatusPath;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel StatusWindowsCount;
        private ToolStripButton ToolOpen;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ToolCloseAll;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton ToolAboutAuthor;
        private ToolStripButton ToolAboutProgram;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem MenuQuantityOfFiles;
        private ToolStripButton toolStripButton1;
    }
}