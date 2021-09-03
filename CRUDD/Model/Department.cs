using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDD.Model
{
    public class Department
    {

        [Display(Name = "Id")]
        public string DepartmentId { get; set; }

        [Required(ErrorMessage = "DepartmentName is required.")]
        public string DepartmentName { get; set; }
    }
}