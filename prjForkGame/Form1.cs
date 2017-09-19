using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjForkGame
{
    public partial class Form1 : Form
    {
        private string palavra;
        private int erros=0;
        

        public Form1()
        {
            InitializeComponent();
            


            if (erros == 1)
            {
                forca.Visible = false;
                cabeca.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);

            }

            if (erros == 2)
            {
                cabeca.Visible = false;
                corpo.Visible = true;
                
                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }

            if(erros == 3)
            {
                corpo.Visible = false;
                bracoEsquedo.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros == 4)
            {
                bracoEsquedo.Visible = false;
                bracos.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros == 5)
            {
                bracos.Visible = false;
                perna.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros == 6)
            {
                perna.Visible = false;
                corpoInteiro.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros ==7)
            {
                corpoInteiro.Visible = false;
                morto.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaPalavra palavraUsuario = new NovaPalavra();
            palavraUsuario.ShowDialog();
            palavra = palavraUsuario.novoTexto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] randomWord = new String[10];
            randomWord[0] = "argila";
            randomWord[1] = "veneno";
            randomWord[2] = "problema";
            randomWord[3] = "algarismo";
            randomWord[4] = "estrutura";
            randomWord[5] = "pneu";
            randomWord[6] = "porta";
            randomWord[7] = "cofre";
            randomWord[8] = "cinto";
            randomWord[9] = "eucalipto";

            Random numeroAleatorio = new Random();
            int posicao = numeroAleatorio.Next(0, randomWord.Length);
            palavra = randomWord[posicao];
            MessageBox.Show(palavra);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Visible = false;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Visible = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Visible = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Visible = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Visible = false;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Visible = false;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Visible = false;
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Visible = false;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Visible = false;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Visible = false;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Visible = false;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Visible = false;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Visible = false;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Visible = false;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Visible = false;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Visible = false;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Visible = false;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Visible = false;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Visible = false;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Visible = false;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Visible = false;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Visible = false;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Visible = false;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Visible = false;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Visible = false;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Visible = false;
        }
    
    }
}
