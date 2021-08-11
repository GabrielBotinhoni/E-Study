using E_Study.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Study.Data.Context
{
    class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        { }

        #region "DbSets"
        public DbSet<User> Users { get; set; }
        #endregion
    }
}
