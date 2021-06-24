using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace loan.Models
{
    public class Loan
    {
        [Key]
        [Required]
        public string UserId { get; set; }
        public string LoanType { get; set; }
        public double LoanAmount { get; set; }
        public DateTime LoanApplyDate { get; set; }
        public DateTime LoanIssueDate { get; set; }
        public int RateOfInterest { get; set; }
        public int Duration { get; set; }
        public int CourseFee { get; set; }
        public string Course { get; set; }
        public string FatherName { get; set; }
        public string FatherExperience { get; set; }
        public string RationCardNo { get; set; }
        public double AnnualIncome { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string TotalExperiance { get; set; }
    }
}
