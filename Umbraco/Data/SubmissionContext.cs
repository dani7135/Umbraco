using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Umbraco.Models;

namespace Umbraco.Data
{
    public class SubmissionContext : DbContext
    {
        public SubmissionContext(DbContextOptions<SubmissionContext> options)
        : base (options)
        { }
        public DbSet<Submission> Submissions { get; set; }
    }
}
