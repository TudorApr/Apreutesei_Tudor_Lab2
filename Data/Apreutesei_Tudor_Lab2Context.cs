using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apreutesei_Tudor_Lab2.Models;

namespace Apreutesei_Tudor_Lab2.Data
{
    public class Apreutesei_Tudor_Lab2Context : DbContext
    {
        public Apreutesei_Tudor_Lab2Context (DbContextOptions<Apreutesei_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Apreutesei_Tudor_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
