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

namespace TiEquipamentos
{
    public partial class FrmLogin : Form
    {
        public Usuario usuario { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            this.usuario = new Usuario();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            DataTable dt;

            try
            {
                dt = DaoUsuario.Sp_UsuarioLogin(TxtLogin.Text, TxtSenha.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }

            if (dt.Rows.Count > 0)
            {
                usuario.IdUsuario = dt.Rows[0].Field<int>("idusuario");
                usuario.Nome = dt.Rows[0].Field<string>("nomeusuario");
                usuario.IdDepartamento = dt.Rows[0].Field<int>("iddepartamento");

                if (usuario.IdDepartamento == 1)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esse Usuario não tem permissão para entrar no sistema! \n Apenas Usuários da Equipe de TI que pode acessar o sistema!");
                }
            }
            else
            {
                MessageBox.Show("Usuario não encontrado!");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
