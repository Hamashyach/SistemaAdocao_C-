namespace MIAUDOTE
{
    partial class Perfil
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSenhaAtual = new System.Windows.Forms.Label();
            this.textBoxSenhaAtual = new System.Windows.Forms.TextBox();
            this.labelNovaSenha = new System.Windows.Forms.Label();
            this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.labelConfirmarNovaSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmarNovaSenha = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNome.Location = new System.Drawing.Point(73, 50);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(61, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(287, 50);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEmail.Location = new System.Drawing.Point(73, 88);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(287, 90);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelSenhaAtual
            // 
            this.labelSenhaAtual.AutoSize = true;
            this.labelSenhaAtual.BackColor = System.Drawing.Color.Transparent;
            this.labelSenhaAtual.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSenhaAtual.Location = new System.Drawing.Point(73, 130);
            this.labelSenhaAtual.Name = "labelSenhaAtual";
            this.labelSenhaAtual.Size = new System.Drawing.Size(118, 20);
            this.labelSenhaAtual.TabIndex = 4;
            this.labelSenhaAtual.Text = "Senha Atual:";
            // 
            // textBoxSenhaAtual
            // 
            this.textBoxSenhaAtual.Location = new System.Drawing.Point(287, 132);
            this.textBoxSenhaAtual.Name = "textBoxSenhaAtual";
            this.textBoxSenhaAtual.Size = new System.Drawing.Size(200, 20);
            this.textBoxSenhaAtual.TabIndex = 5;
            this.textBoxSenhaAtual.UseSystemPasswordChar = true;
            // 
            // labelNovaSenha
            // 
            this.labelNovaSenha.AutoSize = true;
            this.labelNovaSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelNovaSenha.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNovaSenha.Location = new System.Drawing.Point(73, 170);
            this.labelNovaSenha.Name = "labelNovaSenha";
            this.labelNovaSenha.Size = new System.Drawing.Size(114, 20);
            this.labelNovaSenha.TabIndex = 6;
            this.labelNovaSenha.Text = "Nova Senha:";
            // 
            // textBoxNovaSenha
            // 
            this.textBoxNovaSenha.Location = new System.Drawing.Point(287, 170);
            this.textBoxNovaSenha.Name = "textBoxNovaSenha";
            this.textBoxNovaSenha.Size = new System.Drawing.Size(200, 20);
            this.textBoxNovaSenha.TabIndex = 7;
            this.textBoxNovaSenha.UseSystemPasswordChar = true;
            // 
            // labelConfirmarNovaSenha
            // 
            this.labelConfirmarNovaSenha.AutoSize = true;
            this.labelConfirmarNovaSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmarNovaSenha.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConfirmarNovaSenha.Location = new System.Drawing.Point(74, 210);
            this.labelConfirmarNovaSenha.Name = "labelConfirmarNovaSenha";
            this.labelConfirmarNovaSenha.Size = new System.Drawing.Size(193, 18);
            this.labelConfirmarNovaSenha.TabIndex = 8;
            this.labelConfirmarNovaSenha.Text = "Confirmar Nova Senha:";
            // 
            // textBoxConfirmarNovaSenha
            // 
            this.textBoxConfirmarNovaSenha.Location = new System.Drawing.Point(287, 208);
            this.textBoxConfirmarNovaSenha.Name = "textBoxConfirmarNovaSenha";
            this.textBoxConfirmarNovaSenha.Size = new System.Drawing.Size(200, 20);
            this.textBoxConfirmarNovaSenha.TabIndex = 9;
            this.textBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSalvar.Location = new System.Drawing.Point(88, 254);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(139, 33);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancelar.Location = new System.Drawing.Point(311, 254);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(148, 33);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(284, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "senha deve conter 6 numeros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIAUDOTE.Properties.Resources.inicial__1_;
            this.ClientSize = new System.Drawing.Size(584, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxConfirmarNovaSenha);
            this.Controls.Add(this.labelConfirmarNovaSenha);
            this.Controls.Add(this.textBoxNovaSenha);
            this.Controls.Add(this.labelNovaSenha);
            this.Controls.Add(this.textBoxSenhaAtual);
            this.Controls.Add(this.labelSenhaAtual);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSenhaAtual;
        private System.Windows.Forms.TextBox textBoxSenhaAtual;
        private System.Windows.Forms.Label labelNovaSenha;
        private System.Windows.Forms.TextBox textBoxNovaSenha;
        private System.Windows.Forms.Label labelConfirmarNovaSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarNovaSenha;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
    }
}