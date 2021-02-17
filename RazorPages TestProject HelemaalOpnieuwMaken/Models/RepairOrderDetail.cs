using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Models
{
    public class RepairOrderDetail
    { 
        public int RepairOrderDetailID { get; set; }

        public int Quantity { get; set; }

        public int RepairOrderID { get; set; }
        public int PartID { get; set; }
        public RepairOrder RepairOrder { get; set; }
        public Part Part { get; set; }

        private List<RepairOrderDetail> RepairOrderDetails;

        public List<RepairOrderDetail> FindAll()
        {
            return RepairOrderDetails;
        }
        public RepairOrderDetail Find(int id)
        {
            return RepairOrderDetails.Where(p => p.RepairOrderDetailID == id).FirstOrDefault();
        }
    }
}
