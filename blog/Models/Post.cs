namespace blog.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public User Autor { get; set; }

        public Post(string description, string imagePath, User autor)
        {
            Description = description;
            ImagePath = imagePath;
            Autor = autor;
            Id = new Guid();
        }
    }
}
