using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.RandomNumberGenerator
{
    public partial class Index : System.Web.UI.Page
    {
        private Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Random_ServerClick(object sender, EventArgs e)
        {
            int from = int.Parse(this.From.Value);
            int to = int.Parse(this.To.Value);
            int result = rand.Next(from, to);
            this.Result.InnerText = result.ToString();
        }
    }
}