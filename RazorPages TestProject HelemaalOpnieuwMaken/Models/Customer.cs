using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAdress")]
        public string Emailadress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }

        public ICollection<RepairOrder> RepairOrders { get; set; }
    }
}
