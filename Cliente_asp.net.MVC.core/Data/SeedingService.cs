using Cliente_asp.net.MVC.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Data
{
    public class SeedingService
    {
        private Cliente_aspnetMVCcoreContext _contex;

        public SeedingService(Cliente_aspnetMVCcoreContext context)
        {
            _contex = context;
        }

        public void Seed()
        {
            if (_contex.Client.Any()||_contex.Address.Any())
            {
                return;
            }
        }
    }
}
