using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cleanArchWebApp.Infrastructure
{
    class ProtofoiloDBContext : DbContext
    {
        public ProtofoiloDBContext()
        {
        }

        public ProtofoiloDBContext(DbContextOptions<ProtofoiloDBContext> options)
            : base(options)
        {
        }
        public DbSet<Owner> MyProperty { get; set; }


    }
}
