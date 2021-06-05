namespace TiEquipamentos.Formularios.Configurador
{
    partial class FrmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamentos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnIncluir = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.BtnVisualizar = new System.Windows.Forms.ToolStripButton();
            this.DgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.Dgviddepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomedepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnIncluir,
            this.BtnEditar,
            this.BtnExcluir,
            this.BtnVisualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnIncluir.Image")));
            this.BtnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(58, 22);
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(55, 22);
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(60, 22);
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVisualizar.Image")));
            this.BtnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(74, 22);
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // DgvDepartamentos
            // 
            this.DgvDepartamentos.AllowUserToAddRows = false;
            this.DgvDepartamentos.AllowUserToDeleteRows = false;
            this.DgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgviddepartamento,
            this.nomedepartamento});
            this.DgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDepartamentos.Location = new System.Drawing.Point(0, 25);
            this.DgvDepartamentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvDepartamentos.Name = "DgvDepartamentos";
            this.DgvDepartamentos.ReadOnly = true;
            this.DgvDepartamentos.Size = new System.Drawing.Size(584, 613);
            this.DgvDepartamentos.TabIndex = 3;
            // 
            // Dgviddepartamento
            // 
            this.Dgviddepartamento.DataPropertyName = "iddepartamento";
            this.Dgviddepartamento.HeaderText = "ID";
            this.Dgviddepartamento.Name = "Dgviddepartamento";
            this.Dgviddepartamento.ReadOnly = true;
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
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 638);
            this.Controls.Add(this.DgvDepartamentos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPARTAMENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDepartamentos_FormClosing);
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnIncluir;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton BtnExcluir;
        private System.Windows.Forms.ToolStripButton BtnVisualizar;
        private System.Windows.Forms.DataGridView DgvDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgviddepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedepartamento;
    }
}