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
        private int erros=1;
        

        public Form1()
        {
            InitializeComponent();
            


            if (erros == 1)
            {
                forca.Visible = false;
                cabeça.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);

            }
            if(erros == 2)
            {
                cabeça.Visible = false;
                bracoEsquedo.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros == 3)
            {
                bracoEsquedo.Visible = false;
                bracos.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros == 4)
            {
                bracos.Visible = false;
                perna.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros == 5)
            {
                perna.Visible = false;
                corpoInteiro.Visible = true;

                errosNumero.Items.Clear();
                errosNumero.Items.Add("" + erros);
            }
            if(erros ==6)
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

       

       
    }
}
