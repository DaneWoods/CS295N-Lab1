using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkeletonSite.Models
{
    public class Story
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
    }
}
