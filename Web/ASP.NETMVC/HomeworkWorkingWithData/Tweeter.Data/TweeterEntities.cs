using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Tweeter.Models;

namespace Tweeter.Data
{
    public class TweeterEntities : IdentityDbContextWithCustomUser<ApplicationUser>
    {
        public virtual IDbSet<Tweet> Tweets { get; set; }

        public virtual IDbSet<Tag> Tags { get; set; }
    }
}
