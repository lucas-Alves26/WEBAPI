using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "CEP:")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Cep { get; set; }
        [Display(Name = "Rua:")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Street { get; set; }
        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Neighborhood { get; set; }


        public Address()
        {
        }

        public Address(int id, string cep, string street, string neighborhood)
        {
            Id = id;
            Cep = cep;
            Street = street;
            Neighborhood = neighborhood;

        }
    }
}
