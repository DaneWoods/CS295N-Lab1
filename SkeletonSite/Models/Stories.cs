using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkeletonSite.Models
{
    public class Stories
    {
        public static List<Story> stories = new List<Story>();

        public static IEnumerable<Story> StoryBank
        {
            get
            {
                for(int i = 0; i < stories.Count; i++)
                {
                    if(stories[i].Title != null)
                        stories.Sort((title1, title2) => title1.Title.CompareTo(title2.Title));
                }
                
                return stories;
            }
        }

        public static void AddStory(Story story)
        {
            stories.Add(story); 
        }

        public static Story retrieve(string title)
        {
            Story post = new Story();
            for (int i = 0; i < stories.Count; i++)
            {
                if (stories[i].Title == title)
                    post = stories[i];
            }
            return post;
        }
    }
}
