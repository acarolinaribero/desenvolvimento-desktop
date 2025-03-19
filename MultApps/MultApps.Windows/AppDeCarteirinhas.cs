using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MultApps.Windows
{
    public partial class AppDeCarteirinha : Form
    {
        public AppDeCarteirinha()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtDataNascimento.Text);
            string cpf = txtCpf.Text;

            string carteirinha = CriarCarteirinha(nome, idade, cpf);

            lblResultado.Text = carteirinha;

            if (idade <= 12)
                panelResultado.BackColor = Color.Blue;


            else if (idade >= 60)
                panelResultado.BackColor = Color.Green;


            else if (idade >= 13 && idade <= 25)
                panelResultado.BackColor = Color.Yellow;


            else
                panelResultado.BackColor = Color.Purple;


        }

        private string CriarCarteirinha(string nome, int idade, string cpf)
        {
            string cpfOfuscado = OfuscarCpf(cpf);

            return $"Nome: {nome}\nIdade: {idade}\nCPF: {cpfOfuscado}";
        }

        private string OfuscarCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                return $"***.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-**";
            }
            else
            {
                return "CPF inválido.";
            }
        }
    }
}
