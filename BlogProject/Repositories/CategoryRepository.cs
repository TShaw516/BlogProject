using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(BlogContext context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    }
}
