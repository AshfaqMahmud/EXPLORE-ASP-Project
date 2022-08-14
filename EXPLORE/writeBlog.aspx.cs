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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                CurrentDate.Text = DateTime.Now.ToString();
                blogCat.Items.Insert(0, "--Select Category");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            string dateNow = DateTime.Now.ToString();
            SqlConnection conn = new SqlConnection();
            String query = "insert into [dbo].[blog] (bTitle,bCategory,bDesc,bUrl,bDate) values (@blogtitle,@blogcat,@blogdesc,@blogurl,@datenow)";
            conn.Open();
            SqlCommand sqlcomm = new SqlCommand(query, conn);
            sqlcomm.Parameters.AddWithValue("@blogtitle", blogTitle.Text);
            sqlcomm.Parameters.AddWithValue("@blogcat", blogCat.SelectedItem.Text.ToString());
            sqlcomm.Parameters.AddWithValue("@blogdesc", blogDesc.Text);
            sqlcomm.Parameters.AddWithValue("@blogurl", "--");
            sqlcomm.Parameters.AddWithValue("@datenow", dateNow);
            Response.Write("<script>alert('Post added to queue, wait for approval');</script>");
            sqlcomm.ExecuteNonQuery();
            conn.Close();
        }
    }
}