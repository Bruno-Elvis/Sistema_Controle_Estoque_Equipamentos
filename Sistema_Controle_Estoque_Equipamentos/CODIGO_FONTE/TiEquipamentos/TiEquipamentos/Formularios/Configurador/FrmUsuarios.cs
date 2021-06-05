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
    public partial class FrmUsuarios : Form
    {
        public bool Aberto { get; set; }

        public FrmUsuarios()
        {
            InitializeComponent();
            DgvClientes.AutoGenerateColumns = false;
        }

        public void CarregarUsuarios()
        {
            DataTable dt;

            try
            {
                dt = DaoUsuario.Sp_UsuarioList();
            }
            catch (Exception)
            {
                throw;
            }

            DgvClientes.DataSource = dt;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            this.Aberto = true;
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusuario = new FrmUsuario();
            frmusuario.Acao = Acao.Visualizar;
            frmusuario.Id = (int)DgvClientes.CurrentRow.Cells["Dgvidusuario"].Value;
            frmusuario.Text = "Visualizar Dados do Usuário";
            frmusuario.frmUsuarios = this;
            frmusuario.Show();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = (int)DgvClientes.CurrentRow.Cells["Dgvidusuario"].Value;
                try
                {
                    DaoUsuario.Sp_UsuarioDelete(id);
                    CarregarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusuario = new FrmUsuario();
            frmusuario.Acao = Acao.Editar;
            frmusuario.Id = Convert.ToInt32(DgvClientes.CurrentRow.Cells["Dgvidusuario"].Value);
            frmusuario.Text = "Editar Usuário";
            frmusuario.frmUsuarios = this;
            frmusuario.Show();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusuario = new FrmUsuario();
            frmusuario.Acao = Acao.Incluir;
            frmusuario.Text = "Incluir Usuário";
            frmusuario.frmUsuarios = this;
            frmusuario.Show();
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Aberto = false;
        }
    }
}
