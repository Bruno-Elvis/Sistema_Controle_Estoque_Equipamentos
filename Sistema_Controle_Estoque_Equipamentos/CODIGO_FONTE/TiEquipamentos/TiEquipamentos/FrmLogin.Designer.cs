namespace TiEquipamentos
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(196, 95);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 34);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.Location = new System.Drawing.Point(89, 95);
            this.BtnLogar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(99, 34);
            this.BtnLogar.TabIndex = 16;
            this.BtnLogar.Text = "Login";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(89, 55);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(206, 25);
            this.TxtSenha.TabIndex = 15;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(89, 18);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(206, 25);
            this.TxtLogin.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

