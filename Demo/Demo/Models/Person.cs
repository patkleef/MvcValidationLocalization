using System.ComponentModel.DataAnnotations;
using Demo.Business.Localization;

namespace Demo.Models
{
    /// <summary>
    /// Person model
    /// </summary>
    public class Person
    {
        [Required(ErrorMessageResourceName = "FirstName", ErrorMessageResourceType = typeof(CustomLocalizationProvider))]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceName = "LastName", ErrorMessageResourceType = typeof(CustomLocalizationProvider))]
        public string LastName { get; set; }
    }
}