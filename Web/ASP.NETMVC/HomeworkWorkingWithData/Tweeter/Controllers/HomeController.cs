using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Tweeter.Data;
using Tweeter.Models;
using Tweeter.ViewModels;

namespace Tweeter.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
            : base(new UowData())
        {
        }

        public HomeController(IUowData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            this.Data.Tweets.All();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult UserPage()
        {
            var user = this.Data.Users.GetById(User.Identity.GetUserId());

            var userTweets = user.Tweets
                                 .Select(t => new TweetViewModel()
                                    {
                                        DateTweeted = t.DateTweeted,
                                        Text = t.Text,
                                        Author = t.User.UserName
                                    })
                                 .OrderByDescending(t => t.DateTweeted)
                                 .ToList();

            return View(userTweets);
        }

        [HttpPost]
        [Authorize]
        public ActionResult CreateTweet(TweetViewModel tweet)
        {
            var user = this.Data.Users.GetById(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {

                ModelState.AddModelError("CustomError",
                    "Tweet length must be between 1 and 140 symbols!");
            }
            else
            {
                Tweet entity = new Tweet()
                {
                    DateTweeted = DateTime.Now,
                    Text = tweet.Text,
                    User = user
                };

                this.Data.Tweets.Add(entity);

                var tags = Regex.Matches(tweet.Text, @"((?:#){1}[\w\d]{1,140})");

                foreach (object tag in tags)
                {
                    string tagAsString = tag.ToString();

                    Tag newTag = this.Data.Tags.All().FirstOrDefault(t => t.Name == tagAsString);

                    if (newTag == null)
                    {
                        newTag = new Tag()
                        {
                            Name = tagAsString
                        };
                    }

                    entity.Tags.Add(newTag);
                }

                this.Data.SaveChanges();
            }

            var tweets = user.Tweets
                                 .Select(t => new TweetViewModel()
                                 {
                                     DateTweeted = t.DateTweeted,
                                     Text = t.Text,
                                     Author = t.User.UserName
                                 })
                                 .OrderByDescending(t => t.DateTweeted)
                                 .ToList();

            return PartialView("_TweetPartial", tweets);
        }

        [Authorize]
        public ActionResult Search(string query)
        {
            var tag = this.Data.Tags.All().FirstOrDefault(t => t.Name == query);

            if (tag == null)
            {
                return Content("No Results");
            }

            var tweets = tag.Tweets.Select(t => new TweetViewModel()
                                  {
                                      DateTweeted = t.DateTweeted,
                                      Text = t.Text,
                                      Author = t.User.UserName
                                  })
                                 .OrderByDescending(t => t.DateTweeted)
                                  .ToList();

            return PartialView("_TweetPartial", tweets);
        }
    }
}