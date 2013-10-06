using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Tweeter.Models
{
    public class ApplicationUser : User
    {
        private ICollection<Tweet> tweets;

        public ApplicationUser()
        {
            this.Roles = new HashSet<UserRole>();
            this.tweets = new HashSet<Tweet>();
        }

        public virtual ICollection<Tweet> Tweets
        {
            get { return this.tweets; }
            set { this.tweets = value; }
        }
    }
}
