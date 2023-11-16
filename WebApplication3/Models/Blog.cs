namespace WebApplication3.Models
{
    public class Blog
    {
        private static int _id;
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string Image { get; set; }


        public Blog(string title, string description, string authorName, string image)
        {
            Title = title;
            Description = description;
            AuthorName = authorName;
            Image = image;

            Id = Blog._id;

            Blog._id++;

            
        }

    }

    
}
