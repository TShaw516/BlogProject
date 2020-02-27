using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public Tag()
        {

        }

        public Tag(int tagId, string tagName)
        {
            TagId = tagId;
            TagName = tagName;
        }
    }
}
