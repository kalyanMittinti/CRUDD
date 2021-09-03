using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDD.Model
{
    public class Employee
    {

        [Display(Name = "Id")]
        public string EmployeeId { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; }
       
        [Required(ErrorMessage = "LastName  is required.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Gender  is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "MobileNumber is required.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "EmailAddress is required.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "DepartmentId is required.")]
        public string DepartmentId { get; set; }

        [Required(ErrorMessage = "ProfileImage is required.")]
        public string ProfileImage { get; set; }
   


    }
}