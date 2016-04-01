/*
 *作    者:     龙军
 *创作时间：    2013/3/12 15:43
 *修改时间：
 *备    注：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOdel
{
    public  class M_User
    {
        private int u_ID;

        public int U_ID
        {
            get { return u_ID; }
            set { u_ID = value; }
        }

        private string u_name;

        public string U_name
        {
            get { return u_name; }
            set { u_name = value; }
        }

        private string u_Secret;

        public string U_Secret
        {
            get { return u_Secret; }
            set { u_Secret = value; }
        }
        public M_User()
        {
 
        }

        public M_User(int uid, string uname, string usecret)
        {
            this.U_ID = uid;
            this.U_name = uname;
            this.U_Secret = usecret;
        }
    }
}
