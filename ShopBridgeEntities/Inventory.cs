using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using Xunit.Sdk;

namespace ShopBridgeEntities
{
    public class Inventory

    {
        [Key]
        public int InventoryID { get; set; }
        //[BindRequired(ErrorMessage = "Name Required")]
        [DisplayName("Name")]
        public string InventoryName { get; set; }
       // [Required(ErrorMessage ="Inventory Description is required.")]
        [DisplayName("Description")]
        public string InventoryDesc { get; set; }

       // [Required(ErrorMessage ="Inventory Price is required.")]
        [DisplayName("Price")]
        public float price { get; set; }
        [DisplayName("Type")]
        public string InventoryType { get; set; }
    }
}
