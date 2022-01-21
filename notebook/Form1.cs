using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çalışmanız Kaybolacak Emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==System.Windows.Forms.DialogResult.Yes)
            {
                textBox1.Text = "";
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Metin Dosyası Aç";
            opf.Filter="Desteklenen Formatlar(*.log,*.txt)|*.txt;*.log";

            if(opf.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(opf.FileName, Encoding.Default);
                this.Text = "Açılan:" + opf.FileName;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog spf = new SaveFileDialog();
            spf.Title = "Metin Dosyası Kaydet";
            spf.Filter = "Desteklenen Formatlar(*.log,*.txt|*.txt,*.log";

            if (spf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               File.WriteAllText(spf.FileName, textBox1.Text,Encoding.Default);
                this.Text = "Açılan:" + spf.FileName;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = textBox1.SelectedText;
            if(!string.IsNullOrEmpty(a))
            {
                Clipboard.SetText(a);
            }
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = textBox1.SelectedText;
            if (!string.IsNullOrEmpty(a))
            {
                textBox1.SelectedText= Clipboard.GetText();
            }
            else
            {
                textBox1.SelectedText= Clipboard.GetText();
            }

        }

        private void özelleştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Opacity==0.70f)
            {
                this.Opacity = 1;
            }
            else
            {
                this.Opacity = 0.70f;
            }
        }

      

        private void yazıfontdeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Font= fd.Font;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = textBox1.SelectedText;
            if (!string.IsNullOrEmpty(a))
            {
                Clipboard.SetText(a);
            }
            textBox1.SelectedText = "";

        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string a = textBox1.SelectedText;
            if (!string.IsNullOrEmpty(a))
            {
                Clipboard.SetText(a);
            }
            textBox1.SelectedText = "";
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string a = textBox1.SelectedText;
            if (!string.IsNullOrEmpty(a))
            {
                Clipboard.SetText(a);
            }
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string a = textBox1.SelectedText;
            if (!string.IsNullOrEmpty(a))
            {
                textBox1.SelectedText = Clipboard.GetText();
            }
            else
            {
                textBox1.SelectedText = Clipboard.GetText();
            }

        }
    }
}
