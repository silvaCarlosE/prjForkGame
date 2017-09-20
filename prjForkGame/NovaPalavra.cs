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
    public partial class NovaPalavra : Form
    {
        public string novoTexto
        {
            get { return textBox1.Text; }
        }

        public NovaPalavra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isString = false;
            String palavra;
            palavra = textBox1.Text;
            isString = verificaLetras(palavra);
            if (isString)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Palavra incorreta");
                textBox1.Clear();
                textBox1.Focus();
            }
            
        }

        public bool verificaLetras(String palavra)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                //if (palavra.Substring(i, 1) == char.IsSymbol())
                //{

                //}
            }
            return true;
        }


    }
}
