using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_3
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void LoadPicture(string FileName)
        {
            if (System.IO.File.Exists(FileName))
            {
                this.pictureBox1.Load(FileName);
                if (pictureBox1.Image.Width < pictureBox1.ClientRectangle.Width/ 10)
                    ViewingStyle.SelectedIndex = 2;
                else
                    ViewingStyle.SelectedIndex = 0;
                statusStrip1.Items[0].Text = "Ширина: "  + Convert.ToString(pictureBox1.Image.Width) + "; Высота: " + Convert.ToString(pictureBox1.Image.Height);

            }
        }
        private void ViewingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ViewingStyle.SelectedIndex)
            {
                case 0: this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; break;
                case 1: this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; break;
                case 2: this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case 3: this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; break;
            }
        }
        private void panel1_Resize(object sender,EventArgs e)
        {
            this.pictureBox1.Size = this.panel1.ClientSize;
        }
    }
}
