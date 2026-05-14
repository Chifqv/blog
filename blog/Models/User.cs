namespace blog.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid Id { get; set; }
        public string ImagePath { get; set; }

        public User(string name, string email, string password, string imagePath = "images/baseUser.jpg")
        {
            Name = name;
            Email = email;
            Password = password;
            Id = new Guid();
            ImagePath = imagePath;
        }
    }
}
