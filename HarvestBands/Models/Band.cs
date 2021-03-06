﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace HarvestBands.Models
{
    public class Band
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string School { get; set; }
        [Required]
        public string Disctrict { get; set; }
        [Required]
        public Division Division { get; set; }
        [Required]
        [DisplayName("Director First Name")]
        public string DirectorFirstName { get; set; }
        [Required]
        [DisplayName("Director Last Name")]
        public string DirectorLastName { get; set; }
        [Required]
        // required phone number regex
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayName("Band Size")]
        public int BandSize { get; set; }
        [DisplayName("Band Nick Name")]
        public string BandNickName { get; set; }
        [DisplayName("Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
        [DisplayName("Zip Code")]
        public int ZipCode { get; set; }

        [DisplayName("Paid Status")]
        public PaidStatus PaidStatus { get; set; }

        [DisplayName("date paid")]
        public DateTime? DatePaid { get; set; } // TODO confirm DatePaid data type (DateTime?)

        public string ImageSource { get; set; } // TODO image implementation in band master class

    }
}