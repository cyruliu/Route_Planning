using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.Model;
using Tour_Route.DAL;
using System.Data;

namespace Tour_Route.BLL
{
    public class B_city
    {
        //得到city表中的点击排行的前n项信息
        public static IList<M_city> GetCityTopN(int n)
        {
            try
            {
                return DAL.D_city.GetCityTopN(n);
            }
            catch ( Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }
        public static DataTable GetCityTop(int n)
        {
            try
            {
                return D_city.GetCityTop(n);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
            
        }

     
    }
}