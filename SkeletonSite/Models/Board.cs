using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkeletonSite.Models
{
    public class Board
    {
        public static List<Story> stories = new List<Story>();

        public static IEnumerable<Story> Bank
        {
            get
            {
                stories.Sort((title1, title2) => title1.Title.CompareTo(title2.Title));
                return stories;
            }
        }

        public static void AddStory(Story story)
        {
                stories.Add(story);
        }
    }
}
