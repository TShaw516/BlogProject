using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class BlogRepository : Repository<Blog>
    {
        public BlogRepository(BlogContext context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    }
}
