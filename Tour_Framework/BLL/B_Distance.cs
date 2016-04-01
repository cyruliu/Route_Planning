using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MOdel;
using DAL;

namespace BLL
{
    class B_Distance
    {
        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static List<M_Distance> B_DALL(string scence1, string scence2)
        {

            return D_Distance.D_DAll(scence1, scence2);

        }
        #endregion
        #region  查询总数
        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int B_DCount()
        {
            return D_Distance.D_DCount();
        }
        #endregion
       
        #region 增加，删除，修改
        /// <summary>
        /// 增加，返回值为true则表示添加成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static bool B_DAdd(M_Distance MD)
        {
            return D_Distance.D_DAdd(MD);
        }

         /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void B_DDelete( M_Distance MD)
        {
            D_Distance.D_DDelete(MD);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void B_DAlter(M_Distance MD)
        {
            D_Distance.D_DAlter(MD);
        }
        #endregion
    }
}
