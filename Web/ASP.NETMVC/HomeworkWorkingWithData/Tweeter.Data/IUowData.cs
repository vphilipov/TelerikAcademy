using System;
using Tweeter.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Tweeter.Data
{
    public interface IUowData : IDisposable
    {
        IRepository<Tweet> Tweets { get; }

        IRepository<Tag> Tags { get; }

        IRepository<ApplicationUser> Users { get; }

        IRepository<Role> Roles { get; }

        int SaveChanges();
    }
}
