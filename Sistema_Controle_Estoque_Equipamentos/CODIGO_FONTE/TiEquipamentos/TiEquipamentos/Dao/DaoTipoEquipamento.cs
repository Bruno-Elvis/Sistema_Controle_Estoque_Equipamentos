using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TiEquipamentos.Dao
{
    public class DaoTipoEquipamento : ConexaoBD
    {
        public static DataTable Sp_TipoEquipamentoList()
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            try
            {
                dt = GetDataTable("sp_tipoequipamentolist", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
    }
}
