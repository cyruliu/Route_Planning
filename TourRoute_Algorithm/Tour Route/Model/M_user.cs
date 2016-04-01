using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tour_Route.Model
{
    public class M_user
    {
        private int uID;

        public int UID
        {
            get { return uID; }
            set { uID = value; }
        }
        private string u_Name;

        public string U_Name
        {
            get { return u_Name; }
            set { u_Name = value; }
        }
        private string u_Pwd;

        public string U_Pwd
        {
            get { return u_Pwd; }
            set { u_Pwd = value; }
        }
        private int u_Level;

        public int U_Level
        {
            get { return u_Level; }
            set { u_Level = value; }
        }

    }
}