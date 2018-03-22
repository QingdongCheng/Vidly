using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class IdentityModels
    {
    }

    public class CustomerContext: DbContext
    {
        public DbSet<Customer> CustomerItem { get;  set; }
        public DbSet<Movie> MovieItem { get; set; }

    }
}