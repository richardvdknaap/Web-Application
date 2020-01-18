using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keukenhof_2._0.Models
{
    public class KeukenhofContext : DbContext
    {
        public KeukenhofContext(DbContextOptions<KeukenhofContext> options)
         : base(options)
        { }
        public DbSet<Event> Events { get; set; }
    }
}
