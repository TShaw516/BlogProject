using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Blog
    {
        //Properties
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }

        //Constructors
        public Blog()
        {

        }

        public Blog(int id, string title, string content, string author, string publishDate, string category, string tags )
        {
            Id = id;
            Title = title;
            Content = content;
            Author = author;
            PublishDate = publishDate;
            Category = category;
            Tags = tags;
        }
    }
}
