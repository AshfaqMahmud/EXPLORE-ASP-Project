using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXPLORE.Account
{
    public partial class userLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from info where email='" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('" + dr.GetValue(1).ToString() + "');</script>");
                        Session["fullname"] = dr.GetValue(1).ToString();                    
                        Session["role"] = "user";
                        //HttpCookie cookie = new HttpCookie("UserDetails");
                        //cookie["Name"] = dr.GetValue(2).ToString();
                        //cookie["Email"] = TextBox2.Text;
                        // Cookie will be persisted for 30 days
                        //cookie.Expires = DateTime.Now.AddDays(30);
                        // Add the cookie to the client machine
                        //Response.Cookies.Add(cookie);

                    }
                    Response.Redirect("Home.aspx");
                }
                else if(TextBox1.Text.ToString()=="admin" && TextBox2.Text.ToString() == "admin")
                {
                    Session["fullname"] = "Admin";
                    Session["role"] = "admin";
                    Response.Redirect("AdminPanel.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

            }
            catch (Exception)
            {

            }
        }
    }
}