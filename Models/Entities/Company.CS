using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Job_Tracker{
    public class Company{
        [Key]
        public int CompanyID {get;set;}

        [Required]
        [Display(Name ="Company Name")]
        public string CompanyName {get;set;}


        public List<Job> Jobs {get;set;}
    }
}