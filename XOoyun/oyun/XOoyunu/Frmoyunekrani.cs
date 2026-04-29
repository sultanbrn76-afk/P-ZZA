using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOoyunu
{
    public partial class Frmoyunekrani : Form
    {
        public Frmoyunekrani()
        {
            InitializeComponent();
        }

        private void Frmoyunekrani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                var cevap =MessageBox.Show(
                    "Oyundan çıkmak istediğinize emin misiniz?",
                    "uyarı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if(cevap==DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        bool birincioyuncuMu = true;
        
        private void Generic_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text != string.Empty) 
            {
                return;
            }

                if (birincioyuncuMu == true)
            { 
                button.Font =new Font("consolas", 48, FontStyle.Bold);
                button.ForeColor = Color.Black;
                button.BackColor = Color.Red;
                button.Text = "X";
            }
            else
            {
                button.Font = new Font("consolas", 48, FontStyle.Bold);
                button.ForeColor = Color.Red;
                button.BackColor = Color.Black;
                button.Text = "O";
            }
            kazananikontrolet();
  
        }

        private void kazananikontrolet()
        {
            if (
                (btn1_1.Text == btn1_2.Text &&
                 btn1_2.Text == btn1_3.Text &&
                 btn1_1.Text != string.Empty) ||

                 (btn2_1.Text == btn2_2.Text &&
                 btn2_2.Text == btn2_3.Text &&
                 btn2_1.Text != string.Empty) ||

                 (btn3_1.Text == btn3_2.Text &&
                 btn3_2.Text == string.Empty &&
                 btn3_1.Text != string.Empty) ||

                 (btn1_1.Text == btn2_1.Text &&
                 btn2_1.Text == btn3_1.Text &&
                 btn1_1.Text != string.Empty) ||


                 (btn1_1.Text == btn2_2.Text &&
                 btn2_2.Text == btn3_2.Text &&
                 btn1_2.Text != string.Empty) ||

                 (btn1_3.Text == btn2_3.Text &&
                 btn2_3.Text == btn3_3.Text &&
                 btn1_3.Text != string.Empty) ||

                 (btn1_1.Text == btn2_2.Text &&
                 btn2_2.Text == btn3_3.Text &&
                 btn1_1.Text != string.Empty) ||

                 (btn1_3.Text == btn2_2.Text &&
                 btn2_2.Text == btn3_1.Text &&
                 btn1_3.Text != string.Empty)
                 )

            {
                oyunbittimi();
            }
            else if (beraberlikmi())
            {
                var cevap=MessageBox.Show("tekrar oynayalım mı?",
                    "berabere kaldınız",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information );
                if (cevap == DialogResult.Yes)
                {
                    resetle();
                }
                else
                {
                    this.Close();
                }
            }

            else
            {
                birincioyuncuMu = !birincioyuncuMu;
            }
        }

        private bool beraberlikmi()
        {
            //ekrandaki butonların hepsinin text property
            //dolu olup olmadığı kontrolü
            return tlp_oyunalani.Controls.OfType<Button>().All(btn => btn.Text != string.Empty);
            //linq nedir? kullanım örenekleri.
            //lambda operatörü nedir? örnek kullanımı.
        }
        
        private void oyunbittimi()
        {
            var kazanmak = "kazanan oyuncu" + (birincioyuncuMu ? "1.oyuncu" : "2.oyuncu");
            var cevap= MessageBox.Show(
                kazanmak, "oynayalım mı?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (cevap == DialogResult.Yes)
            {
                resetle();

            }
            else
            {
                this.Close();
            }
        }

        private void resetle()
        {
            foreach (var item in tlp_oyunalani.Controls)
            {
                if (item is Button)
                {
                    Button button = item as Button;
                    button.Text = string.Empty;
                    button.ForeColor = System.Drawing.SystemColors.ControlText;
                    button.BackColor = System.Drawing.SystemColors.Control;

                }
            }
            birincioyuncuMu = true;
        }
    }
}
