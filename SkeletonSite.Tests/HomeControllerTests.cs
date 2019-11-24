using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SkeletonSite.Models;
using SkeletonSite.Controllers;
using SkeletonSite.Repositories;

namespace SkeletonSite.Tests
{
    public class HomeControllerTests 
    {
        [Fact]
        public void StoryBankSortTest()
        {
            // Arrange
            var repo = new FakeStoriesRepository();
            var homeController = new HomeController(repo);
            Story sortedStory = new Story();
            // Act
            sortedStory = repo.StoryBank[0];
            // Assert
            Assert.Equal("King of Apples", sortedStory.Title);
        }

        [Fact]
        public void AddStoryTest()
        {
            // Arrange
            var repo = new FakeStoriesRepository();
            var homeController = new HomeController(repo);
            Story newStory = new Story { Title = "King of Pineapples", Text = "He had a lot of pineapples"};
            // Act
            repo.AddStory(newStory);
            // Assert
            Assert.Equal(4, repo.StoryBank.Count);
            Assert.Equal("King of Pineapples", repo.StoryBank[repo.StoryBank.Count - 1].Title);
        }

        [Fact]
        public void RetrieveStoryTest()
        {
            // Arrange
            var repo = new FakeStoriesRepository();
            var homeController = new HomeController(repo);
            Story sortedStory = new Story();
            // Act
            sortedStory = repo.Retrieve(repo.StoryBank[1].Title);
            // Assert
            Assert.Equal(repo.StoryBank[1].Title, sortedStory.Title);
        }
    }
}
