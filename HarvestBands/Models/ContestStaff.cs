using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HarvestBands.Models
{
    public class ContestStaff
    {
        [Required]
        [DisplayName("Name")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; } // validate phone numbers
        [DisplayName("Cell Phone Number")]
        public string CellPhoneNumber { get; set; } // validate phone number
        public StaffMemberSchool School { get; set; } // school should be drop down list
        public string Title { get; set; }
        public bool Active { get; set; }
        public bool IsDirector { get; set; }
        public bool IsBandHostCoordinator { get; set; }
    }
}