using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _130606Win_FormMilliPiyango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled==false)
            {
                timer1.Enabled=true;
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bilet Alımını Durdurunuz");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rast = new Random();
            btn.Text = rast.Next(0,10).ToString();

            button2.Text = rast.Next(0, 10).ToString();

            button3.Text = rast.Next(0, 10).ToString();

            button4.Text = rast.Next(0, 10).ToString();

            button5.Text = rast.Next(0, 10).ToString();

            button6.Text = rast.Next(0, 10).ToString();

        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled=false;

            if (btn.Text=="" || button2.Text=="" || button3.Text=="" || button4.Text=="" || button5.Text=="" || button6.Text=="")
            {
                isik1.BackColor = isik2.BackColor = isik3.BackColor = isik4.BackColor = isik5.BackColor = isik6.BackColor = Color.WhiteSmoke;
            }
            else
            {
                isik1.BackColor = (lbl1.Text == btn.Text) ? Color.Green : Color.Red;
                isik2.BackColor = (lbl2.Text == button2.Text) ? Color.Green : Color.Red;
                isik3.BackColor = (lbl3.Text == button3.Text) ? Color.Green : Color.Red;
                isik4.BackColor = (lbl4.Text == button4.Text) ? Color.Green : Color.Red;
                isik5.BackColor = (lbl5.Text == button5.Text) ? Color.Green : Color.Red;
                isik6.BackColor = (lbl6.Text == button6.Text) ? Color.Green : Color.Red; 
            }
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Önce Çekilişi Durdurunuz");
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rast = new Random();

            lbl1.Text = rast.Next(0, 10).ToString();
            lbl2.Text = rast.Next(0, 10).ToString();
            lbl3.Text = rast.Next(0, 10).ToString();
            lbl4.Text = rast.Next(0, 10).ToString();
            lbl5.Text = rast.Next(0, 10).ToString();
            lbl6.Text = rast.Next(0, 10).ToString();
        }

        private void yeniÇekilişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = "";
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = lbl5.Text = lbl6.Text = "_";
            isik1.BackColor = isik2.BackColor = isik3.BackColor = isik4.BackColor = isik5.BackColor = isik6.BackColor = Color.WhiteSmoke;
        }
       
    }
}
