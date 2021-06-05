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
    public partial class FrmEquipamentosDescartados : Form
    {
        public int IdUsuario { get; set; }

        public FrmEquipamentosDescartados()
        {
            InitializeComponent();
            DgvEquipamentos.AutoGenerateColumns = false;
        }

        public void CarregarEquipamentos()
        {
            DataTable dt;

            try
            {
                dt = DaoEquipamento.Sp_EquipamentoListBaixado();
            }
            catch (Exception)
            {
                throw;
            }

            DgvEquipamentos.DataSource = dt;
        }

        private void DgvEquipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.Dgvcodigobem.Index && e.RowIndex >= 0)
            {
                FrmEquipamento frmequipamento = new FrmEquipamento();
                frmequipamento.Acao = Acao.Nenhuma;
                frmequipamento.CodBem = (string)DgvEquipamentos.CurrentRow.Cells["Dgvcodigobem"].Value;
                frmequipamento.Show();
            }
        }

        private void FrmEquipamentosDescartados_Load(object sender, EventArgs e)
        {
            CarregarEquipamentos();
        }

        private void DgvEquipamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    CarregarEquipamentos();
                    break;
            }
        }
    }
}
