using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEscolar
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //criando as variáveis;
            decimal nota1 = decimal.Parse(txtN1.Text);
            decimal nota2 = decimal.Parse(txtN2.Text), nota3 = decimal.Parse(txtN3.Text);
            decimal nota4 = decimal.Parse(txtN4.Text);
            /*Fazer validação dos númros 
            Para tomar uma decisão, usamos o comando if(se)
            == (igual a), != (diferente de), > (maior que), < (menor que), >= (maior ou igual a), <= (menor ou igual a)
            || (ou), && (e)
            */
            if (nota1 > 10 || nota1 < 0) {
                //Focus é só para colocar o cursor na caixinha  que está com erro;
                txtN1.Focus();
                //Mostrar mensagem ao usuário;
                MessageBox.Show("Nota 1 inválida, digite um valor entre 0 e 10", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Finalizar código, quando aparece o return o código é finalizado;
                return;



            }

            /* o C# é case sensitive, faz difereciação entre maiúsculas e minúsculas;
            Parse = transformar , neste caso em decimal;
            Calculo de média;
            */
            

            decimal media1, media2,  mediaFinal ;
            media1 = (((nota1 * 4) + (nota2 * 6)) / 10);
            media2 = (((nota3 * 4) + (nota4 * 6)) / 10);
            mediaFinal = (media1 + media2) / 2;
            //mostrar as médias;
            //.ToString() = Transformar em texto, isto é um método/função;
            //como saber se é um método, icone do cubo roxo;
            txtBim1.Text = media1.ToString();
            txtBim2.Text = media2.ToString();
            txtMediaFinal.Text = mediaFinal.ToString();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
