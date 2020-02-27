using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;

namespace BlogProject.Repositories
{
    public class TagRepository : Repository<Tag>
    {
        public TagRepository(BlogContext context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    }
}
