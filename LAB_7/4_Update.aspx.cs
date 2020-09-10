using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_4
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Panel1.Visible = false;
                RecordUpdated.Visible = false;
            }
        }

        protected void FetchRecord_Click(object sender, EventArgs e)
        {
            StudentDataContext db = new StudentDataContext();
            Student s = new Student();
            Panel1.Visible = true;
            RecordUpdated.Visible = true;
            int id = Int32.Parse(student_id.Text);
            s = db.Students.SingleOrDefault(x => x.sid == id);

            name.Text = s.name;
            sem.Text = s.sem.ToString();
            cpi.Text = s.cpi.ToString();
            mob.Text = s.contactno.ToString();
            email.Text = s.email;
            
        }

        protected void RecordUpdated_Click(object sender, EventArgs e)
        {
            StudentDataContext db = new StudentDataContext();
            Student s = new Student();
            Panel1.Visible = true;
            int id = Int32.Parse(student_id.Text);
            s = db.Students.SingleOrDefault(x => x.sid == id);
            s.name = name.Text;
            s.sem = int.Parse(sem.Text);
            s.cpi = float.Parse(cpi.Text);
            s.contactno = long.Parse(mob.Text);
            s.email = email.Text;
            db.SubmitChanges();
           
            Label2.Text = "Record Updated Successfully";
            Label2.ForeColor = System.Drawing.Color.Green;
        }
    }
}