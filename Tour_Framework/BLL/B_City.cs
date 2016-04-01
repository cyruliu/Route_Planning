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
    public class B_City
    {
        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static List<M_City> BCity(int pid)
        {

            return D_City.DCity(pid);

        }
        #endregion
        #region  查询总数
        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int B_CCount(int pid)
        {
            return D_City.D_CCount(pid);
        }
        #endregion
    }
}
