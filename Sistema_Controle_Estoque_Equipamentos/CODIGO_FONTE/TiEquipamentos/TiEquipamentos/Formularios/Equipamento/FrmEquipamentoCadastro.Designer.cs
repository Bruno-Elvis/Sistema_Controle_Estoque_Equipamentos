namespace TiEquipamentos.Formularios.Equipamento
{
    partial class FrmEquipamentoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipamentoCadastro));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbbFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.CbbTipoAquisicao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodBem = new System.Windows.Forms.TextBox();
            this.CbbTipoEquipamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1069, 385);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 35);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(961, 385);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 35);
            this.BtnSalvar.TabIndex = 25;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CbbFornecedor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtDescricao);
            this.groupBox2.Controls.Add(this.CbbTipoAquisicao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtCodBem);
            this.groupBox2.Controls.Add(this.CbbTipoEquipamento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtObservacao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1156, 357);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Equipamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Bem:";
            // 
            // CbbFornecedor
            // 
            this.CbbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbFornecedor.FormattingEnabled = true;
            this.CbbFornecedor.Location = new System.Drawing.Point(8, 132);
            this.CbbFornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbFornecedor.Name = "CbbFornecedor";
            this.CbbFornecedor.Size = new System.Drawing.Size(432, 28);
            this.CbbFornecedor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(300, 69);
            this.TxtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(841, 25);
            this.TxtDescricao.TabIndex = 8;
            // 
            // CbbTipoAquisicao
            // 
            this.CbbTipoAquisicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbTipoAquisicao.FormattingEnabled = true;
            this.CbbTipoAquisicao.Location = new System.Drawing.Point(499, 132);
            this.CbbTipoAquisicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbTipoAquisicao.Name = "CbbTipoAquisicao";
            this.CbbTipoAquisicao.Size = new System.Drawing.Size(284, 28);
            this.CbbTipoAquisicao.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fornecedor:";
            // 
            // TxtCodBem
            // 
            this.TxtCodBem.Location = new System.Drawing.Point(8, 72);
            this.TxtCodBem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodBem.Name = "TxtCodBem";
            this.TxtCodBem.Size = new System.Drawing.Size(239, 25);
            this.TxtCodBem.TabIndex = 7;
            // 
            // CbbTipoEquipamento
            // 
            this.CbbTipoEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbTipoEquipamento.FormattingEnabled = true;
            this.CbbTipoEquipamento.Location = new System.Drawing.Point(847, 132);
            this.CbbTipoEquipamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbTipoEquipamento.Name = "CbbTipoEquipamento";
            this.CbbTipoEquipamento.Size = new System.Drawing.Size(293, 28);
            this.CbbTipoEquipamento.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Aquisição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observação:";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(8, 211);
            this.TxtObservacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(1133, 113);
            this.TxtObservacao.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Equipamento:";
            // 
            // FrmEquipamentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 437);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEquipamentoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR EQUIPAMENTO";
            this.Load += new System.EventHandler(this.FrmEquipamentoCadastro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbbFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.ComboBox CbbTipoAquisicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodBem;
        private System.Windows.Forms.ComboBox CbbTipoEquipamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label label5;
    }
}