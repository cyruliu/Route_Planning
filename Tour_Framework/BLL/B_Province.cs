/*
 *作    者:     龙军
 *创作时间：    2013/3/5 20:43
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
    public class B_Province
    {
        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static List<M_Province> B_pro()
        {

            return D_Province.D_pro();

        }
        #endregion
        #region  查询总数
        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int B_PCount()
        {
            return D_Province.D_PCount();
        }
        #endregion
       
    }
}
