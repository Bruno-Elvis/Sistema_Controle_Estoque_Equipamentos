using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace TiEquipamentos.Dao
{
    public class ConexaoBD
    {
        protected static string connectionDefault = "Server=186.202.152.146;User id=equipamentoti;Password=Samsung6969*;Database=equipamentoti";
        //protected static string connectionDefault = "Server=localhost;User id=root;Password=123456;Database=equipamentoti";

        #region Métodos estáticos

        public static MySqlTransaction GetTransaction(MySqlConnection conn)
        {
            try
            {
                MySqlTransaction trans = conn.BeginTransaction();
                return trans;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected static DataTable GetDataTable(string strSql, CommandType cmdType, Dictionary<string, MySqlParameter> dicParams)
        {
            MySqlCommand cmd = null;
            DataTable dt = null;
            MySqlDataAdapter da = null;
            MySqlConnection conn = new MySqlConnection(connectionDefault);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            cmd = new MySqlCommand(strSql, conn);
            cmd.CommandType = cmdType;

            if (dicParams != null)
            {
                foreach (MySqlParameter parametro in dicParams.Values)
                {
                    cmd.Parameters.Add(parametro);
                }
            }

            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

            return dt;
        }

        protected static DataSet GetDataSet(string strSql, CommandType cmdType, Dictionary<string, MySqlParameter> dicParams)
        {
            MySqlCommand cmd = null;
            DataSet ds = null;
            MySqlDataAdapter da = null;
            MySqlConnection conn = new MySqlConnection(connectionDefault);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            cmd = new MySqlCommand(strSql, conn);
            cmd.CommandType = cmdType;

            if (dicParams != null)
            {
                foreach (MySqlParameter parametro in dicParams.Values)
                {
                    cmd.Parameters.Add(parametro);
                }
            }

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();

            try
            {
                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

            return ds;
        }

        protected static int Execute(string strSql, CommandType cmdType, Dictionary<string, MySqlParameter> dicParams, ref Dictionary<string, MySqlParameter> dicParamsOut)
        {
            int qtd = 0;
            MySqlCommand cmd = null;
            MySqlConnection conn = new MySqlConnection(connectionDefault);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            cmd = new MySqlCommand(strSql, conn);
            cmd.CommandType = cmdType;

            if (dicParams != null)
            {
                foreach (MySqlParameter parametro in dicParams.Values)
                {
                    cmd.Parameters.Add(parametro);
                }
            }

            try
            {
                qtd = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

            foreach (MySqlParameter myPar in cmd.Parameters)
            {
                if (myPar.Direction == ParameterDirection.Output)
                {
                    dicParamsOut.Add(myPar.ParameterName, myPar);
                }
            }

            return qtd;
        }

        #endregion
    }
}
