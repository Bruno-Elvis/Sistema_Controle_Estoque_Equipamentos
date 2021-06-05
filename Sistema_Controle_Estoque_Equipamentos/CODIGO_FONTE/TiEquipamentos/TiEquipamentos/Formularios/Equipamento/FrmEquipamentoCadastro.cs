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
using MySql.Data.MySqlClient;

namespace TiEquipamentos.Formularios.Equipamento
{
    public partial class FrmEquipamentoCadastro : Form
    {

        public Acao Acao { get; set; }
        public string CodBem { get; set; }
        public FrmEquipamentos frmEquipamentos { get; set; }
        public int IdUsuario { get; set; }

        public FrmEquipamentoCadastro()
        {
            InitializeComponent();
        }

        private void FrmEquipamentoCadastro_Load(object sender, EventArgs e)
        {
            PopularCbbFornecedor();
            PopularCbbTipoAquisicao();
            PopularCbbTipoEquipamento();
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
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();

            switch (Acao)
            {
                case Acao.Incluir:
                    try
                    {
                        DaoEquipamento.Sp_EquipamentoCreate(TxtCodBem.Text, TxtDescricao.Text, (int)CbbFornecedor.SelectedValue, (int)CbbTipoAquisicao.SelectedValue, (int)CbbTipoEquipamento.SelectedValue, TxtObservacao.Text, DateTime.Now, this.IdUsuario, ref parOut);
                        MessageBox.Show("Equipamento Cadastrado!", "Sucesso");
                        LimparCampos();
                        if(frmEquipamentos.Aberto == true) frmEquipamentos.CarregarEquipamentos();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    break;
            }
        }

        private void LimparCampos()
        {
            TxtCodBem.Clear();
            TxtDescricao.Clear();
            TxtObservacao.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
