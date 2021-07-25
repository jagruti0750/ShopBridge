using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopBridgeEntities;

namespace ShopBridgeDB
{
    public class ShopBridgeContext : DbContext
    {
        public ShopBridgeContext() : base("ShopBridgeConnection")
        {

        }
        public DbSet<Inventory> Inventories { get; set; }

    }
}
