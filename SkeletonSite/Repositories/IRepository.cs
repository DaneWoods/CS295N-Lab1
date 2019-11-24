using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkeletonSite.Models;

namespace SkeletonSite.Repositories
{
    public interface IRepository
    {
        List<Story> StoryBank { get; }
        void AddStory(Story story);
        Story Retrieve(string title);
    }
}
