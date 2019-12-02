using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkeletonSite.Models;

namespace SkeletonSite.Repositories
{
    public class StoriesRepository : IRepository
    {
        public AppDbContext context;
        public List<Story> StoryBank { get { return context.Stories.ToList(); } }

        public StoriesRepository(AppDbContext dbContext)
        {
            context = dbContext;
        }

        public void AddStory(Story story)
        {
            context.Stories.Add(story);
            context.SaveChanges();
        }

        public Story Retrieve(string title)
        {
            return context.Stories.First(x => x.Title == title);
        }
    }
}
