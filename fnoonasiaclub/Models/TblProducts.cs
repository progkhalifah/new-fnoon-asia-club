using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblProducts
    {
        public string IdProduct { get; set; }
        public string LabelProduct { get; set; }
        public int? QuantityInStockProduct { get; set; }
        public decimal? Price { get; set; }
        public byte[] ImageProduct { get; set; }
        public int? IdCat { get; set; }
        public DateTime? AddProduct { get; set; }
        public DateTime? EditProduct { get; set; }

        public virtual TblCategories IdCatNavigation { get; set; }
    }
}
