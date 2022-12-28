using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblOrdersDetails
    {
        public string IdProduct { get; set; }
        public int? IdOrder { get; set; }
        public int? Quantity { get; set; }
        public string Price { get; set; }
        public double? Dicount { get; set; }
        public string Amount { get; set; }
        public string TotalAmount { get; set; }

        public virtual TblOrder IdOrderNavigation { get; set; }
        public virtual TblProducts IdProductNavigation { get; set; }
    }
}
