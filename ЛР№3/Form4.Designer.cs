namespace ЛР_3
{
    partial class QuantityOfFiles
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MenuQuantityOfFiles = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(105, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MenuQuantityOfFiles
            // 
            this.MenuQuantityOfFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuQuantityOfFiles.Location = new System.Drawing.Point(0, 0);
            this.MenuQuantityOfFiles.Name = "MenuQuantityOfFiles";
            this.MenuQuantityOfFiles.Size = new System.Drawing.Size(105, 198);
            this.MenuQuantityOfFiles.TabIndex = 1;
            this.MenuQuantityOfFiles.Text = "Подсчет";
            this.MenuQuantityOfFiles.UseVisualStyleBackColor = true;
            this.MenuQuantityOfFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(105, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 198);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // QuantityOfFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 198);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.MenuQuantityOfFiles);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuantityOfFiles";
            this.Text = "Счет файлов";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button MenuQuantityOfFiles;
        private Splitter splitter1;
    }
}