using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TiEquipamentos.Dao
{
    public class DaoEquipamento : ConexaoBD
    {
        public static DataTable Sp_EquipamentoList(string codbem)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", codbem));

            try
            {
                dt = GetDataTable("sp_equipamentolist", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }

        public static DataTable Sp_EquipamentoDetails(string cod)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", cod));

            try
            {
                dt = GetDataTable("sp_equipamentodetails", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public static int Sp_EquipamentoCreate(string equipamento, string descricao, int fornecedor, int tipoaquisicao, int tipoequipamento, string observacao, DateTime datamov, int usuario, ref Dictionary<string, MySqlParameter> parOut)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            MySqlParameter paramOut = new MySqlParameter();
            int qtd = 0;

            paramOut.ParameterName = "p_idhistorico";
            paramOut.Direction = ParameterDirection.Output;
            paramOut.DbType = DbType.Int32;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", equipamento));
            pars.Add("p_descricao", new MySqlParameter("p_descricao", descricao));
            pars.Add("p_idfornecedor", new MySqlParameter("p_idfornecedor", fornecedor));
            pars.Add("p_idtipoaquisicao", new MySqlParameter("p_idtipoaquisicao", tipoaquisicao));
            pars.Add("p_idtipoequipamento", new MySqlParameter("p_idtipoequipamento", tipoequipamento));
            pars.Add("p_observacao", new MySqlParameter("p_observacao", observacao));
            pars.Add("p_datamov", new MySqlParameter("p_datamov", datamov));
            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", usuario));
            pars.Add("p_idhistorico", paramOut);

            try
            {
                qtd = Execute("sp_equipamentocreate", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

        public static int Sp_EquipamentoEdit(string equipamento, string descricao, int fornecedor, int tipoaquisicao, int tipoequipamento, string observacao, int departamento)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            Dictionary<string, MySqlParameter> parOut = new Dictionary<string, MySqlParameter>();
            int qtd = 0;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", equipamento));
            pars.Add("p_descricao", new MySqlParameter("p_descricao", descricao));
            pars.Add("p_idfornecedor", new MySqlParameter("p_idfornecedor", fornecedor));
            pars.Add("p_idtipoaquisicao", new MySqlParameter("p_idtipoaquisicao", tipoaquisicao));
            pars.Add("p_idtipoequipamento", new MySqlParameter("p_idtipoequipamento", tipoequipamento));
            pars.Add("p_observacao", new MySqlParameter("p_observacao", observacao));

            try
            {
                qtd = Execute("sp_equipamentoedit", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

        public static int Sp_EquipamentoAlocar(string equipamento, int usuario, int departamento, DateTime datamov, ref Dictionary<string, MySqlParameter> parOut)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            MySqlParameter paramOut = new MySqlParameter();
            int qtd = 0;

            paramOut.ParameterName = "p_idhistorico";
            paramOut.Direction = ParameterDirection.Output;
            paramOut.DbType = DbType.Int32;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", equipamento));
            pars.Add("p_datamov", new MySqlParameter("p_datamov", datamov));
            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", usuario));
            pars.Add("p_iddepartamento", new MySqlParameter("p_iddepartamento", departamento));
            pars.Add("p_idhistorico", paramOut);

            try
            {
                qtd = Execute("sp_equipamentoalocar", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

        public static int Sp_EquipamentoRemover(string equipamento, int usuario, DateTime datamov, ref Dictionary<string, MySqlParameter> parOut)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            MySqlParameter paramOut = new MySqlParameter();
            int qtd = 0;

            paramOut.ParameterName = "p_idhistorico";
            paramOut.Direction = ParameterDirection.Output;
            paramOut.DbType = DbType.Int32;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", equipamento));
            pars.Add("p_datamov", new MySqlParameter("p_datamov", datamov));
            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", usuario));
            pars.Add("p_idhistorico", paramOut);

            try
            {
                qtd = Execute("sp_equipamentoremover", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

        public static int Sp_EquipamentoBaixa(string equipamento, int usuario, DateTime datamov, ref Dictionary<string, MySqlParameter> parOut)
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            MySqlParameter paramOut = new MySqlParameter();
            int qtd = 0;

            paramOut.ParameterName = "p_idhistorico";
            paramOut.Direction = ParameterDirection.Output;
            paramOut.DbType = DbType.Int32;

            pars.Add("p_codigobem", new MySqlParameter("p_codigobem", equipamento));
            pars.Add("p_datamov", new MySqlParameter("p_datamov", datamov));
            pars.Add("p_idusuario", new MySqlParameter("p_idusuario", usuario));
            pars.Add("p_idhistorico", paramOut);

            try
            {
                qtd = Execute("sp_equipamentobaixa", CommandType.StoredProcedure, pars, ref parOut);
            }
            catch (Exception)
            {

                throw;
            }

            return qtd;
        }

        public static DataTable Sp_EquipamentoListBaixado()
        {
            Dictionary<string, MySqlParameter> pars = new Dictionary<string, MySqlParameter>();
            DataTable dt;

            try
            {
                dt = GetDataTable("sp_equipamentolistbaixado", CommandType.StoredProcedure, pars);

            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
    }
}
