using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Job_Tracker{
    public class Recruiter{
        [Key]
        public int RecruiterID {get;set;}
        [Required]
        public string RecruiterName {get;set;}
        [Required]
        public string RecruiterEmail {get;set;}

        [Required]
        public string RecruiterPhoneNumber {get;set;}

        public List<Job> Jobs {get;set;}

    }
}