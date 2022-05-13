using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ЛР_3
{
    public partial class MDIParent : Form
    {
        public string FolderName { get; private set; }

        public MDIParent()
        {
            InitializeComponent();
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
            FolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (FolderDialog.ShowDialog(this) == DialogResult.OK)
            {
                FolderName = FolderDialog.SelectedPath;
                this.statusStrip1.Items[0].Text = FolderName;
                listBox1.Items.Clear();
                foreach (string f in Directory.GetFiles(FolderName,"*.bmp", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(f));
                }
                foreach (string f in Directory.GetFiles(FolderName, "*.jpg", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(f));
                }
                foreach (string f in Directory.GetFiles(FolderName, "*.png", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(f));
                }
            }


        }
        private void ClosingFrm(Form F)
        {
            F.Hide();
            F.MdiParent = null;
            CalculateWinCount();
        }
        private void CalculateWinCount()
        {
            int WinCount = this.MdiChildren.Count();
            this.StatusWindowsCount.Text = "Открыто окно: " + Convert.ToString(WinCount);
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string FileName = listBox1.SelectedItem.ToString();
            ChildForm Frm = new ChildForm();
            Frm.MdiParent = this;
            Frm.Width = (int)(this.Width * 0.6);
            Frm.Height = (int)(this.Height * 0.6);
            Frm.Text = "Изображение: " + FileName;
            Frm.LoadPicture(FolderName + "\\" + FileName);

            Frm.FormClosed += (obj,args) => ClosingFrm(Frm);

            Frm.Show();
            CalculateWinCount();


        }
        private void MenuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void MenuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void MenuHorizontal_Click(object sender,EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void MenuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void MenuAboutAuthor_Click(object sender, EventArgs e)
        {
            AboutAuthor AA = new AboutAuthor();
            AA.ShowDialog();
        }
        private void MenuAboutProgram_Click(object sender, EventArgs e)
        {
            string Path = "Отчет Бугаков.docx";
            if (System.IO.File.Exists(Path))
                Process.Start(Path);
            else
                MessageBox.Show("Файл Отчет_Бугакова.docx в папке с программой не найден", "Ошибка открытия файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MenuQuantityOfFiles_Click(object sender, EventArgs e)
        {
            QuantityOfFiles AA = new QuantityOfFiles();
            AA.ShowDialog();
        }

    }
}