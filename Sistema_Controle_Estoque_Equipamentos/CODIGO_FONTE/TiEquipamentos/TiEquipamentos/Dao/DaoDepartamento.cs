using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiEquipamentos.Dao
{
    public class DaoDepartamento : ConexaoBD
    {
        
        public static DataTable Sp_DepartamentoList()
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            try
            {
                dt = GetDataTable("sp_departamentolist", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public static DataTable Sp_DepartamentoDetails(int id)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            pars.Add("p_iddepartamento", new MySqlParameter("p_iddepartamento", id));

            try
            {
                dt = GetDataTable("sp_departamentodetails", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public static int Sp_DepartamentoCreate(string departamento, ref Dictionary<string, MySqlParameter> parOut)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            MySqlParameter paramOut = new MySqlParameter();
            int qtd = 0;

            paramOut.ParameterName = "p_iddepartamento";
            paramOut.Direction = ParameterDirection.Output;
            paramOut.DbType = DbType.Int32;

            pars.Add("p_nomedepartamento", new MySqlParameter("p_nomedepartamento", departamento));
            pars.Add("p_iddepartamento", paramOut);

            try
            {
                qtd = Execute("sp_departamentocreate", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }
        public static int Sp_DepartamentoDelete(int id)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();
            int qtd = 0;

            pars.Add("p_iddepartamento", new MySqlParameter("p_iddepartamento", id));

            try
            {
                qtd = Execute("sp_departamentodelete", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }
        public static int Sp_DepartamentoEdit(int id, string departamento)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();
            int qtd = 0;

            pars.Add("p_iddepartamento", new MySqlParameter("p_iddepartamento", id));
            pars.Add("p_nomedepartamento", new MySqlParameter("p_nomedepartamento", departamento));

            try
            {
                qtd = Execute("sp_departamentoedit", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

    }
}
