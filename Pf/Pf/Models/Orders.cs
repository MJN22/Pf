using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pf.Models
{
    public partial class Orders
    {
        public Orders()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int Id { get; set; }
        public int UserLocationId { get; set; }
        public int ShopId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode= true)]
        public DateTime OrderTime { get; set; }
        public double TotalDue { get; set; }

        public virtual Store Shop { get; set; }
        public virtual UserLocation UserLocation { get; set; }
        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
