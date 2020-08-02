using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Models.ViewModels.Enums
{
    public enum Person : int
    {
        [Display(Name = "Jurídica")]
        Juridica = 0,
        [Display(Name = "Física")]
        Física = 1
    }
}
