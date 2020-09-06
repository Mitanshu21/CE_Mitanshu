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
    public partial class Edit : System.Web.UI.Page
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
                    btnEdit.Text = "Edit";

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
            else if (btnEdit.Text.ToString().ToLower().Equals("edit"))
            {
                Label1.Visible = true;
                TextBox4.Enabled = false;

                con.Open();
                command.CommandText = "update student set name=@name,sem=@sem,number=@number,email=@email where id = @id";
                command.Parameters.AddWithValue("@id", int.Parse(TextBox4.Text));
                command.Parameters.AddWithValue("@name", TextBox1.Text);
                command.Parameters.AddWithValue("@sem", int.Parse(DropDownList1.SelectedValue));
                command.Parameters.AddWithValue("@mob_num", TextBox2.Text);
                command.Parameters.AddWithValue("@email_id", TextBox3.Text);

                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    Label1.Text = n + " row updated.";
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