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
using MySql.Data.MySqlClient;

namespace TiEquipamentos.Formularios.Configurador
{
    public partial class FrmUsuario : Form
    {
        public int Id { get; set; }
        public Acao Acao { get; set; }
        public FrmUsuarios frmUsuarios { get; set; }

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void PopularDepartamento()
        {
            CbbDepartamento.DataSource = DaoDepartamento.Sp_DepartamentoList();
            CbbDepartamento.DisplayMember = "nomedepartamento";
            CbbDepartamento.ValueMember = "iddepartamento";
        }

        private void PreencherForm()
        {
            DataTable dt;

            try
            {
                dt = DaoUsuario.Sp_UsuarioDetails(this.Id);
            }
            catch (Exception)
            {
                throw;
            }

            if (dt.Rows.Count > 0)
            {
                TxtLogin.Text = dt.Rows[0].Field<String>("login");
                Txtnome.Text = dt.Rows[0].Field<String>("nomeusuario");
                TxtSenha.Text = dt.Rows[0].Field<String>("senha");
                CbbDepartamento.SelectedValue = dt.Rows[0].Field<int>("iddepartamento");
            }
        }

        private void TravarCampos()
        {
            TxtLogin.Enabled = false;
            Txtnome.Enabled = false;
            TxtSenha.Enabled = false;
            CbbDepartamento.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            PopularDepartamento();
            switch (Acao)
            {
                case Acao.Editar:
                    PreencherForm();
                    break;
                case Acao.Visualizar:
                    PreencherForm();
                    TravarCampos();
                    BtnSalvar.Enabled = false;
                    break;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();

            switch (this.Acao)
            {
                case Acao.Incluir:
                    try
                    {
                        DaoUsuario.Sp_UsuarioCreate(TxtLogin.Text, TxtSenha.Text, Txtnome.Text, (int)CbbDepartamento.SelectedValue, ref parOut);
                        MessageBox.Show("Cadastro!", "OK");
                        if (frmUsuarios.Aberto == true) frmUsuarios.CarregarUsuarios();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                        return;
                    }
                    break;
                case Acao.Editar:
                    try
                    {
                        DaoUsuario.Sp_UsuarioEdit(this.Id, TxtLogin.Text, TxtSenha.Text, Txtnome.Text, (int)CbbDepartamento.SelectedValue);
                        MessageBox.Show("Usuario alterado com sucesso!", "OK");
                        if (frmUsuarios.Aberto == true) frmUsuarios.CarregarUsuarios();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    break;
            }
        }
    }
}
