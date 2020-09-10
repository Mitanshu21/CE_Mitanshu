using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_4
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleterRecord_Click(object sender, EventArgs e)
        {
            StudentDataContext db = new StudentDataContext();
            Student s = new Student();
            s = db.Students.Single(x => x.sid == Int32.Parse(id.Text));
            db.Students.DeleteOnSubmit(s);
            db.SubmitChanges();
            Label1.Text = "Record Deleted Successfully";
        }
    }
}