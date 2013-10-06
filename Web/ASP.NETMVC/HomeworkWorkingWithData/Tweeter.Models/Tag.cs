using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tweeter.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Tweets = new HashSet<Tweet>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "Tag length must be between {2} and {1} symbols!")]
        public string Name { get; set; }

        public virtual ICollection<Tweet> Tweets { get; set; }
    }
}
