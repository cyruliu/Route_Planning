using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tour_Route.Model
{
    public class M_city
    {
        private int cID;

        public int CID
        {
            get { return cID; }
            set { cID = value; }
        }
        private string c_Name;

        public string C_Name
        {
            get { return c_Name; }
            set { c_Name = value; }
        }
        private string c_BelongProvince;

        public string C_BelongProvince
        {
            get { return c_BelongProvince; }
            set { c_BelongProvince = value; }
        }
        private string c_Description;

        public string C_Description
        {
            get { return c_Description; }
            set { c_Description = value; }
        }
        private string c_Image;

        public string C_Image
        {
            get { return c_Image; }
            set { c_Image = value; }
        }
        private int c_HotDegree;

        public int C_HotDegree
        {
            get { return c_HotDegree; }
            set { c_HotDegree = value; }
        }
      
    }
}