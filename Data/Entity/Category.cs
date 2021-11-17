using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Data.Entity
{
    public class Category : BaseEntity
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public List<CourseCategory> CourseCategories { set; get; }
    }
}