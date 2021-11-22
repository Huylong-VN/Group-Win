using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Data.Dto.Courses
{
    public class CourseDto : BaseEntity
    {
        public string Name { set; get; }
        public string Description { set; get; }
    }
}
