namespace blog.Models
{
    public class Post
    {
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public User Autor { get; set; }
        public int Likes { get; set; }
        public DateTime Created { get; set; }
        public Guid Id { get; set; }


        public Post(string description, string imagePath, User autor)
        {
            Description = description;
            ImagePath = imagePath;
            Autor = autor;
            Id = new Guid();
            Likes = 0;
            Created = DateTime.Now;//потом поменять!
        }
    }
}
