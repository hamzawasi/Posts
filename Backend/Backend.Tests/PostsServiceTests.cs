using Backend.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Backend.Tests
{
    [TestClass]
    public class PostsServiceTests
    {
        PostsService service;

        [TestInitialize]
        public void Init()
        {
            service = new PostsService();
        }

        [TestMethod]
        public async Task DoesSortByNewWork()
        {
            var p0 = await service.NewPostsAsync();
            Assert.That(p0, Is.Ordered.Descending.By("CreatedAt"));
            Assert.IsTrue(p0.First().CreatedAt > p0.ElementAt(1).CreatedAt);
        }

        [TestMethod]
        public async Task DoesSortByPopularWork()
        {
            var p0 = await service.PopularPostsAsync();
            Assert.IsTrue(p0.First().Stats.Votes > p0.ElementAt(1).Stats.Votes);
            Assert.IsTrue(p0.Last().Stats.Votes < p0.ElementAt(p0.Count() - 2).Stats.Votes);
        }

        [TestMethod]
        public async Task DoesSortByTrendingWork()
        {
            var p0 = await service.TrendingPostsAsync();
            Assert.IsTrue(p0.First().Stats.VotesInLast2Hours > p0.ElementAt(1).Stats.VotesInLast2Hours);
            Assert.IsTrue(p0.Last().Stats.VotesInLast2Hours < p0.ElementAt(p0.Count() - 2).Stats.VotesInLast2Hours);
        }
    }
}
