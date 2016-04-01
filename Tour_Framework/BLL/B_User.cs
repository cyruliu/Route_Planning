using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MOdel;
using DAL;
namespace BLL
{
    public class B_User
    {
        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static List<M_User> B_UAll()
        {

            return D_User.D_UAll();

        }
        #endregion

        #region 登陆
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="MD"></param>
        /// <returns></returns>
        public static bool B_URecord(M_User MD)
        {
            return D_User.D_Urecord(MD);
        }
        #endregion

        #region  查询总数
        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int B_UCount()
        {
            return D_User.D_UCount();
        }
        #endregion

        #region 增加，删除，修改
        /// <summary>
        /// 增加，返回值为true则表示添加成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static bool B_UAdd(M_User MD)
        {
            return D_User.D_UAdd(MD);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void B_UDelete(M_User MD)
        {
            D_User.D_UDelete(MD);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void B_DAlter(M_User MD)
        {
            D_User.D_UAlter(MD);
        }
        #endregion
    }
}
