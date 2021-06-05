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
    public partial class FrmMovimentacoes : Form
    {
        public Acao Acao { get; set; }
        public string CodBem { get; set; }
        public FrmEquipamentos frmEquipamentos { get; set; }
        public int IdUsuario { get; set; }

        public FrmMovimentacoes()
        {
            InitializeComponent();
        }

        private void FrmMovimentacoes_Load(object sender, EventArgs e)
        {
            PopularCbbDepartamento();
            PopularCbbFornecedor();
            PopularCbbTipoAquisicao();
            PopularCbbTipoEquipamento();
            PopularCbbUsuario();

            switch (Acao)
            {
                case Acao.Alocar:
                    BtnOk.Text = "Alocar";
                    CbbDepartamento.Enabled = true;
                    CbbUsuario.Enabled = true;
                    break;
                case Acao.Remover:
                    BtnOk.Text = "Remover";
                    CbbDepartamento.SelectedIndex = -1;
                    break;
                case Acao.Baixa:
                    BtnOk.Text = "Baixar";
                    CbbDepartamento.SelectedIndex = -1;
                    break;
            }
        }

        private void PreencherForm()
        {
            DataTable dt;

                    try
                    {
                        dt = DaoEquipamento.Sp_EquipamentoDetails(TxtCodBem.Text);
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
                    else
                    {
                        TxtCodBem.Clear();
                        TxtDescricao.Clear();
                        TxtObservacao.Clear();
                        CbbDepartamento.SelectedIndex = -1;
                        CbbUsuario.SelectedIndex = -1;
                        CbbFornecedor.SelectedIndex = -1;
                        CbbTipoAquisicao.SelectedIndex = -1;
                        CbbTipoEquipamento.SelectedIndex = -1;
                        MessageBox.Show("Equipamento não cadastrado!");
                        return;
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
        }

        private void PopularCbbFornecedor()
        {
            CbbFornecedor.DataSource = DaoFornecedor.Sp_FornecedorList();
            CbbFornecedor.DisplayMember = "nomefornecedor";
            CbbFornecedor.ValueMember = "idfornecedor";
            CbbFornecedor.SelectedIndex = -1;
        }

        private void PopularCbbTipoAquisicao()
        {
            CbbTipoAquisicao.DataSource = DaoTipoAquisicao.Sp_TipoAquisicaoList();
            CbbTipoAquisicao.DisplayMember = "nometipoaquisicao";
            CbbTipoAquisicao.ValueMember = "idtipoaquisicao";
            CbbTipoAquisicao.SelectedIndex = -1;
        }

        private void PopularCbbTipoEquipamento()
        {
            CbbTipoEquipamento.DataSource = DaoTipoEquipamento.Sp_TipoEquipamentoList();
            CbbTipoEquipamento.DisplayMember = "nometipoequipamento";
            CbbTipoEquipamento.ValueMember = "idtipoequipamento";
            CbbTipoEquipamento.SelectedIndex = -1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();

            switch (Acao)
            {
                case Acao.Alocar:
                    try
                    {
                        DaoEquipamento.Sp_EquipamentoAlocar(TxtCodBem.Text, this.IdUsuario, (int)CbbDepartamento.SelectedValue, DateTime.Now, ref parOut);
                        MessageBox.Show("Equipamento Alocado!", "Sucesso");
                        this.Close();
                        if (frmEquipamentos.Aberto == true) frmEquipamentos.CarregarEquipamentos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    break;
                case Acao.Remover:
                    try
                    {
                        DaoEquipamento.Sp_EquipamentoRemover(TxtCodBem.Text, this.IdUsuario, DateTime.Now, ref parOut);
                        MessageBox.Show("Equipamento Removido!", "Sucesso");
                        this.Close();
                        if (frmEquipamentos.Aberto == true) frmEquipamentos.CarregarEquipamentos();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    break;
                case Acao.Baixa:
                    try
                    {
                        DaoEquipamento.Sp_EquipamentoBaixa(TxtCodBem.Text, this.IdUsuario, DateTime.Now, ref parOut);
                        MessageBox.Show("Equipamento Movido para Descarte!", "Sucesso");
                        this.Close();
                        if (frmEquipamentos.Aberto == true) frmEquipamentos.CarregarEquipamentos();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    break;
            }
        }

        

        private void TxtCodBem_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    PreencherForm();
                    break;
            }
        }
    }
}
