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

namespace TiEquipamentos.Formularios.Equipamento
{
    public partial class FrmEquipamento : Form
    {
        public Acao Acao { get; set; }
        public string CodBem { get; set; }
        public FrmEquipamentos frmEquipamentos { get; set; }

        public FrmEquipamento()
        {
            InitializeComponent();
            DgvHistorico.AutoGenerateColumns = false;
        }

        private void FrmEquipamento_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
            PopularCbbDepartamento();
            PopularCbbFornecedor();
            PopularCbbTipoAquisicao();
            PopularCbbTipoEquipamento();
            PopularCbbUsuario();

            switch (Acao)
            {
                case Acao.Editar:
                    PreencherForm();
                    TravarCampos();
                    break;
                case Acao.Nenhuma:
                    PreencherForm();
                    TravarCampos();
                    break;
            }
        }

        private void TravarCampos()
        {
            if (Acao == Acao.Editar)
            {
                CbbDepartamento.Enabled = false;
                CbbUsuario.Enabled = false;
                TxtCodBem.Enabled = false;
            }
            else
            {
                CbbDepartamento.Enabled = false;
                CbbUsuario.Enabled = false;
                TxtCodBem.Enabled = false;
                CbbFornecedor.Enabled = false;
                CbbTipoAquisicao.Enabled = false;
                CbbTipoEquipamento.Enabled = false;
                CbbUsuario.Enabled = false;
                BtnSalvar.Enabled = false;
                TxtDescricao.Enabled = false;
                TxtObservacao.Enabled = false;
            }
            
        }

        private void CarregarHistorico()
        {
            DataTable dt;

            try
            {
                dt = DaoHistorico.Sp_HistoricoDetails(this.CodBem);
            }
            catch (Exception)
            {
                throw;
            }
            DgvHistorico.DataSource = dt;
        }

        private void PreencherForm()
        {
            DataTable dt;

            try
            {
                dt = DaoEquipamento.Sp_EquipamentoDetails(this.CodBem);
            }
            catch (Exception)
            {
                throw;
            }

            if (dt.Rows.Count > 0)
            {
                TxtCodBem.Text = dt.Rows[0].Field<String>("codigobem");
                TxtDescricao.Text = dt.Rows[0].Field<String>("descricao");
                TxtObservacao.Text = dt.Rows[0].Field<String>("observacao");
                CbbFornecedor.SelectedValue = dt.Rows[0].Field<int>("idfornecedor");
                CbbTipoAquisicao.SelectedValue = dt.Rows[0].Field<int>("idtipoaquisicao");
                CbbTipoEquipamento.SelectedValue = dt.Rows[0].Field<int>("idtipoequipamento");
                if (dt.Rows[0].IsNull("iddepartamento")) CbbDepartamento.SelectedIndex = -1; else CbbDepartamento.SelectedValue = dt.Rows[0].Field<int>("iddepartamento");
                if (dt.Rows[0].IsNull("idusuario")) CbbUsuario.SelectedIndex = -1; else CbbUsuario.SelectedValue = dt.Rows[0].Field<int>("idusuario");

            }
        }

        private void PopularCbbUsuario()
        {
            CbbUsuario.DataSource = DaoUsuario.Sp_UsuarioList();
            CbbUsuario.DisplayMember = "nomeusuario";
            CbbUsuario.ValueMember = "idusuario";
            CbbUsuario.SelectedIndex = -1;
        }

        private void PopularCbbDepartamento()
        {
            CbbDepartamento.DataSource = DaoDepartamento.Sp_DepartamentoList();
            CbbDepartamento.DisplayMember = "nomedepartamento";
            CbbDepartamento.ValueMember = "iddepartamento";
            CbbDepartamento.SelectedIndex = -1;
        }

        private void PopularCbbFornecedor()
        {
            CbbFornecedor.DataSource = DaoFornecedor.Sp_FornecedorList();
            CbbFornecedor.DisplayMember = "nomefornecedor";
            CbbFornecedor.ValueMember = "idfornecedor";
        }

        private void PopularCbbTipoAquisicao()
        {
            CbbTipoAquisicao.DataSource = DaoTipoAquisicao.Sp_TipoAquisicaoList();
            CbbTipoAquisicao.DisplayMember = "nometipoaquisicao";
            CbbTipoAquisicao.ValueMember = "idtipoaquisicao";
        }

        private void PopularCbbTipoEquipamento()
        {
            CbbTipoEquipamento.DataSource = DaoTipoEquipamento.Sp_TipoEquipamentoList();
            CbbTipoEquipamento.DisplayMember = "nometipoequipamento";
            CbbTipoEquipamento.ValueMember = "idtipoequipamento";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            switch (Acao)
            {
                case Acao.Editar:
                    try
                    {
                        DaoEquipamento.Sp_EquipamentoEdit(this.CodBem, TxtDescricao.Text, (int)CbbFornecedor.SelectedValue, (int)CbbTipoAquisicao.SelectedValue, (int)CbbTipoEquipamento.SelectedValue, TxtObservacao.Text, (int)CbbDepartamento.SelectedValue);
                        MessageBox.Show("Dados atualizados!", "Sucesso");
                        frmEquipamentos.CarregarEquipamentos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    break;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
