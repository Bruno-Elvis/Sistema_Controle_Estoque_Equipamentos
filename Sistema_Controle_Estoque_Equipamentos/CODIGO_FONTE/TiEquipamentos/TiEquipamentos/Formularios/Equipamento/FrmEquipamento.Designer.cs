namespace TiEquipamentos.Formularios.Equipamento
{
    partial class FrmEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipamento));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CbbUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbbDepartamento = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvHistorico = new System.Windows.Forms.DataGridView();
            this.idhistorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codbem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipomov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomedepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 654);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.CbbUsuario);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.CbbDepartamento);
            this.tabPage1.Controls.Add(this.BtnCancelar);
            this.tabPage1.Controls.Add(this.BtnSalvar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1167, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equipamento";
            // 
            // CbbUsuario
            // 
            this.CbbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbUsuario.FormattingEnabled = true;
            this.CbbUsuario.Location = new System.Drawing.Point(563, 475);
            this.CbbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbUsuario.Name = "CbbUsuario";
            this.CbbUsuario.Size = new System.Drawing.Size(581, 28);
            this.CbbUsuario.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 452);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Usuário:";
            // 
            // CbbDepartamento
            // 
            this.CbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbDepartamento.FormattingEnabled = true;
            this.CbbDepartamento.Location = new System.Drawing.Point(12, 475);
            this.CbbDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbDepartamento.Name = "CbbDepartamento";
            this.CbbDepartamento.Size = new System.Drawing.Size(495, 28);
            this.CbbDepartamento.TabIndex = 16;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1039, 558);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 35);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(931, 558);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 35);
            this.BtnSalvar.TabIndex = 14;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 452);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1152, 154);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOCALIZAÇÃO ATUAL";
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
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1156, 357);
            this.groupBox2.TabIndex = 20;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DgvHistorico);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1167, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico Mov.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgvHistorico
            // 
            this.DgvHistorico.AllowUserToAddRows = false;
            this.DgvHistorico.AllowUserToDeleteRows = false;
            this.DgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhistorico,
            this.codbem,
            this.tipomov,
            this.nomedepartamento,
            this.datamov,
            this.nomeusuario});
            this.DgvHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvHistorico.Location = new System.Drawing.Point(4, 5);
            this.DgvHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvHistorico.Name = "DgvHistorico";
            this.DgvHistorico.ReadOnly = true;
            this.DgvHistorico.Size = new System.Drawing.Size(1159, 611);
            this.DgvHistorico.TabIndex = 0;
            // 
            // idhistorico
            // 
            this.idhistorico.HeaderText = "ID";
            this.idhistorico.Name = "idhistorico";
            this.idhistorico.ReadOnly = true;
            this.idhistorico.Visible = false;
            // 
            // codbem
            // 
            this.codbem.HeaderText = "Codigo Bem";
            this.codbem.Name = "codbem";
            this.codbem.ReadOnly = true;
            this.codbem.Visible = false;
            // 
            // tipomov
            // 
            this.tipomov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipomov.DataPropertyName = "tipomov";
            this.tipomov.HeaderText = "Tipo de Movimentação";
            this.tipomov.Name = "tipomov";
            this.tipomov.ReadOnly = true;
            this.tipomov.Width = 157;
            // 
            // nomedepartamento
            // 
            this.nomedepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomedepartamento.DataPropertyName = "nomedepartamento";
            this.nomedepartamento.HeaderText = "Departamento";
            this.nomedepartamento.Name = "nomedepartamento";
            this.nomedepartamento.ReadOnly = true;
            this.nomedepartamento.Width = 119;
            // 
            // datamov
            // 
            this.datamov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datamov.DataPropertyName = "datamov";
            this.datamov.HeaderText = "Data Movimentação";
            this.datamov.Name = "datamov";
            this.datamov.ReadOnly = true;
            this.datamov.Width = 140;
            // 
            // nomeusuario
            // 
            this.nomeusuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeusuario.DataPropertyName = "nomeusuario";
            this.nomeusuario.HeaderText = "Analista Responsvél";
            this.nomeusuario.Name = "nomeusuario";
            this.nomeusuario.ReadOnly = true;
            this.nomeusuario.Width = 145;
            // 
            // FrmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 688);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEquipamento";
            this.Load += new System.EventHandler(this.FrmEquipamento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CbbUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbbDepartamento;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codbem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipomov;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamov;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeusuario;
    }
}