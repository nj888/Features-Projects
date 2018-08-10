using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication76.Models.ViewModel
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage="Username Required")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password Required")]

        public string Password { get; set; }


        [Compare("Password", ErrorMessage = "Password Mismatch")]
        public string RetypePassword { get; set; }

        [Required(ErrorMessage = "Fullname Required")]
        public string Fullname { get; set; }


        public string Gender { get; set; }

		[StringLength(14, MinimumLength = 10, ErrorMessage = "Invalid")]
        public string ContactNo { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? RegDate { get; set; }

        [Required(ErrorMessage = "Photo Required")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Country Name Required")]
        [Display(Name = "Country Name")]
        public int? CountryId { get; set; }

        public string CountryName { get; set; }
        public bool? IsActive { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$", ErrorMessage = "Not a valid email")]
        public string Email { get; set; }
        public int? UserId { get; set; }
    }
}