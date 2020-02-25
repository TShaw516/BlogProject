using System;
using Xunit;
using BlogProject.Models;

namespace BlogProject.Tests
{
    public class BlogModelTests
    {

        Blog myBlog = new Blog();

        public BlogModelTests()
        {
            myBlog = new Blog(1, "My Blog", "Here is Some Content", "Tom", DateTime.Now, "Travel", "Cleveland");
        }


        [Fact]
        public void CourseConstructor_Sets_Id_on_Blog()
        {
            var result = myBlog.BlogId;

            Assert.Equal(1, result);
        }

        [Fact]
        public void CourseConstructor_Sets_Title_on_Blog()
        {
            var result = myBlog.Title;

            Assert.Equal("My Blog", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Content_on_Blog()
        {
            var result = myBlog.Content;

            Assert.Equal("Here is Some Content", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Author_on_Blog()
        {
            var result = myBlog.Author;

            Assert.Equal("Tom", result);
        }

    
        [Fact]
        public void CourseConstructor_Sets_Genre_on_Blog()
        {
            var result = myBlog.Category;

            Assert.Equal("Travel", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Tags_on_Blog()
        {
            var result = myBlog.Tags;

            Assert.Equal("Cleveland", result);
        }

    }
}
