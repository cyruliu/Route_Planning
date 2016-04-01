using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MOdel;
using System.Text;

namespace DAL
{
    public class D_User
    {

        #region 登陆
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="MD"></param>
        /// <returns></returns>
        public static bool D_Urecord(M_User MD)
        {
            bool istrue = false;
            string sql = "select count(*) from T_User where U_name=@U_name and U_Secret=@U_Secret";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@U_name", MD.U_name), new SqlParameter("@U_Secret", MD.U_Secret) };
            SQLHelper hr = new SQLHelper();
            if (hr.returnCount(sql,sp) == 1)
            {
                istrue = true;
            }
            return istrue;
        }
        #endregion
        #region 查询所有数据
        /// <summary>
            /// 查询所有数据
            /// </summary>
            public static List<M_User> D_UAll()
            {
                string sql = "select  * from T_User";
                List<M_User> list = new List<M_User>();
                M_User d = new M_User();
                SQLHelper sqlhelpers = new SQLHelper();
                SqlConnection conn = new SqlConnection();
                SqlDataReader dr = sqlhelpers.returnReader(sql, conn);
                while (dr.Read())
                {
                    d = Obj(dr);
                    list.Add(d);
                }

                dr.Close();
                dr.Dispose();
                conn.Close();
                return list;
            }
            #endregion
            #region 查询总条数
            /// <summary>
            /// 查询总条数
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public static int D_UCount()
            {
                int count = 0;
                string sql = "select count(*) from T_User";
                SqlParameter[] sp = { null };
                SQLHelper sh = new SQLHelper();
                count = sh.returnCount(sql,sp);
                return count;

            }
            #endregion
            #region 增加，删除，修改
            /// <summary>
            /// 增加
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="MD"></param>
            public static bool D_UAdd(M_User MD)
            {
                bool istrue = false;
                string sql = "select count(*) from T_User where U_name=@U_name";
                string sql1 = "insert into T_User (U_name, U_Secret) values (@U_name, @U_Secret)";
                SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@U_name", MD.U_name), new SqlParameter("@U_Secret", MD.U_Secret) };
                SQLHelper sh = new SQLHelper();
                if (sh.returnCount(sql,sp) < 1)                                                                                                                                                                                                                                                                                                                                                                                                              
                {
                    sh.databasic(sql1, sp);
                    istrue = true;
                }
                return istrue;
            }
            /// <summary>
            /// 删除
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="MD"></param>
            public static void D_UDelete(M_User MD)
            {

                string sql = "delete  from T_User where U_ID=@U_ID";
                SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@U_ID", MD.U_ID) };
                SQLHelper sh = new SQLHelper();
                sh.databasic(sql, sp);

            }
            /// <summary>
            /// 修改
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="MD"></param>
            public static void D_UAlter(M_User MD)
            {
                string sql1 = "update  T_User set U_name=@U_name,U_secret=@U_Secret where U_ID=@U_ID";

                SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@U_name", MD.U_name), new SqlParameter("@U_Secret", MD.U_Secret) };
                SQLHelper sh = new SQLHelper();
                sh.databasic(sql1, sp);
            }
            #endregion
            #region 构造实体
            /// <summary>
            /// 构造实体
            /// </summary>
            /// <param name="dr">表中的数据集</param>
            /// <returns>返回单条记录</returns>
            public static MOdel.M_User Obj(SqlDataReader dr)
            {
                M_User d = new M_User();

                d.U_ID = Convert.ToInt32(dr["U_ID"]);
                d.U_name = dr["U_name"].ToString();
                d.U_Secret = dr["U_Secret"].ToString();
           
                return d;
            }
            #endregion
        
    }
}
