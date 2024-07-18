using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext>options) : base(options)
        {

        }
        public DbSet<JobRequest> JobRequest {get; set;}
    }
}