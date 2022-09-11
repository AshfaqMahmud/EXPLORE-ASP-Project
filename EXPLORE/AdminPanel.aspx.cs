using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;

namespace EXPLORE
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            try
            {

                SqlConnection conn = new SqlConnection(strcon);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String query = "select bId,bTitle,bCategory,bDate,bStatus from blog";
                SqlCommand sqlcomm = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gview.DataSource = dt;
                gview.DataBind();
               
                sqlcomm.ExecuteNonQuery();
                conn.Close();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void gview_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/BlogShow.aspx?" + "ID=" + ((LinkButton)sender).Text);
        }
    }
}