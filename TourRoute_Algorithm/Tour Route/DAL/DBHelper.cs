using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tour_Route.DAL
{
    public class DBHelper
    {
          //数据库连接对象conn
        public static SqlConnection Connection()
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
            string connectionString = @"Data Source=.\SQLEXPRESS;
                    AttachDBFilename=|DataDirectory|\db_selectScene.mdf;
                    Integrated Security=True;
                    User Instance=True";
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            else if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            else if (conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
            return conn;

        }

        //返回受影响行数n,没有成功执行或数据库返回值为空，则返回-1;
        public static int ExecuteCommand(string strsql)
        {
            SqlConnection conn = Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            int result = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    
        //带参数
        public static int ExecuteCommand(string strsql,params SqlParameter[] values)
        {
            SqlConnection conn = Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            //cmd.Parameters.Add(values);
            foreach (var v in values)
            {
                cmd.Parameters.Add(v);
            }
            int result = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        //执行SQL语句，返回查询结果中的第一行第一列
        public static int GetScalar(string strsql)
        {
            SqlCommand cmd = new SqlCommand(strsql, Connection());
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        //执行SQL语句，返回SqlDataReader对象
        public static SqlDataReader GetReader(string strsql)
        {
                using (SqlCommand cmd = new SqlCommand(strsql,Connection()))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                   
                    return reader;
                } 
               
            } 
            
    

        public static SqlDataReader GetReader(string strsql,params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(strsql, Connection());
            //cmd.Parameters.Add(values);
            foreach (var v in values)
            {
                cmd.Parameters.Add(v);
            }
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        //执行SQL语句，返回DataTable对象
        public static DataTable GetDataSet(string strsql)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static DataTable GetDataSet(string strsql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(strsql, Connection());
            //cmd.Parameters.Add(values);
            foreach (var v in values)
            {
                cmd.Parameters.Add(v);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}