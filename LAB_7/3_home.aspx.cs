using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.ToString().Trim() != "")
                Response.Redirect("product1.aspx?pid=" + TextBox1.Text.ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllProduct.aspx");
        }
    }
}