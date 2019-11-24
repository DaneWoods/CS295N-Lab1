using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkeletonSite.Models;

namespace SkeletonSite.Repositories
{
    public class StoriesRepository : IRepository
    {
        public static List<Story> stories = new List<Story>();

        public List<Story> StoryBank
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

        public void AddStory(Story story)
        {
            stories.Add(story); 
        }

        public Story Retrieve(string title)
        {
            return stories.Find(x => x.Title == title);
        }
    }
}
