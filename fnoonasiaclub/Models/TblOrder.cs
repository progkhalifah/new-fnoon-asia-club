using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TblOrder
    {
        public int IdOrder { get; set; }
        public DateTime? DateOrder { get; set; }
        public int? StatNoPlayer { get; set; }
        public string DescriptionOrder { get; set; }
        public string SalesMan { get; set; }

        public virtual TbPlayer StatNoPlayerNavigation { get; set; }
    }
}
