﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Data.Entity
{
    public class Class : BaseEntity
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public List<UserClass> UserClasses { set; get; }
    }
}