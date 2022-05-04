using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_first_approch.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MVCDB;Integrated " +
            "Security=True") { }
        public DbSet<Students> students { get; set; }

    }

}