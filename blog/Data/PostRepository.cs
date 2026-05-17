using blog.Models;
using System.Text.Json;

namespace blog.Data
{
    public class PostRepository
    {
        private List<Post> posts;

        public PostRepository()
        {
            string jsonString = File.ReadAllText("Data/Posts.json");
            posts = JsonSerializer.Deserialize<List<Post>>(jsonString);
        }

        public List<Post> GetAll()
        {
            return posts;
        }

        public List<Post> GetPostsByAutor(User autor)
        {
            return posts.Where(x => x.Autor == autor).ToList();
        }
    }
}
