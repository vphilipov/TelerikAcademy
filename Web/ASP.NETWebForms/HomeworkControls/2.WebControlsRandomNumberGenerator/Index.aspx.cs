using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.WebControlsRandomNumberGenerator
{
    public partial class Index : System.Web.UI.Page
    {
        private Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Random_Click(object sender, EventArgs e)
        {
            int from = int.Parse(this.From.Text);
            int to = int.Parse(this.To.Text);
            int result = rand.Next(from, to);
            this.Result.Text = result.ToString();
        }
    }
}