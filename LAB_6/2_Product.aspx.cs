using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class product : System.Web.UI.Page
    {
        string item;
        float cost;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!Session.IsNewSession)
                {


                    if ((bool)Session["isActive"])
                    {

                    }
                    else
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Visible = false;
            GridViewRow gvr = GridView2.SelectedRow;


            item = gvr.Cells[2].Text.ToString();
            cost = float.Parse(gvr.Cells[4].Text);

            if (ListBox1.Items.FindByValue(item) == null)
            {
                ListBox1.Items.Add(item);

                ListBox2.Items.Add(gvr.Cells[1].Text.ToString());
                txtCost.Text = (cost + float.Parse(txtCost.Text.ToString())).ToString();

                ListBox1.Visible = true;
            }
            else
            {
                Label1.Text = "Product is already added";
                Label1.Visible = true;
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            if (ListBox2.Items.Count != 0)
            {
                string user = Session["user"].ToString();
                string conString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                foreach (var item in ListBox2.Items)
                {
                    /*Response.Write(userid.ToString());*/
                    cmd.CommandText = "insert into [Order] values('" + user.ToString() + "', '" + item.ToString() + " ')";

                    
                }
                con.Close();

                Session["amount"] = txtCost.Text.ToString();
                Session["cart"] = ListBox1;

                Response.Redirect("2_Order.aspx");
            }
            else
            {
                string alert = "<script>alert('Select Atleast one product');</script>";
                Response.Write(alert);
            }
        }
    }
}