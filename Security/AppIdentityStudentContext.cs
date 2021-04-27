using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WADWebsite.Security
{
    public class AppIdentityStudentContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public AppIdentityStudentContext(DbContextOptions<AppIdentityStudentContext> options)
            : base(options)
            {
            }
    }
}
