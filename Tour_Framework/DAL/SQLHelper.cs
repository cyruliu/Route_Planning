/*
 *作    者:     龙军
 *创作时间：    2013/3/5 20:43
 *修改时间：
 *备    注：
 */

using System;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {

        public static string strconn = @"Data Source=Alan-PC\SQLEXPRESS;Initial Catalog=path;Integrated Security=True";    //联接数据库字符串


        /// 构造SqlCommand对象
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn,  string cmdText)
        {
            if (conn.State != ConnectionState.Open) conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandTimeout = 600;


        }
        #region 简单的sql命令的执行
        /// <summary>
        /// 简单的sql命令的执行如：增，删，改
        /// </summary>
        /// <param name="sql">命令语句</param>
        /// <param name="sp">参数</param>
        public void databasic(string sql, SqlParameter[] sp)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = strconn;
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter spt in sp)
                    {
                        cmd.Parameters.Add(spt);
                    }
                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion

        #region  返回查询的数据总数量
        /// <summary>
        /// 返回查询的数据总数量
        /// </summary>
        /// <param name="sql">命令语句</param>
        /// <returns>返回值</returns>
        public int returnCount(string sql, SqlParameter[] sp)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter spt in sp)
                    {
                        cmd.Parameters.Add(spt);
                    }
                    i = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return i;
        }
        #endregion

        #region 根据相应的sql命令返回表中的记录
        /// <summary>
        /// 根据相应的sql命令返回表中的记录
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public SqlDataReader returnReader(string sql, SqlConnection myconn)
        {

            myconn.ConnectionString = strconn;
            SqlCommand cmd = myconn.CreateCommand();
            cmd.CommandText = sql;
            myconn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader myreader = cmd.ExecuteReader();

            return myreader;
        }
        #endregion
        public DataSet returnDataSet(string sql)
        {
            DataSet myset = new DataSet();
            using (SqlConnection myconn = new SqlConnection())
            {
                myconn.ConnectionString = strconn;
                myconn.Open();
                using (SqlCommand cmd = myconn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter myAdapt = new SqlDataAdapter(cmd);
                    
                    myAdapt.Fill(myset, "DataList");
                  
                }
            }
            return myset;
        }
        public DataTable returnDataTable(string sql)
        {
            using (SqlConnection myconn = new SqlConnection())
            {
                return returnDataSet(sql).Tables[0];
            }
        }
    }
}
