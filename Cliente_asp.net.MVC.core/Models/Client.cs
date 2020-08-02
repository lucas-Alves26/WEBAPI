using Cliente_asp.net.MVC.core.Models;
using Cliente_asp.net.MVC.core.Models.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente_asp.net.MVC.core.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter entre 3 a 60 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Razão Social:")]
        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter entre 3 a 60 caracteres")]
        public string CompanyName { get; set; }

        [Display(Name = "Nome fantasia:")]
        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter entre 3 a 60 caracteres")]
        public string FantasyName { get; set; }

        [Display(Name = "Tipo de pessoa:")]
        [Required(ErrorMessage = "{0} requerido")]
        public Person KindPers { get; set; }

        [Display(Name = "CNPJ:")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Cnpj { get; set; }

        [Display(Name = "Escrição municipal:")]
        [Required(ErrorMessage = "{0} requerido")]
        //[StringLength(14, MinimumLength = 14, ErrorMessage = "{0} deve ter 14 Caracteres")]
        public string MunicipalRegistration { get; set; }

        [Display(Name = "Escrição estadual:")]
        [Required(ErrorMessage = "{0} requerido")]
       //[StringLength(14, MinimumLength = , ErrorMessage = "{0} deve ter 14 Caracteres")]
        public string StateRegistration { get; set; }

        [Display(Name = "Bloqueado por problemas financeiros?")]
        public string BlockedFinancial { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Ramo de Atividade:")]
        public RamoStatus Industry{ get; set; }

        [Display(Name = "Ativo?")]
        public bool Status { get; set; }

        [Display(Name = "Data de cadastro:")]
        [DataType(DataType.Date)] //dd/MM/yyyy
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }



        public Client()
        {
        }

        public Client(int id, string name, string companyName, string fantasyName, Person kindPerson, string cnpj, string municipalRegistration, string stateRegistration, string blockedFinancial,RamoStatus industry, bool status, Address addres, DateTime date)
        {
            Id = id;
            Name = name;
            CompanyName = companyName;
            FantasyName = fantasyName;
            KindPers = kindPerson;
            Cnpj = cnpj;
            MunicipalRegistration = municipalRegistration;
            StateRegistration = stateRegistration;
            BlockedFinancial = blockedFinancial;
            Industry = Industry;
            Status = status;
            Address = addres;
            Date = date;
        }
    }
}
