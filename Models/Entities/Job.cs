using System;
using System.ComponentModel.DataAnnotations;

namespace Job_Tracker{
    public class Job{
        [Key]
        public int JobID {get;set;}

        [Required]
        public string JobTitle {get;set;}

        [Display(Name="Posting URL")]
        public string JobURL {get;set;}

        [Required]
        [Display(Name="Category")]
        public int JobCategory {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date Applied")]
        public DateTime JobAppliedDate {get;set;} =DateTime.Now.Date;
        [Display(Name="Notes")]
        public string JobNotes {get;set;}
        
        public bool isRejected {get;set;} = false;
        

        public bool hasRequestedInterview {get;set;}

        [DataType(DataType.Date)]
        public DateTime InterviewDate {get;set;}

        public int CompanyID {get;set;}

        public Company Company {get;set;}

        public int RecruiterID {get;set;}
    }
}