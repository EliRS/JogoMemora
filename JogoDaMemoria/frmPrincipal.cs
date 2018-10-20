using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class frmPrincipal : Form
    {

        PictureBox ptbP1, ptbP2;
        int i = 0, cont = 0, verify = 0;
        Random x = new Random();
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            embaralhar();
            ptb1.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[0].ToString() + ".jpg");
            ptb2.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[0].ToString() + ".jpg");
            ptb3.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[1].ToString() + ".jpg");
            ptb4.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[1].ToString() + ".jpg");
            ptb5.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[2].ToString() + ".jpg");
            ptb6.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[2].ToString() + ".jpg");
            ptb7.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[3].ToString() + ".jpg");
            ptb8.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[3].ToString() + ".jpg");
            ptb9.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[4].ToString() + ".jpg");
            ptb10.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[4].ToString() + ".jpg");
            ptb11.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[5].ToString() + ".jpg");
            ptb12.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[5].ToString() + ".jpg");
            ptb13.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[6].ToString() + ".jpg");
            ptb14.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[6].ToString() + ".jpg");
            ptb15.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[7].ToString() + ".jpg");
            ptb16.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[7].ToString() + ".jpg");
            ptb17.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[8].ToString() + ".jpg");
            ptb18.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[8].ToString() + ".jpg");
            ptb19.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor1[9].ToString() + ".jpg");
            ptb20.BackgroundImage = Image.FromFile(@"C:\img\img" + vetor2[9].ToString() + ".jpg");
            timer1.Start();
            timer1.Interval = 4000;
            verify = 0;

        }
        private void ptb1_Click_1(object sender, EventArgs e)
        {
            ptbP1 = (PictureBox)sender;
            ptbP2 = (PictureBox)sender;
            if (verify == 0)
            {
                ptbP1.BackgroundImage = Image.FromFile(@"C:\img\img" + ptbP1.Tag + ".jpg");
                verify = 1;
            }
            else
            {
                ptbP2.BackgroundImage = Image.FromFile(@"C:\img\img" + ptbP2.Tag + ".jpg");
                timer2.Start();
                timer2.Interval = 500;
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Jogo da Memoria";
            ptb1.Enabled = false;
            ptb2.Enabled = false;
            ptb3.Enabled = false;
            ptb4.Enabled = false;
            ptb5.Enabled = false;
            ptb6.Enabled = false;
            ptb7.Enabled = false;
            ptb8.Enabled = false;
            ptb9.Enabled = false;
            ptb10.Enabled = false;
            ptb11.Enabled = false;
            ptb12.Enabled = false;
            ptb13.Enabled = false;
            ptb14.Enabled = false;
            ptb15.Enabled = false;
            ptb16.Enabled = false;
            ptb17.Enabled = false;
            ptb18.Enabled = false;
            ptb19.Enabled = false;
            ptb20.Enabled = false;
        }
        public void embaralhar()
        {
            for (int a = 0; a < 10; a++) { vetor1[a] = 0; vetor2[a] = 0; }
            cont = 0;
            for (int z = 0; z < 1000; z++)
            //while (vetor1[9] == 0)
            {
                i = x.Next(1, 11);

                if (cont < 10 && i != vetor1[0] && i != vetor1[1] && i != vetor1[2] && i != vetor1[3] && i != vetor1[4] && i != vetor1[5] && i != vetor1[6] && i != vetor1[7] && i != vetor1[8] && i != vetor1[9])
                {
                    vetor1[cont] = i;
                    cont++;
                }
            }

            cont = 0;
            for (int y = 0; y < 1000; y++)
            //while (vetor2[9] == 0)
            {
                i = x.Next(1, 11);

                if (cont < 10 && i != vetor2[0] && i != vetor2[1] && i != vetor2[2] && i != vetor2[3] && i != vetor2[4] && i != vetor2[5] && i != vetor2[6] && i != vetor2[7] && i != vetor2[8] && i != vetor2[9])
                {
                    vetor2[cont] = i;
                    cont++;
                }
            }
            ptb1.Tag = vetor1[0].ToString();
            ptb2.Tag = vetor1[1].ToString();
            ptb3.Tag = vetor1[2].ToString();
            ptb4.Tag = vetor1[3].ToString();
            ptb5.Tag = vetor1[4].ToString();
            ptb6.Tag = vetor1[5].ToString();
            ptb7.Tag = vetor1[6].ToString();
            ptb8.Tag = vetor1[7].ToString();
            ptb9.Tag = vetor1[8].ToString();
            ptb10.Tag = vetor1[9].ToString();
            ptb11.Tag = vetor2[0].ToString();
            ptb12.Tag = vetor2[1].ToString();
            ptb13.Tag = vetor2[2].ToString();
            ptb14.Tag = vetor2[3].ToString();
            ptb15.Tag = vetor2[4].ToString();
            ptb16.Tag = vetor2[5].ToString();
            ptb17.Tag = vetor2[6].ToString();
            ptb18.Tag = vetor2[7].ToString();
            ptb19.Tag = vetor2[8].ToString();
            ptb20.Tag = vetor2[9].ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ptbP1.Tag.Equals(ptbP2.Tag))
            {
                ptbP2.Enabled = false;
                ptbP2.Enabled = false;
                verify = 0;
                timer2.Stop();
            }
            else
            {
                ptbP2.BackgroundImage = Properties.Resources.botao;
                ptbP1.BackgroundImage = Properties.Resources.botao;
                verify = 0;
                timer2.Stop();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ptb1.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb2.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb3.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb4.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb5.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb6.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb7.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb8.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb9.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb10.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb11.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb12.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb13.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb14.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb15.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb16.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb17.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb18.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb19.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb20.BackgroundImage = Image.FromFile(@"C:\img\botao.png");
            ptb1.Enabled = true;
            ptb2.Enabled = true;
            ptb3.Enabled = true;
            ptb4.Enabled = true;
            ptb5.Enabled = true;
            ptb6.Enabled = true;
            ptb7.Enabled = true;
            ptb8.Enabled = true;
            ptb9.Enabled = true;
            ptb10.Enabled = true;
            ptb11.Enabled = true;
            ptb12.Enabled = true;
            ptb13.Enabled = true;
            ptb14.Enabled = true;
            ptb15.Enabled = true;
            ptb16.Enabled = true;
            ptb17.Enabled = true;
            ptb18.Enabled = true;
            ptb19.Enabled = true;
            ptb20.Enabled = true;
        }
    }
}
