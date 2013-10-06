using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tweeter.Models;

namespace Tweeter.ViewModels
{
    public class TweetViewModel
    {
        [Required, StringLength(140, MinimumLength = 1, ErrorMessage = "Tweet length must be between {2} and {1} symbols!")]
        public string Text { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime DateTweeted { get; set; }

        public string Author { get; set; }
    }
}