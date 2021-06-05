namespace TiEquipamentos.Formularios.Equipamento
{
    partial class FrmEquipamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipamentos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StripMovimentacao = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnAlocIncluir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSubRemocao = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDescBaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEqdescartados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.BtnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.DgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.Dgvcodigobem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometipoaquisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometipoequipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomedepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alocado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCadastrar,
            this.toolStripSeparator1,
            this.StripMovimentacao,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.TxtFiltro,
            this.BtnFiltrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1238, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.Image")));
            this.BtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(160, 24);
            this.BtnCadastrar.Text = "Cadastrar Equipamento";
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // StripMovimentacao
            // 
            this.StripMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlocIncluir,
            this.BtnSubRemocao,
            this.BtnDescBaixa,
            this.BtnEqdescartados});
            this.StripMovimentacao.Image = ((System.Drawing.Image)(resources.GetObject("StripMovimentacao.Image")));
            this.StripMovimentacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripMovimentacao.Name = "StripMovimentacao";
            this.StripMovimentacao.Size = new System.Drawing.Size(126, 24);
            this.StripMovimentacao.Text = "Movimentações";
            // 
            // BtnAlocIncluir
            // 
            this.BtnAlocIncluir.Name = "BtnAlocIncluir";
            this.BtnAlocIncluir.Size = new System.Drawing.Size(231, 24);
            this.BtnAlocIncluir.Text = "Alocação - Incluir";
            this.BtnAlocIncluir.Click += new System.EventHandler(this.BtnAlocIncluir_Click);
            // 
            // BtnSubRemocao
            // 
            this.BtnSubRemocao.Name = "BtnSubRemocao";
            this.BtnSubRemocao.Size = new System.Drawing.Size(231, 24);
            this.BtnSubRemocao.Text = "Substituição - Remoção";
            this.BtnSubRemocao.Click += new System.EventHandler(this.BtnSubRemocao_Click);
            // 
            // BtnDescBaixa
            // 
            this.BtnDescBaixa.Name = "BtnDescBaixa";
            this.BtnDescBaixa.Size = new System.Drawing.Size(231, 24);
            this.BtnDescBaixa.Text = "Descarte - Baixa";
            this.BtnDescBaixa.Click += new System.EventHandler(this.BtnDescBaixa_Click);
            // 
            // BtnEqdescartados
            // 
            this.BtnEqdescartados.Name = "BtnEqdescartados";
            this.BtnEqdescartados.Size = new System.Drawing.Size(231, 24);
            this.BtnEqdescartados.Text = "Equipamentos Descartados";
            this.BtnEqdescartados.Click += new System.EventHandler(this.BtnEqdescartados_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 24);
            this.toolStripLabel1.Text = "Código do Bem:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFiltro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(132, 27);
            this.TxtFiltro.Tag = "";
            this.TxtFiltro.ToolTipText = "Digite o Código do Bem...";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiltrar.Image")));
            this.BtnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(61, 24);
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // DgvEquipamentos
            // 
            this.DgvEquipamentos.AllowUserToAddRows = false;
            this.DgvEquipamentos.AllowUserToDeleteRows = false;
            this.DgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEquipamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgvcodigobem,
            this.descricao,
            this.nomefornecedor,
            this.nometipoaquisicao,
            this.nometipoequipamento,
            this.nomedepartamento,
            this.alocado});
            this.DgvEquipamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEquipamentos.Location = new System.Drawing.Point(0, 27);
            this.DgvEquipamentos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DgvEquipamentos.Name = "DgvEquipamentos";
            this.DgvEquipamentos.ReadOnly = true;
            this.DgvEquipamentos.Size = new System.Drawing.Size(1238, 664);
            this.DgvEquipamentos.TabIndex = 2;
            this.DgvEquipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquipamentos_CellContentClick);
            // 
            // Dgvcodigobem
            // 
            this.Dgvcodigobem.DataPropertyName = "codigobem";
            this.Dgvcodigobem.HeaderText = "Código Bem";
            this.Dgvcodigobem.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.Dgvcodigobem.LinkColor = System.Drawing.Color.Black;
            this.Dgvcodigobem.Name = "Dgvcodigobem";
            this.Dgvcodigobem.ReadOnly = true;
            this.Dgvcodigobem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgvcodigobem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 95;
            // 
            // nomefornecedor
            // 
            this.nomefornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomefornecedor.DataPropertyName = "nomefornecedor";
            this.nomefornecedor.HeaderText = "Fornecedor";
            this.nomefornecedor.Name = "nomefornecedor";
            this.nomefornecedor.ReadOnly = true;
            this.nomefornecedor.Width = 105;
            // 
            // nometipoaquisicao
            // 
            this.nometipoaquisicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nometipoaquisicao.DataPropertyName = "nometipoaquisicao";
            this.nometipoaquisicao.HeaderText = "Tipo de Aquisição";
            this.nometipoaquisicao.Name = "nometipoaquisicao";
            this.nometipoaquisicao.ReadOnly = true;
            this.nometipoaquisicao.Width = 132;
            // 
            // nometipoequipamento
            // 
            this.nometipoequipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nometipoequipamento.DataPropertyName = "nometipoequipamento";
            this.nometipoequipamento.HeaderText = "Tipo de Equipamento";
            this.nometipoequipamento.Name = "nometipoequipamento";
            this.nometipoequipamento.ReadOnly = true;
            this.nometipoequipamento.Width = 150;
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
            // alocado
            // 
            this.alocado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alocado.DataPropertyName = "alocado";
            this.alocado.HeaderText = "Alocação";
            this.alocado.Name = "alocado";
            this.alocado.ReadOnly = true;
            this.alocado.Width = 91;
            // 
            // FrmEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 691);
            this.Controls.Add(this.DgvEquipamentos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmEquipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEquipamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEquipamentos_FormClosing);
            this.Load += new System.EventHandler(this.FrmEquipamentos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton StripMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem BtnAlocIncluir;
        private System.Windows.Forms.ToolStripMenuItem BtnSubRemocao;
        private System.Windows.Forms.ToolStripMenuItem BtnDescBaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TxtFiltro;
        private System.Windows.Forms.ToolStripButton BtnFiltrar;
        private System.Windows.Forms.DataGridView DgvEquipamentos;
        private System.Windows.Forms.DataGridViewLinkColumn Dgvcodigobem;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometipoaquisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometipoequipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn alocado;
        private System.Windows.Forms.ToolStripMenuItem BtnEqdescartados;
    }
}