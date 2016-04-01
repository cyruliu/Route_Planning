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

namespace MOdel
{
    public class M_City
    {
        /// <summary>
        /// 将T_City表中的列封装成相应的类
        /// 相应的列名对应相应的字段名字
        /// 这样做后每一条记录就保存在每一个 new 后的类中
        /// </summary>
         public M_City()
        {
 
        }
        private int p_ID;

        public int P_ID
        {
            get { return p_ID; }
            set { p_ID = value; }
        }

        private int c_ID;

        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }

        private string c_name;

        public string C_name
        {
            get { return c_name; }
            set { c_name = value; }
        }

        public M_City(int pid, string cname, int cid)
        {
            this.C_ID = cid;
            this.P_ID = pid;
            this.C_name = cname;
        }
    }
}
