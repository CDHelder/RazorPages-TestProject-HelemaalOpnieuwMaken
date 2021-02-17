using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Models
{
    public enum Experience
    {
        Trainee,
        Junior,
        Middle,
        Senior,
        Product_manager
    }
    public class Employee
    {
        public int EmployeeID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public Experience ExpertiseLevel { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAdress")]
        public string Emailadress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [DataType(DataType.PostalCode)]
        public virtual string Postalcode { get; set; }

        public ICollection<RepairOrder> RepairOrders { get; set; }
    }
}
