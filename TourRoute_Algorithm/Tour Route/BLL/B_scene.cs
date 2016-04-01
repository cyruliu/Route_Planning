using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.Model;
using Tour_Route.DAL;
using System.Data;

namespace Tour_Route.BLL
{
    public class B_scene
    {
        //IList<M_scene> top n项景点信息
        public static IList<M_scene> GetScenelistTopN(int n)
        {
            try
            {
                return D_scene.GetScenelist(n);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
 
        }

        //DataTable 排名前n项的景点信息
        public static DataTable GetSceneTopN(int n)
        {
            try
            {
                return D_scene.GetSceneTopN(n);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }

        //由景点名得到景点信息
        public static M_scene GetSceneByName(string scenename)
        {
            try
            {
                return D_scene.GetSceneByName(scenename);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }

        //判断是否存在指定城市，若存在，得到该景点top n项景点信息；若不存在，则返回所有景点top n信息
        public static IList<M_scene> GetScenelistTopNByCityName(string name, int n)
        {
            try
            {
                return D_scene.GetScenelistTopNByCityName(name, n);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }

        //由省得到景点的top n信息
        public static IList<M_scene> GetScenelistTopNByProvince(string pro, int n)
        {
            try
            {
                return D_scene.GetScenelistTopNByProvince(pro,n);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }

        public static DataTable GetSceneTopNPicByPro(string proname, int n)
        {
            try
            {
                return D_scene.GetSceneTopNPicByPro(proname,n);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }
    }
}