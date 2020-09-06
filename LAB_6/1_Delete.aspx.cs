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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            if (btnEdit.Text.ToString().ToLower().Equals("search"))
            {
                con.Open();
                command.CommandText = "select * from Student where id = @id";
                command.Parameters.AddWithValue("@id", int.Parse(TextBox4.Text));

                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    TextBox1.Text = dr.GetString(1).ToString();
                    DropDownList1.SelectedValue = dr.GetInt32(2).ToString();
                    TextBox2.Text = dr.GetDecimal(3).ToString();
                    TextBox3.Text = dr.GetString(4).ToString();
                    btnEdit.Text = "Delete";

                    TextBox1.Enabled = true;
                    TextBox2.Enabled = true;
                    TextBox3.Enabled = true;
                    TextBox4.Enabled = false;
                    DropDownList1.Enabled = true;

                }
                else
                {
                    Label1.Text = "Student does not exist";
                    Label1.Visible = true;
                }

                con.Close();
            }
            else if (btnEdit.Text.ToString().ToLower().Equals("delete"))
            {
                Label1.Visible = true;
                TextBox4.Enabled = false;

                con.Open();
                command.CommandText = "Delete from  student where id = @id";
                command.Parameters.AddWithValue("@id", int.Parse(TextBox4.Text));

                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    Label1.Text = n + " row deleteded.";
                    btnEdit.Text = "Search";


                    TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
                    DropDownList1.ClearSelection();
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                    TextBox3.Enabled = false;
                    TextBox4.Enabled = true;
                    DropDownList1.Enabled = false;

                }
                else
                {
                    Label1.Text = "Student does not exist";
                }
                con.Close();
            }
        }
    }
}