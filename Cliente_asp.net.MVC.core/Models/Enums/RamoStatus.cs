
using System.ComponentModel.DataAnnotations;

namespace Cliente_asp.net.MVC.core.Models.ViewModels.Enums
{
    public enum RamoStatus : int
    {
        [Display(Name = "Comércio")]
        Comercio = 0,
        [Display(Name = "Indústria")]
        Industria = 1,
        [Display(Name = "Negócios")]
        Negócios = 2,
        [Display(Name = "Joalheria")]
        Joalheria = 3
    }
}
