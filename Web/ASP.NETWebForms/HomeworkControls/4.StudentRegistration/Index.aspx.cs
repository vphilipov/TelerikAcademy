using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4.StudentRegistration
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string firstName = this.FirstName.Text;
            string lastName = this.LastName.Text;
            string facNumber = this.FacNumber.Text;
            string uni = this.UniversitySelect.SelectedItem.Text;
            string speciality = this.SpecialitySelect.SelectedItem.Text;
            var courseIndices = this.CoursesList.GetSelectedIndices();

            this.Details.Controls.Add(new LiteralControl("<p>Full Name: <strong>" + firstName + " " + lastName + "</strong><p/>"));
            this.Details.Controls.Add(new LiteralControl("<p>Faculty Number: <strong>" + facNumber + "</strong></p>"));
            this.Details.Controls.Add(new LiteralControl("<p>University: <strong>" + uni + "</strong></p>"));
            this.Details.Controls.Add(new LiteralControl("<p>Speciality: <strong>" + speciality + "</strong></p>"));

            string[] courseNames = new string[courseIndices.Length];
            for (int i = 0; i < courseIndices.Length; i++)
            {
                courseNames[i] = this.CoursesList.Items[i].Text;
            }

            string selectedCourses = string.Join(", ", courseNames);
            Console.WriteLine();

            this.Details.Controls.Add(new LiteralControl("<p>Courses: <strong>" + selectedCourses + "</strong></p>"));
        }
    }
}