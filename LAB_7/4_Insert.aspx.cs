using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_4
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Record_Click(object sender, EventArgs e)
        {
            StudentDataContext db = new StudentDataContext();
            Student s = new Student();
            s.name = name.Text;
            s.sem = Int32.Parse(sem.Text);
            s.cpi = float.Parse(cpi.Text);
            s.contactno = long.Parse(cno.Text);
            s.email = email.Text;
            db.Students.InsertOnSubmit(s);
            db.SubmitChanges();

            Label1.Text = "Record Inserted Successfully";
            Label1.ForeColor = System.Drawing.Color.Green;
        }
    }
}