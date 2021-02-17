using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Models
{
    public enum Status
    {
        On_hold,
        Under_repair,
        Waiting_for_parts,
        Done
    }
    public class RepairOrder
    {
        public int RepairOrderID { get; set; }

        [Display(Name = "Repair Status")]
        public Status? Status { get; set; }

        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Begin date is required")]
        [Display(Name = "Begin date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Repair Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        public string RepairDescription { get; set; }

        [Display(Name = "Work Report")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        public string WorkReport { get; set; }


        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        public ICollection<RepairOrderDetail> RepairOrderDetails { get; set; }
    }
}
