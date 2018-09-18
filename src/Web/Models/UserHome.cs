using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace dotfusion.web.Models
{
    public class UserHome
    {
        public IdentityUser User { get; set; }

        public IList<Teacher> Teachers { get; set; }

        public IList<Course> Courses { get; set; }
    }
}
