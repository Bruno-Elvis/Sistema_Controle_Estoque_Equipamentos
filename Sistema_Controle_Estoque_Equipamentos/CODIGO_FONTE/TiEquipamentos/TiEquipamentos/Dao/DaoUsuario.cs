using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiEquipamentos.Dao
{
    public class DaoUsuario : ConexaoBD
    {
        public static DataTable Sp_UsuarioLogin(string login, string senha)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            pars.Add("p_login", new MySqlParameter("p_login", login));
            pars.Add("p_senha", new MySqlParameter("p_senha", senha));

            try
            {
                dt = GetDataTable("sp_usuariologin", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public static DataTable Sp_UsuarioList()
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            try
            {
                dt = GetDataTable("sp_usuariolist", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public static DataTable Sp_UsuarioDetails(int id)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", id));

            try
            {
                dt = GetDataTable("sp_usuariodetails", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public static int Sp_UsuarioCreate(string login, string senha, string nome, int departamentoId, ref Dictionary<string, MySqlParameter> parOut)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            MySqlParameter paramOut = new MySqlParameter();
            int qtd = 0;

            paramOut.ParameterName = "p_idusuario";
            paramOut.Direction = ParameterDirection.Output;
            paramOut.DbType = DbType.Int32;

            pars.Add("p_nomeusuario", new MySqlParameter("p_nomeusuario", nome));
            pars.Add("p_login", new MySqlParameter("p_login", login));
            pars.Add("p_senha", new MySqlParameter("p_senha", senha));
            pars.Add("p_iddepartamento", new MySqlParameter("p_iddepartamento", departamentoId));
            pars.Add("p_idusuario", paramOut);

            try
            {
                qtd = Execute("sp_usuariocreate", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }
        public static int Sp_UsuarioDelete(int id)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();
            int qtd = 0;

            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", id));

            try
            {
                qtd = Execute("sp_usuariodelete", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }
        public static int Sp_UsuarioEdit(int id, string login, string senha, string nome, int departamentoId)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();
            int qtd = 0;

            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", id));
            pars.Add("p_nomeusuario", new MySqlParameter("p_nomeusuario", nome));
            pars.Add("p_login", new MySqlParameter("p_login", login));
            pars.Add("p_senha", new MySqlParameter("p_senha", senha));
            pars.Add("p_iddepartamento", new MySqlParameter("p_iddepartamento", departamentoId));

            try
            {
                qtd = Execute("sp_usuarioedit", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

    }
}
