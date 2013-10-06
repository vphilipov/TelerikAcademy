using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tweeter.Models
{
    public class Tweet
    {
        public Tweet()
        {
            this.Tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(140, MinimumLength = 1, ErrorMessage = "Tweet length must be between {2} and {1} symbols!")]
        public string Text { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime DateTweeted { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
