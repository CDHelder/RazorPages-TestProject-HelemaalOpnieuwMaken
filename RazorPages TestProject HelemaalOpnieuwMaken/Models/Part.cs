using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Models
{
    public enum PartType
    {
        Processor,
        Motherboard,
        RAM,
        Graphics_card,
        Hard_drive,
        Case,
        Power_supply,
        Operating_system,
        Mouse,
        Keyboard,
        Monitor,
        Desktop_PC,
        Gaming_PC
    }
    public class Part
    {
        public int PartID { get; set; }

        [Required]
        [Display(Name = "Parts Name")]
        [MaxLength(255)]
        public string PartName { get; set; }

        [Required]
        [Display(Name = "Parts Type")]
        public PartType? PartType { get; set; }

        [Required]
        [Display(Name = "Parts Price Without Taxes (21%)")]
        [DataType(DataType.Currency)]
        public int PartPrice { get; set; }

        public ICollection<RepairOrderDetail> RepairOrderDetails { get; set; }
    }
}
