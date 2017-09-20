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

        int tamanhoPalavraAtual = 0, tamanhoPalavraAnterior;
        int locx = 250, locy = 160;
        TextBox[] txtCampos;


        public Form1()
        {
            InitializeComponent();
            


            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tamanhoPalavraAnterior = tamanhoPalavraAtual;
            tamanhoPalavraAtual = 0;

            for (int i = 0; i < tamanhoPalavraAnterior; i++)
            {
                this.Controls.Remove(txtCampos[i]);
            }
            locx = 250;

            NovaPalavra palavraUsuario = new NovaPalavra();
            palavraUsuario.ShowDialog();
            palavra = palavraUsuario.novoTexto;
            palavra = palavra.ToLower();
            
            tamanhoPalavraAtual = palavra.Length;
            gerarCampos(tamanhoPalavraAtual);
        }

        public void gerarCampos(int tamanhoPalavraAtual)
        {
            txtCampos = new TextBox[tamanhoPalavraAtual];

            for (int i = 0; i < tamanhoPalavraAtual; i++)
            {
                txtCampos[i] = new TextBox();
                txtCampos[i].Size = new Size(33, 10);
                txtCampos[i].Location = new Point(locx, locy);
                txtCampos[i].Name = "txtCampos" + i;
                this.Controls.Add(txtCampos[i]);
                locx += 40;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tamanhoPalavraAnterior = tamanhoPalavraAtual;
            tamanhoPalavraAtual = 0;

            for (int i = 0; i < tamanhoPalavraAnterior; i++)
            {
                this.Controls.Remove(txtCampos[i]);
            }
            locx = 250;

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
            tamanhoPalavraAtual = palavra.Length;
            gerarCampos(tamanhoPalavraAtual);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Visible = false;
            compararCampos("a");
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Visible = false;
            compararCampos("b");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Visible = false;
            compararCampos("c");
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Visible = false;
            compararCampos("d");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Visible = false;
            compararCampos("e");
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Visible = false;
            compararCampos("f");
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Visible = false;
            compararCampos("g");
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Visible = false;
            compararCampos("h");
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Visible = false;
            compararCampos("i");
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Visible = false;
            compararCampos("j");
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Visible = false;
            compararCampos("k");
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Visible = false;
            compararCampos("l");
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Visible = false;
            compararCampos("m");
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Visible = false;
            compararCampos("n");
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Visible = false;
            compararCampos("o");
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Visible = false;
            compararCampos("p");
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Visible = false;
            compararCampos("q");
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Visible = false;
            compararCampos("r");
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Visible = false;
            compararCampos("s");
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Visible = false;
            compararCampos("t");
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Visible = false;
            compararCampos("u");
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Visible = false;
            compararCampos("v");
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Visible = false;
            compararCampos("w");
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Visible = false;
            compararCampos("x");
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Visible = false;
            compararCampos("y");
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Visible = false;
            compararCampos("z");
        }

        public void compararCampos(string letra)
        {
            bool erro = true;

            for(int i=0;i<tamanhoPalavraAtual;i++)
            {
                if(palavra.Substring(i, 1) == letra)
                {
                    txtCampos[i].Text = letra;
                    erro = false;

                    int qtTexto = 0;

                    for(int j = 0; j < tamanhoPalavraAtual; j++)
                    {
                        if (txtCampos[j].Text != "")
                            qtTexto++;

                    }

                    if(qtTexto == tamanhoPalavraAtual)
                    {
                        MessageBox.Show("Você ganhou!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                        
                }
            }

            if (erro)
            {
                erros++;
            }

            erro = true;

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

            if (erros == 3)
            {
                corpo.Visible = false;
                bracoEsquedo.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if (erros == 4)
            {
                bracoEsquedo.Visible = false;
                bracos.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if (erros == 5)
            {
                bracos.Visible = false;
                perna.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if (erros == 6)
            {
                perna.Visible = false;
                corpoInteiro.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if (erros == 7)
            {
                corpoInteiro.Visible = false;
                morto.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);

                MessageBox.Show("Você perdeu! A palavra era: " + palavra,"Ah que pena" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }
    }
}

    