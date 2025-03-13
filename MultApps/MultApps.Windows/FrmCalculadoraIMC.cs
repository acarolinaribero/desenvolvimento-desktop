using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            cbmIdade.Visible = true;
            lblIdade.Visible = true;
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cbmIdade.Visible = false;
            lblIdade.Visible = false;
        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
        }  


        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkMasculino.Checked = false;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (chkAdulto.Checked && chkMasculino.Checked)
            {
                #region Adulto Masculino

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textobase = $@"Meu IMC: {imc:N2} é:";


                lblResultadoImc.Text = imc.ToString("N2");

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é abaixo do normal";
                    picBoxImc.Load(ImcImagem.MasculinoAbaixoDoPesoNormal);

                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é normal";
                    picBoxImc.Load(ImcImagem.MasculinoPesoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é sobrepeso";
                    picBoxImc.Load(ImcImagem.MasculinoSobrepeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é obesidade grau 1";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau1);

                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é obesidade grau 2";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau2);

                }
                else
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é obesidade grau 3";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau3);

                }

               
                #endregion
  

            }

            if (chkAdulto.Checked && chkFeminino.Checked)
            {
                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textobase = $@"Meu IMC: {imc:N2} é:";


                lblResultadoImc.Text = imc.ToString("N2");

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é abaixo do normal";
                    picBoxImc.Load(ImcImagem.FemininoAbaixoDoPesoNormal);

                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é normal";
                    picBoxImc.Load(ImcImagem.FemininoPesoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é sobrepeso";
                    picBoxImc.Load(ImcImagem.FemininoSobrepeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é obesidade grau 1";
                    picBoxImc.Load(ImcImagem.FemininoObesidadeGrau1);

                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é obesidade grau 2";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau2);

                }
                else
                {
                    lblResultadoImc.Text = $@"Seu IMC: {imc:N2} é obesidade grau 3";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau3);

                }
            }
        }
     
    }
}

