using Backend.Data;
using Backend.Data.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Service
{
    public class PostsService
    {
        private DataStore postsInDb;
        readonly IEnumerable<Post> postsCollection;

        public PostsService()
        {
            postsInDb = new DataStore();
            postsCollection = postsInDb.GetPosts();
        }

        public async Task<IEnumerable<Post>> PopularPostsAsync() => 
            await Task.Run(() => postsCollection.OrderByDescending(x => x.Stats.Votes));

        public async Task<IEnumerable<Post>> NewPostsAsync() =>
            await Task.Run(() => postsCollection.OrderByDescending(x => x.CreatedAt));

        public async Task<IEnumerable<Post>> TrendingPostsAsync() =>
            await Task.Run(() => postsCollection.OrderByDescending(x => x.Stats.VotesInLast2Hours));
    }
}
