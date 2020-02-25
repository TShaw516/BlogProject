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
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must enter Content!")]
        [Display(Name = "Content")]
        public string Content { get; set; }
        [Required(ErrorMessage = "You must add an Author!")]
        [Display(Name = "Author")]
        public string Author { get; set; }
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "You must add a Category!")]
        [Display(Name = "Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "You must add a Tag!")]
        [Display(Name = "Tags")]
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
