using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlogProject.Models
{
    public class Blog
    {
        //Properties

        public int BlogId { get; set; }
        [Required(ErrorMessage = "You must enter a Title!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must enter Content!")]
        public string Content { get; set; }
        [Required(ErrorMessage = "You must add an Author!")]
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "You must add a Category!")]
        public string Category { get; set; }
        [Required(ErrorMessage = "You must add a Tag!")]
        public string Tags { get; set; }

        //Constructors
        public Blog()
        {

        }

        public Blog(int id, string title, string content, string author, DateTime publishDate, string category, string tags )
        {
            BlogId = id;
            Title = title;
            Content = content;
            Author = author;
            PublishDate = publishDate;
            Category = category;
            Tags = tags;
        }
    }
}
