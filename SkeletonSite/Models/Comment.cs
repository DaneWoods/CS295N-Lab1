using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SkeletonSite.Models
{
    public class Comment
    {
        [Required(ErrorMessage = "Please input your text for your comment")]
        public string Text { get; set; }
    }
}
