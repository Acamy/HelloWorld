using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data;

namespace LoginSystem.DAL
{
    /// <summary>
    /// 执行sql语句，返回受影响的行数
    /// </summary>
    public class Sql
    {
        private static readonly string connStr = "Data source=orcl;User=hebh;Password=tyinteplm";
        public static int ExecuteQuery(string sql, params OracleParameter[] pars)
        {
            using (OracleConnection conn=new OracleConnection(connStr))
            {
                using (OracleCommand cmd=new OracleCommand(sql,conn))
                {
                    conn.Open();
                    if (pars!=null)
                    {
                        cmd.Parameters.AddRange(pars); 
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sal"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,params OracleParameter[] pars)
        {
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    conn.Open();
                    if (pars != null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    return cmd.ExecuteOracleScalar();
                }
            }
        }

        /// <summary>
        /// 返回表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql,params OracleParameter[] pars)
        {
            using (OracleConnection conn=new OracleConnection(connStr))
            {
                using (OracleDataAdapter adpter=new OracleDataAdapter(sql,conn))
                {
                    if (pars!=null)
                    {
                        adpter.SelectCommand.Parameters.AddRange(pars);
                    }
                    DataTable dt = new DataTable();
                    adpter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
