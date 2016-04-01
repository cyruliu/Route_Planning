/*
 *作    者:     龙军
 *创作时间：    2013/3/5 20:43
 *修改时间：    2013/3/12 15:41
 *备    注：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOdel
{
    /// <summary>
    /// 将T_Scence表中的列封装成相应的类
    /// 相应的列名对应相应的字段名字
    /// 这样做后每一条记录就保存在每一个 new 后的类中
    /// </summary>
    public class M_Scence
    {
        public M_Scence()
        {
 
        }
        private int s_ID;

        public int S_ID
        {
            get { return s_ID; }
            set { s_ID = value; }
        }

        private int c_ID;

        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }

        private string s_name;

        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }

        private int u_ID;

        public int U_ID
        {
            get { return u_ID; }
            set { u_ID = value; }
        }

        private string s_like;

        public string S_like
        {
            get { return s_like; }
            set { s_like = value; }
        }
        public M_Scence(int sid, string sname, int cid, int uid, string slike)
        {
            this.C_ID = cid;
            this.S_ID = sid;
            this.S_name = sname;
            this.S_like = slike;
            this.U_ID = uid;
        }
    }
}
