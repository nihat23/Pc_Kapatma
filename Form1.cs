using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Kapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2Yeniden_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Bilgisayarı Yeniden Başlatmak istediginizden eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-r -f");
            }
        }

        private void button1Kapat_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Bilgisayarı Kapatmak istediginizden eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s");
            }
        }

        private void button3Kullanici_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Kullanıcı Adı degiştirmesine eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-l");
            }
        }

        private void button4Uyku_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Uyku moduna geçiyor..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-h");
            }
        }

        private void button1Kapat_MouseHover(object sender, EventArgs e)
        {
            button1Kapat.BackColor = Color.Red;
        }

        private void button1Kapat_MouseLeave(object sender, EventArgs e)
        {
            button1Kapat.BackColor = Color.White;
        }

        private void button2Yeniden_MouseHover(object sender, EventArgs e)
        {
            button2Yeniden.BackColor = Color.Red;
        }

        private void button2Yeniden_MouseLeave(object sender, EventArgs e)
        {
            button2Yeniden.BackColor = Color.White;
        }

        private void button3Kullanici_MouseHover(object sender, EventArgs e)
        {
            button3Kullanici.BackColor = Color.Red;
        }

        private void button3Kullanici_MouseLeave(object sender, EventArgs e)
        {
            button3Kullanici.BackColor = Color.White;
        }

        private void button4Uyku_MouseHover(object sender, EventArgs e)
        {
            button4Uyku.BackColor = Color.Red;
        }

        private void button4Uyku_MouseLeave(object sender, EventArgs e)
        {
            button4Uyku.BackColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
    }
}
