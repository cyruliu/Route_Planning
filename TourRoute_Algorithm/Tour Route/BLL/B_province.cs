using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.Model;
using System.Data;
using System.Data.SqlClient;
using Tour_Route.DAL;

namespace Tour_Route.BLL
{
    public class B_province
    {
        //得到hotdegree前n项的省信息
       public static IList<M_province> GetProTopN(int n)
       {
           try
           {
               return D_province.GetProTopN(n);
           }
           catch (Exception exp)
           {

               throw new Exception(exp.Message.ToString());
           }

       }

        //得到所有省的信息
       public static IList<M_province> GetAllPro()
       {
           try
           {
               return D_province.GetAllPro();
           }
           catch (Exception exp)
           {

               throw new Exception(exp.Message.ToString());
           }
      
       }
    }
}