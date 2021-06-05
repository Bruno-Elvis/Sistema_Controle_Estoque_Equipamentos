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
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamentos frmDepartamentos { get; set; }
        public Acao Acao { get; set; }
        public int Id { get; set; }

        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void PreencherForm()
        {
            DataTable dt;

            try
            {
                dt = DaoDepartamento.Sp_DepartamentoDetails(this.Id);
            }
            catch (Exception)
            {
                throw;
            }

            if (dt.Rows.Count > 0)
            {
                Txtdepartamento.Text = dt.Rows[0].Field<String>("nomedepartamento");
            }
        }

        private void TravarCampos()
        {
            Txtdepartamento.Enabled = false;
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();

            switch (this.Acao)
            {
                case Acao.Incluir:
                    try
                    {
                        DaoDepartamento.Sp_DepartamentoCreate(Txtdepartamento.Text, ref parOut);
                        MessageBox.Show("Cadastro!", "OK");
                        if (frmDepartamentos.Aberto == true) frmDepartamentos.CarregarDepartamentos();
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
                        DaoDepartamento.Sp_DepartamentoEdit(this.Id, Txtdepartamento.Text);
                        MessageBox.Show("Departamento alterado com sucesso!", "OK");
                        if (frmDepartamentos.Aberto == true) frmDepartamentos.CarregarDepartamentos();
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
