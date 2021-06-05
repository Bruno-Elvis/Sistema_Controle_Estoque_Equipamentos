using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TiEquipamentos.Dao
{
    public class DaoTipoAquisicao : ConexaoBD
    {
        public static DataTable Sp_TipoAquisicaoList()
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            try
            {
                dt = GetDataTable("sp_tipoaquisicaolist", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
    }
}
