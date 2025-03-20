namespace MultApps.Windows
{
    partial class AppDeCarteirinha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDataDeNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblCarteirinha = new System.Windows.Forms.PictureBox();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.btnGerarCarteirinha = new System.Windows.Forms.Button();
            this.lblResultadoCPF = new System.Windows.Forms.Label();
            this.lblResultadoIdade = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCarteirinha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERADOR DE CARTEIRINHA DE ACESSO AO PARQUE";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(73, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(61, 217);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // txtDataDeNascimento
            // 
            this.txtDataDeNascimento.Location = new System.Drawing.Point(61, 307);
            this.txtDataDeNascimento.Name = "txtDataDeNascimento";
            this.txtDataDeNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataDeNascimento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de nascimento";
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblCarteirinha);
            this.panelResultado.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panelResultado.Location = new System.Drawing.Point(485, 76);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(254, 284);
            this.panelResultado.TabIndex = 7;
            // 
            // lblCarteirinha
            // 
            this.lblCarteirinha.Location = new System.Drawing.Point(16, 15);
            this.lblCarteirinha.Name = "lblCarteirinha";
            this.lblCarteirinha.Size = new System.Drawing.Size(224, 248);
            this.lblCarteirinha.TabIndex = 1;
            this.lblCarteirinha.TabStop = false;
            this.lblCarteirinha.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.Location = new System.Drawing.Point(267, 108);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(100, 23);
            this.lblResultadoNome.TabIndex = 0;
            this.lblResultadoNome.Text = "resultado";
            this.lblResultadoNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGerarCarteirinha
            // 
            this.btnGerarCarteirinha.Location = new System.Drawing.Point(257, 359);
            this.btnGerarCarteirinha.Name = "btnGerarCarteirinha";
            this.btnGerarCarteirinha.Size = new System.Drawing.Size(75, 23);
            this.btnGerarCarteirinha.TabIndex = 8;
            this.btnGerarCarteirinha.Text = "Gerar";
            this.btnGerarCarteirinha.UseVisualStyleBackColor = true;
            // 
            // lblResultadoCPF
            // 
            this.lblResultadoCPF.AutoSize = true;
            this.lblResultadoCPF.Location = new System.Drawing.Point(501, 384);
            this.lblResultadoCPF.Name = "lblResultadoCPF";
            this.lblResultadoCPF.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoCPF.TabIndex = 9;
            this.lblResultadoCPF.Text = "label2";
            // 
            // lblResultadoIdade
            // 
            this.lblResultadoIdade.AutoSize = true;
            this.lblResultadoIdade.Location = new System.Drawing.Point(498, 440);
            this.lblResultadoIdade.Name = "lblResultadoIdade";
            this.lblResultadoIdade.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoIdade.TabIndex = 10;
            this.lblResultadoIdade.Text = "label2";
            this.lblResultadoIdade.Click += new System.EventHandler(this.lblResultadoIdade_Click);
            // 
            // AppDeCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.lblResultadoIdade);
            this.Controls.Add(this.lblResultadoCPF);
            this.Controls.Add(this.btnGerarCarteirinha);
            this.Controls.Add(this.lblResultadoNome);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataDeNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "AppDeCarteirinha";
            this.Text = "AppDeCarteirinhas";
            this.panelResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblCarteirinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDataDeNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Button btnGerarCarteirinha;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.PictureBox lblCarteirinha;
        private System.Windows.Forms.Label lblResultadoCPF;
        private System.Windows.Forms.Label lblResultadoIdade;
    }
}