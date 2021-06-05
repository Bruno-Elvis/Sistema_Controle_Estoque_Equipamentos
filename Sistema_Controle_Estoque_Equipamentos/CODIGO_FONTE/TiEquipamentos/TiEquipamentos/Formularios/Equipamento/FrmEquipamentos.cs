using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiEquipamentos.Model;
using TiEquipamentos.Dao;

namespace TiEquipamentos.Formularios.Equipamento
{
    public partial class FrmEquipamentos : Form
    {
        public int IdUsuario { get; set; }
        public bool Aberto { get; set; }

        public FrmEquipamentos()
        {
            InitializeComponent();
            DgvEquipamentos.AutoGenerateColumns = false;
        }

        private void FrmEquipamentos_Load(object sender, EventArgs e)
        {
            CarregarEquipamentos();
            this.Aberto = true;
        }

        public void CarregarEquipamentos()
        {
            DataTable dt;
            string filtro = null;

            if (!string.IsNullOrWhiteSpace(TxtFiltro.Text)) filtro = TxtFiltro.Text;

            try
            {
                dt = DaoEquipamento.Sp_EquipamentoList(filtro);
            }
            catch (Exception)
            {
                throw;
            }

            DgvEquipamentos.DataSource = dt;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmEquipamentoCadastro frmequipamentocadastro = new FrmEquipamentoCadastro();
            frmequipamentocadastro.Acao = Acao.Incluir;
            frmequipamentocadastro.IdUsuario = this.IdUsuario;
            frmequipamentocadastro.frmEquipamentos = this;
            frmequipamentocadastro.Show();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarEquipamentos();
        }

        private void BtnAlocIncluir_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmmov = new FrmMovimentacoes();
            frmmov.Text = "ALOCAÇÃO - INCLUIR";
            frmmov.IdUsuario = this.IdUsuario;
            frmmov.CodBem = (string)DgvEquipamentos.CurrentRow.Cells["Dgvcodigobem"].Value;
            frmmov.Acao = Acao.Alocar;
            frmmov.frmEquipamentos = this;
            frmmov.Show();
        }

        private void DgvEquipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.Dgvcodigobem.Index && e.RowIndex >= 0)
            {
                FrmEquipamento frmequipamento = new FrmEquipamento();
                frmequipamento.Acao = Acao.Editar;
                frmequipamento.frmEquipamentos = this;
                frmequipamento.CodBem = (string)DgvEquipamentos.CurrentRow.Cells["Dgvcodigobem"].Value;
                frmequipamento.Show();
            }
        }

        private void BtnSubRemocao_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmmov = new FrmMovimentacoes();
            frmmov.Text = "SUBSTITUIÇÃO - REMOVER";
            frmmov.IdUsuario = this.IdUsuario;
            frmmov.CodBem = (string)DgvEquipamentos.CurrentRow.Cells["Dgvcodigobem"].Value;
            frmmov.Acao = Acao.Remover;
            frmmov.frmEquipamentos = this;
            frmmov.Show();
        }

        private void BtnDescBaixa_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmmov = new FrmMovimentacoes();
            frmmov.Text = "DESCARTE - BAIXA";
            frmmov.IdUsuario = this.IdUsuario;
            frmmov.CodBem = (string)DgvEquipamentos.CurrentRow.Cells["Dgvcodigobem"].Value;
            frmmov.Acao = Acao.Baixa;
            frmmov.frmEquipamentos = this;
            frmmov.Show();
        }

        private void BtnEqdescartados_Click(object sender, EventArgs e)
        {
            FrmEquipamentosDescartados frmdescartados = new FrmEquipamentosDescartados();
            frmdescartados.Show();
        }

        private void FrmEquipamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Aberto = false;
        }
    }
}
