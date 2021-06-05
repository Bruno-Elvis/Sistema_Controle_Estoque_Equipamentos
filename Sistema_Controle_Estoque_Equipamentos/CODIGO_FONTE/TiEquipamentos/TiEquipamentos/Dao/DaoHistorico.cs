using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TiEquipamentos.Dao
{
    public class DaoHistorico : ConexaoBD
    {
        public static DataTable Sp_HistoricoDetails(string cod)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            pars.Add("p_codbem", new MySqlParameter("p_codbem", cod));

            try
            {
                dt = GetDataTable("sp_historicodetails", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
    }
}
