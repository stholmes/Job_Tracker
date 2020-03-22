using System;
using System.ComponentModel.DataAnnotations;

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
        
    }
}