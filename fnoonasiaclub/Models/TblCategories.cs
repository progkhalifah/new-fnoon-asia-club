using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblCategories
    {
        public TblCategories()
        {
            TblProducts = new HashSet<TblProducts>();
        }

        public int IdCat { get; set; }
        public string DescriptionCat { get; set; }

        public virtual ICollection<TblProducts> TblProducts { get; set; }
    }
}
