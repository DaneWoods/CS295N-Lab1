using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkeletonSite.Models
{
    public class Story
    {
        [Required(ErrorMessage = "Please input the creator of the story")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input Some text for your story")]
        public string Text { get; set; }
    }
}
