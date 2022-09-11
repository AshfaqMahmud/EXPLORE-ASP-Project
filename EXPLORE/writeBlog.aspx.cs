using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EXPLORE
{
    public partial class writeBlog : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(!Page.IsPostBack)
            {
                
                blogCat.Items.Insert(0, "--Select Category");
            }*/

        }

    
        protected void Button1_Click1(object sender, EventArgs e)
        {

            /// string dateNow = DateTime.Now.ToString();
            String dateNow = "Ashfaq";

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //String query = "INSERT INTO blog (bTitle,bCategory,bDesc,bUrl,bDate) values (@blogtitle,@blogcat,@blogdesc,@blogurl,@datenow)";
                SqlCommand sqlcomm = new SqlCommand("INSERT INTO blog (bTitle,bCategory,bDesc,bUrl,bDate) values (@blogtitle,@blogcat,@blogdesc,@blogurl,@datenow)", con);
                sqlcomm.Parameters.AddWithValue("@blogtitle", blogTitle.Text);
                sqlcomm.Parameters.AddWithValue("@blogcat", blogCat.SelectedItem.Text.ToString());
                sqlcomm.Parameters.AddWithValue("@blogdesc", blogDesc.Text.Trim());
                sqlcomm.Parameters.AddWithValue("@blogurl", "--");
                sqlcomm.Parameters.AddWithValue("@datenow", dateNow);
                //Response.Write("<script>alert('Post added to queue, wait for approval');</script>");
                sqlcomm.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Home.aspx");
               // Response.Write("<script>alert('Post added to queue, wait for approval');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}