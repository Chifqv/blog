namespace blog.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string AutorId { get; set; }

        public Post(string description, string imagePath, string autorId)
        {
            Description = description;
            ImagePath = imagePath;
            AutorId = autorId;
            Id = new Guid();
        }
    }
}
