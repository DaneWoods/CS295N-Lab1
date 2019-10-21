using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkeletonSite.Models
{
    public class Story
    {
        private List<string> subjects = new List<string>();
        [Required(ErrorMessage = "Please input a title for your story")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please input some text for your story")]
        public string Text { get; set; }

        public List<string> Subjects { get { return subjects; } }
    }
}
