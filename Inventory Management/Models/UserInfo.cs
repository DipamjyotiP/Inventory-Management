using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Management.Models
{
    public partial class UserInfo
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter User Name")]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Created Date")]
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}
