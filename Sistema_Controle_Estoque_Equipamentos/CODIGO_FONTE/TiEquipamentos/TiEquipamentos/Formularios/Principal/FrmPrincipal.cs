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
using TiEquipamentos.Formularios.Configurador;
using TiEquipamentos.Formularios.Equipamento;

namespace TiEquipamentos.Formularios.Principal
{
    public partial class FrmPrincipal : Form
    {
        public Usuario usuario { get; set; }

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void departamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmDepartamentos frmdepartamentos = new FrmDepartamentos();
            frmdepartamentos.Show();
        }

        private void usuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios frmusuarios = new FrmUsuarios();
            frmusuarios.Show();
        }

        private void equipamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmEquipamentos frmequipamentos = new FrmEquipamentos();
            frmequipamentos.IdUsuario = usuario.IdUsuario;
            frmequipamentos.Show();
        }
    }
}
