using System.Globalization;

namespace WebApplication3.Models
{
    public class Feature
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public string Description { get; set; }


        public Feature(string name, string desc)
        {
            Name = name;
            Description = desc;

            Id = Feature._id;
            Feature._id++;
        }


    }
}
