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
    /// <summary>
    /// 将T_Province表中的列封装成相应的类
    /// 相应的列名对应相应的字段名字
    /// 这样做后每一条记录就保存在每一个 new 后的类中
    /// </summary>
    public class M_Province
    {
        private int p_ID;

        public int P_ID
        {
            get { return p_ID; }
            set { p_ID = value; }
        }
        private string p_name;

        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }

        public M_Province()
        { 
        }

        public M_Province(int pid, string pname)
        {
            this.P_ID = pid;
            this.P_name = pname;
        }
    }
}
