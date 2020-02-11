using System;
using System.ComponentModel.DataAnnotations;

namespace Job_Tracker{
    public class Job{
        [Key]
        public int JobID {get;set;}

        [Required]
        public string JobTitle {get;set;}

        [Required]
        public string JobURL {get;set;}

        [Required]
        public string JobPDF {get;set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime JobApplied {get;set;}

        public string JobNotes {get;set;}

        public bool isRejected {get;set;} = false;
        public string RecruiterName {get;set;}
        public string RecruiterEmail {get;set;}
        public string RecruiterNumber {get;set;}

        public bool hasRequestedInterview {get;set;}

        [DataType(DataType.Date)]
        public DateTime InterviewDate {get;set;}

        public int CompanyID {get;set;}
    }
}