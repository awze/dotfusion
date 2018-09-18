using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

namespace dotfusion.web.Models
{
    public class Teacher : IdentityUser<Teacher>
    {
        public bool IsTeacher { get; }
    }
}
