using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SHopBridgeWeb.Models
{
    public class InvetoryModel
    {
        [Key]
        public int InventoryID { get; set; }
        public string InventoryName { get; set; }
        public string InventoryDesc { get; set; }
        public float price { get; set; }
        public string InventoryType { get; set; }
    }
}