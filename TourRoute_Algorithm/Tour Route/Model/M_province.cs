using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tour_Route.Model
{
    public class M_province
    {
        private int pID;

        public int PID
        {
            get { return pID; }
            set { pID = value; }
        }
        private string p_Name;

        public string P_Name
        {
            get { return p_Name; }
            set { p_Name = value; }
        }
        private int p_HotDegree;

        public int P_HotDegree
        {
            get { return p_HotDegree; }
            set { p_HotDegree = value; }
        }
    }
}