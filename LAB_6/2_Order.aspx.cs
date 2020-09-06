using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!Session.IsNewSession)
                {

                    ListBox lb = (ListBox)Session["cart"];
                    if ((bool)Session["isActive"])
                    {
                        foreach (var item in lb.Items)
                        {
                            ListBox1.Items.Add(item.ToString());
                        }

                        ListBox1.Visible = true;
                        float cost = float.Parse((string)Session["amount"]);
                        txtCost.Text = cost.ToString();
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

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}