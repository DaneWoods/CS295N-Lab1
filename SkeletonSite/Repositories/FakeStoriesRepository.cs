using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkeletonSite.Models;

namespace SkeletonSite.Repositories
{
    public class FakeStoriesRepository : IRepository
    {
        public static List<Story> stories = new List<Story>();

        public List<Story> StoryBank
        {
            get
            {
                for (int i = 0; i < stories.Count; i++)
                {
                    if (stories[i].Title != null)
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

       public void AddInitialStories()
        {
            Story s1 = new Story { Title = "King of Grapes", Text = "He owned a lot of grapes" };
            Story s2 = new Story { Title = "King of Bananas", Text = "He owned a lot of bananas"};
            Story s3 = new Story { Title = "King of Apples", Text = "He owned a lot of apples" };
            stories.Add(s1);
            stories.Add(s2);
            stories.Add(s3);
        }
    }
}
