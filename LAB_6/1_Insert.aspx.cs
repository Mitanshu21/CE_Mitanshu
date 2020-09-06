using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            

            SqlCommand command = new SqlCommand();
            command.Connection = con;

            con.Open();
            command.CommandText = "select * from Student";
            SqlDataReader dr = command.ExecuteReader();

            

            con.Close();

            command.CommandText = @"insert into Student values(@id,@name,@sem,@mob_no,@email_id)";
            command.Parameters.AddWithValue("@id", TextBox0.Text.ToString());
            command.Parameters.AddWithValue("@name", TextBox1.Text.ToString());
            command.Parameters.AddWithValue("@sem", DropDownList1.SelectedValue);
            command.Parameters.AddWithValue("@mob_no", TextBox2.Text.ToString());
            command.Parameters.AddWithValue("@email_id", TextBox3.Text.ToString());


            con.Open();
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                
                Label1.Text = "data is inserted <br/>   " + n + " rows inserted";
                Label1.Visible = true;
                //Response.Write("<script>alert('Student record is inserted with Id : " + id +"') </script>");
            }
            else
            {
                Label1.Text = "Failed to Insert";
                Label1.Visible = true;
            }

            con.Close();
        }


    }
}