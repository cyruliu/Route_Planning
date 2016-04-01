using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tour_Route.Model
{
    public class M_scene
    {
        private int sID;

        public int SID
        {
            get { return sID; }
            set { sID = value; }
        }
        private string s_Name;

        public string S_Name
        {
            get { return s_Name; }
            set { s_Name = value; }
        }
        private string s_BelongCity;

        public string S_BelongCity
        {
            get { return s_BelongCity; }
            set { s_BelongCity = value; }
        }
        private string s_Description;

        public string S_Description
        {
            get { return s_Description; }
            set { s_Description = value; }
        }
        private string s_Image;

        public string S_Image
        {
            get { return s_Image; }
            set { s_Image = value; }
        }
        private string s_Position;

        public string S_Position
        {
            get { return s_Position; }
            set { s_Position = value; }
        }
        private int s_HotDegree;

        public int S_HotDegree
        {
            get { return s_HotDegree; }
            set { s_HotDegree = value; }
        }
        private string s_BelongProvince;

        public string S_BelongProvince
        {
            get { return s_BelongProvince; }
            set { s_BelongProvince = value; }
        }
    }
}