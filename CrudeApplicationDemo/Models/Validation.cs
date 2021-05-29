using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudeApplicationDemo.Models
{
    public  class Validation
    {
        public string EmpId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Enter Designation")]
        public string Designation { get; set; }

        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateOfRetirement { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Enter Valid PhoneNumber")]
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        [RegularExpression(@"^.*\.(pdf|PDF)$", ErrorMessage = "File is not valid")]
        public string FileUpload { get; set; }
        [RegularExpression(@"^.*\.(jpg|JPG|jpeg|JPEG|)$", ErrorMessage = "Photo is not valid")]
        public string PhotoUpload { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}