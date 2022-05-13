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
    public partial class QuantityOfFiles : Form
    {
        public QuantityOfFiles()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public string FolderName { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
            FolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            double bmppic = 0;
            double jpgic = 0;
            double pngpic = 0;
            double allpisc = 0;
            if (FolderDialog.ShowDialog(this) == DialogResult.OK)
            {
                FolderName = FolderDialog.SelectedPath;
                listBox1.Items.Clear();
                foreach (string f in Directory.GetFiles(FolderName, "*.bmp", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Count.Equals(f);
                    bmppic++;
                    allpisc++;
                }
                foreach (string f in Directory.GetFiles(FolderName, "*.jpg", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Count.Equals(f);
                    jpgic++;
                    allpisc++;
                }
                foreach (string f in Directory.GetFiles(FolderName, "*.png", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Count.Equals(f);
                    pngpic++;
                    allpisc++;
                }
            }
            listBox1.Items.Add("Количество файлов с расширением bmp - " + bmppic);
            listBox1.Items.Add("Количество файлов с расширением jpg - " + jpgic);
            listBox1.Items.Add("Количество файлов с расширением png - " + pngpic);
            listBox1.Items.Add("Общее количество файлов - " + allpisc);
        }
            
    }
}


