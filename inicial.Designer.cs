namespace MIAUDOTE
{
    partial class inicial
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
            this.botao_login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botao_login
            // 
            this.botao_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.botao_login.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botao_login.Location = new System.Drawing.Point(387, 265);
            this.botao_login.Name = "botao_login";
            this.botao_login.Size = new System.Drawing.Size(150, 33);
            this.botao_login.TabIndex = 10;
            this.botao_login.Text = "Login";
            this.botao_login.UseVisualStyleBackColor = false;
            this.botao_login.Click += new System.EventHandler(this.botao_login_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(576, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonCadastro_Click);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIAUDOTE.Properties.Resources.inicial;
            this.ClientSize = new System.Drawing.Size(813, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botao_login);
            this.DoubleBuffered = true;
            this.Name = "inicial";
            this.Text = "inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botao_login;
        private System.Windows.Forms.Button button2;
    }
}