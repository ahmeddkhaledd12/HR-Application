using System;
using System.ComponentModel.DataAnnotations;

namespace HrApplication.Models
{
    public class employeescshtml
    {
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string name { get; set; }

        [StringLength(50)]
        public string department { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string gmail { get; set; }

        [Required(ErrorMessage = "Please enter job title")]
        [StringLength(50)]
        public string jobtitle { get; set; }

        [Required(ErrorMessage = "Please enter birth date")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime birthdate { get; set; }

        [Display(Name = "Active Status")]
        public bool isacticve { get; set; }
    }
}
