using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cliente_asp.net.MVC.core.Models.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;

namespace Cliente_asp.net.MVC.core.Models
{
    public class Cliente_aspnetMVCcoreContext : DbContext
    {
        public Cliente_aspnetMVCcoreContext (DbContextOptions<Cliente_aspnetMVCcoreContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
