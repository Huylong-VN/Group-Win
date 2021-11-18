using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Data.Dto.Classes
{
    public class ClassDto : BaseEntity
    {
        public string Name { set; get; }
        public string Description { set; get; }
    }
}