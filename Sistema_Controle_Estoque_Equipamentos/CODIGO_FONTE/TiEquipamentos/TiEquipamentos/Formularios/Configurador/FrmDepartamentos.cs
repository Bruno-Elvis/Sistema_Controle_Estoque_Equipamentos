using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiEquipamentos.Dao;
using TiEquipamentos.Model;

namespace TiEquipamentos.Formularios.Configurador
{
    public partial class FrmDepartamentos : Form
    {
        public bool Aberto { get; set; }

        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        public void CarregarDepartamentos()
        {
            DataTable dt;

            try
            {
                dt = DaoDepartamento.Sp_DepartamentoList();
            }
            catch (Exception)
            {
                throw;
            }

            DgvDepartamentos.DataSource = dt;
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmdepartamento = new FrmDepartamento();
            frmdepartamento.Acao = Acao.Visualizar;
            frmdepartamento.Id = (int)DgvDepartamentos.CurrentRow.Cells["Dgviddepartamento"].Value;
            frmdepartamento.Text = "Visualizar Dados do Departamento";
            frmdepartamento.frmDepartamentos = this;
            frmdepartamento.Show();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = (int)DgvDepartamentos.CurrentRow.Cells["Dgviddepartamento"].Value;
                try
                {
                    DaoUsuario.Sp_UsuarioDelete(id);
                    CarregarDepartamentos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmdepartamento = new FrmDepartamento();
            frmdepartamento.Acao = Acao.Editar;
            frmdepartamento.Id = Convert.ToInt32(DgvDepartamentos.CurrentRow.Cells["Dgviddepartamento"].Value);
            frmdepartamento.Text = "Editar Departamento";
            frmdepartamento.frmDepartamentos = this;
            frmdepartamento.Show();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmdepartamento = new FrmDepartamento();
            frmdepartamento.Acao = Acao.Incluir;
            frmdepartamento.Text = "Incluir Departamento";
            frmdepartamento.frmDepartamentos = this;
            frmdepartamento.Show();
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            CarregarDepartamentos();
            this.Aberto = true;
        }

        private void FrmDepartamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Aberto = false;
        }
    }
}
