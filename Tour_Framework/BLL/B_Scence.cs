/*
 *作    者:     龙军
 *创作时间：    2013/3/13 12:57
 *修改时间：
 *备    注：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MOdel;
using DAL;


namespace BLL
{
    public class B_Scence
    {
        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static List<M_Scence> B_SALL(int cid)
        {

            return D_Scence.D_SAll(cid);

        }
        #endregion
        #region  查询总数
        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int B_SCount()
        {
            return D_Scence.D_SCount();
        }
        #endregion

        #region 增加，删除，修改
        /// <summary>
        /// 增加，返回值为true则表示添加成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static bool B_SAdd(M_Scence MD)
        {
            return D_Scence.D_SAdd(MD);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void B_SDelete(M_Scence MD)
        {
            D_Scence.D_SDelete(MD);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void B_SAlter(M_Scence MD)
        {
            D_Scence.D_SAlter(MD);
        }
        #endregion
    }
}
