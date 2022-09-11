using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXPLORE
{
    public partial class BlogShow : System.Web.UI.Page
    {
        //string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string postId = Request.QueryString["ID"];

                if (postId == null)
                {
                    Response.Redirect("AdminPanel.aspx");
                }
                string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                try
                {

                    SqlConnection conn = new SqlConnection(strcon);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }


                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        SqlCommand cmd = new SqlCommand("spGetPostDetailsByID", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter parameter = new SqlParameter("@ID", postId);
                        cmd.Parameters.Add(parameter);
                        con.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                postid.Text = rdr["bId"].ToString();
                                title.Text = rdr["bTitle"].ToString();
                                posttime.Text = rdr["bDate"].ToString();
                                postdetails.Text = rdr["bDesc"].ToString();
                                bStatus.Text = rdr["bStatus"].ToString();

                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
        }

        private void sqlConnection(int a)
        {
            string postId = Request.QueryString["ID"];
            int id = int.Parse(postId);
            string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            try
            {
                SqlConnection conn = new SqlConnection(strcon);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if(a==1)
                { 
                    String query = "delete from blog where bId=id";
                    SqlCommand sqlcomm = new SqlCommand(query, conn);

                    Response.Write("<script>alert('Post deleted');</script>");
                    sqlcomm.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("AdminPanel.aspx");
                }
                else if(a==2)
                {
                    String query = "update from blog set bStatus='Aprroved' where bId=id";
                    SqlCommand sqlcomm = new SqlCommand(query, conn);

                    Response.Write("<script>alert('Post Approved');</script>");
                    sqlcomm.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("AdminPanel.aspx");
                }
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        

        protected void DeclineBtn_Click(object sender, EventArgs e)
        {
            sqlConnection(1);
        }

        protected void ApproveBtn_Click(object sender, EventArgs e)
        {
            sqlConnection(2);
        }
    }
}