using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Err_Label.Visible = false;
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var conString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select * from [User] where userid = @userid ";
            cmd.Parameters.AddWithValue("@userid", txtUsername.Text.ToString());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                if (dr.GetString(1).ToString().Equals(txtPassword.Text.ToString()))
                {
                    Err_Label.Visible = false;
                    Session["user"] = txtUsername.Text;
                    Session["password"] = txtPassword.Text;
                    Session["isActive"] = true;


                    Response.Redirect("2_Product.aspx");
                }
                else
                {
                    Err_Label.Visible = true;
                }
            }
            else
            {
                Err_Label.Visible = true;
            }

            con.Close();

        }
    }
}