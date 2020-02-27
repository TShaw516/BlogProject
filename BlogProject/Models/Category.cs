using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

        public Category()
        {

        }

        public Category(int catid, string catname)
        {
            CategoryId = catid;
            CategoryName = catname;
        }
    }
}
