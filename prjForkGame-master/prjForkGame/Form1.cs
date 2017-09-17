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
        int tamanhoPalavra;
        int locx = 187, locy = 160;
        TextBox[] txtCampos;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaPalavra palavraUsuario = new NovaPalavra();
            palavraUsuario.ShowDialog();
            palavra = palavraUsuario.novoTexto;
            tamanhoPalavra = palavra.Length;
            txtCampos = new TextBox[tamanhoPalavra];

            for(int i = 0; i < tamanhoPalavra; i++)
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
            tamanhoPalavra = palavra.Length;
            txtCampos = new TextBox[tamanhoPalavra];

            for (int i = 0; i < tamanhoPalavra; i++)
            {
                txtCampos[i] = new TextBox();
                txtCampos[i].Size = new Size(33, 10);
                txtCampos[i].Location = new Point(locx, locy);
                txtCampos[i].Name = "txtCampos" + i;
                this.Controls.Add(txtCampos[i]);
                locx += 40;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
