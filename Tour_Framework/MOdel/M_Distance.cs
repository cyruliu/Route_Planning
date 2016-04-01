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
    public class M_Distance
    {
        private int d_ID;

        public int D_ID
        {
            get { return d_ID; }
            set { d_ID = value; }
        }
        private string d_time;

        public string D_time
        {
            get { return d_time; }
            set { d_time = value; }
        }
        private string d_Scence1;

        public string D_Scence1
        {
            get { return d_Scence1; }
            set { d_Scence1 = value; }
        }
        private string d_Scence2;

        public string D_Scence2
        {
            get { return d_Scence2; }
            set { d_Scence2 = value; }
        }

        public M_Distance()
        {
 
        }

        public M_Distance(int did, string dtime, string dscence1, string dscence2)
        {
            this.D_ID = did;
            this.D_time = dtime;
            this.d_Scence1 = dscence1;
            this.D_Scence2 = dscence2;
        }
    }
}
