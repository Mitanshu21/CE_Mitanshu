using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "select * from Student";


            SqlDataReader dr = command.ExecuteReader();

            if (dr.HasRows)
            {


                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();
            }
            else
            {
                Response.Write("<Script>alert('Records not found')</script>");
            }


            con.Close();

        }


    }
}