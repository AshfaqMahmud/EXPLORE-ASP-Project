using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXPLORE
{
    public partial class BlogMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CurrentDate.Text = DateTime.Now.ToString();
            //Timer1.Enabled = true;
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString();

        }
    }
}