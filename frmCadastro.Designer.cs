
namespace cadastro
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNome.Location = new System.Drawing.Point(61, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.Orange;
            this.lblIdade.Location = new System.Drawing.Point(65, 94);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(57, 21);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.Orange;
            this.lblCpf.Location = new System.Drawing.Point(336, 94);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 21);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(128, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(746, 24);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(128, 91);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(204, 24);
            this.txtIdade.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(384, 91);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(490, 24);
            this.txtCpf.TabIndex = 3;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.Color.Orange;
            this.lblRg.Location = new System.Drawing.Point(87, 140);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(35, 21);
            this.lblRg.TabIndex = 0;
            this.lblRg.Text = "RG:";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(128, 137);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(204, 24);
            this.txtRg.TabIndex = 4;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Orange;
            this.lblCelular.Location = new System.Drawing.Point(336, 137);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(68, 21);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(410, 134);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(464, 24);
            this.txtCelular.TabIndex = 5;
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.txtRegistro);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbRegistro.Location = new System.Drawing.Point(31, 195);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(883, 312);
            this.gbRegistro.TabIndex = 8;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRegistro.Location = new System.Drawing.Point(23, 33);
            this.txtRegistro.Multiline = true;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(841, 264);
            this.txtRegistro.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(384, 12);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(488, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(942, 525);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vacinação";
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

