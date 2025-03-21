using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class AppDeCarteirinha : Form
    {
        public AppDeCarteirinha()
        {
            InitializeComponent();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblResultadoNome.Text = txtNome.Text;
 
            var datanascimento = DateTime.Parse(txtDataDeNascimento.Text);
            var dataanual = DateTime.Now.Year;
            var idade = dataanual;

            lblResultadoIdade.Text = txtDataDeNascimento.Text;

            var texoriginal = txtCPF.Text;
            var texoculto = OcultarTexto(texoriginal);
            lblResultadoCPF.Text = texoculto;
            if (idade < 12)
            {
                lblCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/3886/3886660.png");

                lblCarteirinha.Text = "Carteirinha azul";
                lblCarteirinha.ForeColor = Color.Blue;

            }
            else if (idade < 18)
            {
                lblCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/3886/3886660.png");

                lblCarteirinha.Text = "Carteirinha amarela";
                lblCarteirinha.ForeColor = Color.Yellow;

            }
            else if (idade < 60)
            {
                lblCarteirinha.Load("https://img.lovepik.com/png/20231123/man-and-woman-with-face-icons-vector-behance-hd-ui_674344_wh860.png");

                lblCarteirinha.Text = "Carteirinha roxa";
                lblCarteirinha.ForeColor = Color.Purple;

            }
            else
            {
                lblCarteirinha.Load("https://cdn-icons-png.freepik.com/512/1761/1761366.png");

                lblCarteirinha.Text = "Carteirinha verde";
                lblCarteirinha.ForeColor = Color.Green;

            }

        }
        static string OcultarTexto(string texto)
        {
            string partevisivel = texto.Substring(6, 3);

            return texto.Substring(0, 3) + ".*.*" + partevisivel;
        }

        private void lblResultadoIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            lblResultadoNome.Text = txtNome.Text;

            var datanascimento = DateTime.Parse(txtDataDeNascimento.Text);
            var dataanual = DateTime.Now.Year;
            var idade = dataanual;

            lblResultadoIdade.Text = txtDataDeNascimento.Text;

            var texoriginal = txtCPF.Text;
            var texoculto = OcultarTexto(texoriginal);
            lblResultadoCPF.Text = texoculto;
            if (idade < 12)
            {
                lblCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/3886/3886660.png");

                lblCarteirinha.Text = "Carteirinha azul";
                lblCarteirinha.ForeColor = Color.Blue;

            }
            else if (idade > 18)
            {
                lblCarteirinha.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-bKJNl_OFNzdauLW4B_81W_Vv9EUwnwBxOA&s");

                lblCarteirinha.Text = "Carteirinha amarela";
                lblCarteirinha.ForeColor = Color.Yellow;

            }
            else if (idade > 60)
            {
                lblCarteirinha.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-bKJNl_OFNzdauLW4B_81W_Vv9EUwnwBxOA&s");

                lblCarteirinha.Text = "Carteirinha roxa";
                lblCarteirinha.ForeColor = Color.Purple;


            }
            else
            {
                lblCarteirinha.Load("https://cdn-icons-png.freepik.com/512/1761/1761366.png");

                lblCarteirinha.Text = "Carteirinha verde";
                lblCarteirinha.ForeColor = Color.Green;

            }
        }
    }
}

