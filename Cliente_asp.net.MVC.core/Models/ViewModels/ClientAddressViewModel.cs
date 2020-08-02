using Cliente_asp.net.MVC.core.Models.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Models.ViewModels
{
    public class ClientAddressViewModel
    {
        public Client Client { get; set; }
        public Address Address { get; set; }
        public Person Person { get; set; }
    }
}
