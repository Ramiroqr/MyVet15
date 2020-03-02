using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class History
    {
        [Display(Name = "Description")]
        [MaxLength(100, ErrorMessage = "The {0} fiel can not have more than {1} characters.")]
        [Required(ErrorMessage = "The fiel {0} is mandatoy")]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The fiel {0} is mandatoy")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();
    }
}
