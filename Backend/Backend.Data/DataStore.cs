using Backend.Data.Schema;
using System;
using System.Collections.Generic;

namespace Backend.Data
{
    public class DataStore
    {
        private readonly IEnumerable<Post> posts;
        public DataStore()
        {
            posts = LoadPostsInMemory();
        }

        public IEnumerable<Post> GetPosts() => posts;

        private IEnumerable<Post> LoadPostsInMemory()
        {
            var postsCollection = new List<Post>()
            {
                new Post { 
                    Id = 1, 
                    UserId = 1, 
                    Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 0, 0),
                    Stats = new PostStats { 
                        Votes = 10, 
                        VotesInLast2Hours = 5
                    }
                },
                new Post {
                    Id = 2,
                    UserId = 1,
                    Title = "qui est esse",
                    Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 5, 0),
                    Stats = new PostStats {
                        Votes = 15,
                        VotesInLast2Hours = 2
                    }
                },
                new Post {
                    Id = 3,
                    UserId = 1,
                    Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut",
                    Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 10, 0),
                    Stats = new PostStats {
                        Votes = 9,
                        VotesInLast2Hours = 7
                    }
                },
                new Post {
                    Id = 4,
                    UserId = 1,
                    Title = "eum et est occaecati",
                    Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 15, 0),
                    Stats = new PostStats {
                        Votes = 13,
                        VotesInLast2Hours = 9
                    }
                },
                new Post {
                    Id = 5,
                    UserId = 1,
                    Title = "nesciunt quas odio",
                    Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 20, 0),
                    Stats = new PostStats {
                        Votes = 17,
                        VotesInLast2Hours = 4
                    }
                },
                new Post {
                    Id = 6,
                    UserId = 1,
                    Title = "dolorem eum magni eos aperiam quia",
                    Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 25, 0),
                    Stats = new PostStats {
                        Votes = 19,
                        VotesInLast2Hours = 15
                    }
                },
                new Post {
                    Id = 7,
                    UserId = 1,
                    Title = "magnam facilis autem",
                    Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 30, 0),
                    Stats = new PostStats {
                        Votes = 3,
                        VotesInLast2Hours = 1
                    }
                },
                new Post {
                    Id = 8,
                    UserId = 1,
                    Title = "dolorem dolore est ipsam",
                    Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 35, 0),
                    Stats = new PostStats {
                        Votes = 12,
                        VotesInLast2Hours = 8
                    }
                },
                new Post {
                    Id = 9,
                    UserId = 1,
                    Title = "nesciunt iure omnis dolorem tempora et accusantium",
                    Body = "consectetur animi nesciunt iure dolore\nenim quia ad\nveniam autem ut quam aut nobis\net est aut quod aut provident voluptas autem voluptas",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 40, 0),
                    Stats = new PostStats {
                        Votes = 30,
                        VotesInLast2Hours = 9
                    }
                },
                new Post {
                    Id = 10,
                    UserId = 1,
                    Title = "optio molestias id quia eum",
                    Body = "quo et expedita modi cum officia vel magni\ndoloribus qui repudiandae\nvero nisi sit\nquos veniam quod sed accusamus veritatis error",
                    CreatedAt = new DateTime(2022, 4, 10, 16, 45, 0),
                    Stats = new PostStats {
                        Votes = 25,
                        VotesInLast2Hours = 20
                    }
                }
            };
            return postsCollection;
        }
    }
}