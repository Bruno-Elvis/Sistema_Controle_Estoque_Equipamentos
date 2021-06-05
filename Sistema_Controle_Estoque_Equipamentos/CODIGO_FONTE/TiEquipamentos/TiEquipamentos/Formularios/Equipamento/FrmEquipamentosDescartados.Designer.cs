namespace TiEquipamentos.Formularios.Equipamento
{
    partial class FrmEquipamentosDescartados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipamentosDescartados));
            this.DgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.Dgvcodigobem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometipoaquisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometipoequipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomedepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alocado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipamentos)).BeginInit();
            this.SuspendLayout();
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
            this.DgvEquipamentos.Location = new System.Drawing.Point(0, 0);
            this.DgvEquipamentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvEquipamentos.Name = "DgvEquipamentos";
            this.DgvEquipamentos.ReadOnly = true;
            this.DgvEquipamentos.Size = new System.Drawing.Size(981, 609);
            this.DgvEquipamentos.TabIndex = 3;
            this.DgvEquipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquipamentos_CellContentClick);
            this.DgvEquipamentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvEquipamentos_KeyPress);
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
            this.descricao.Width = 80;
            // 
            // nomefornecedor
            // 
            this.nomefornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomefornecedor.DataPropertyName = "nomefornecedor";
            this.nomefornecedor.HeaderText = "Fornecedor";
            this.nomefornecedor.Name = "nomefornecedor";
            this.nomefornecedor.ReadOnly = true;
            this.nomefornecedor.Width = 86;
            // 
            // nometipoaquisicao
            // 
            this.nometipoaquisicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nometipoaquisicao.DataPropertyName = "nometipoaquisicao";
            this.nometipoaquisicao.HeaderText = "Tipo de Aquisição";
            this.nometipoaquisicao.Name = "nometipoaquisicao";
            this.nometipoaquisicao.ReadOnly = true;
            this.nometipoaquisicao.Width = 107;
            // 
            // nometipoequipamento
            // 
            this.nometipoequipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nometipoequipamento.DataPropertyName = "nometipoequipamento";
            this.nometipoequipamento.HeaderText = "Tipo de Equipamento";
            this.nometipoequipamento.Name = "nometipoequipamento";
            this.nometipoequipamento.ReadOnly = true;
            this.nometipoequipamento.Width = 122;
            // 
            // nomedepartamento
            // 
            this.nomedepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomedepartamento.DataPropertyName = "nomedepartamento";
            this.nomedepartamento.HeaderText = "Departamento";
            this.nomedepartamento.Name = "nomedepartamento";
            this.nomedepartamento.ReadOnly = true;
            this.nomedepartamento.Width = 99;
            // 
            // alocado
            // 
            this.alocado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alocado.DataPropertyName = "alocado";
            this.alocado.HeaderText = "Alocação";
            this.alocado.Name = "alocado";
            this.alocado.ReadOnly = true;
            this.alocado.Width = 77;
            // 
            // FrmEquipamentosDescartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 609);
            this.Controls.Add(this.DgvEquipamentos);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEquipamentosDescartados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamentos Descartados";
            this.Load += new System.EventHandler(this.FrmEquipamentosDescartados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEquipamentos;
        private System.Windows.Forms.DataGridViewLinkColumn Dgvcodigobem;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometipoaquisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometipoequipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn alocado;
    }
}