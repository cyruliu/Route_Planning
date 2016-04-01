using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tourist_attractions
{
    public partial class Common : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFormTheBestWay_Click(object sender, EventArgs e)
        {
                Response.Redirect("~/FormTheBestWay.aspx");
             
        }

        protected void btnWantToGo_Click(object sender, EventArgs e)
        {
                Response.Redirect("~/WantToGo.aspx");
           
            
        }

        protected void btnScenePics_Click(object sender, EventArgs e)
        {
           
                Response.Redirect("~/ScenePics.aspx"); 
           
        }

        protected void btnDefault_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("~/Default.aspx");
           
           
        }
       

       
    }
}