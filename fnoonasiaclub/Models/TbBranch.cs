using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fnoonasiaclub.Models
{
    public partial class TbBranch
    {
        public TbBranch()
        {
            TbPlayer = new HashSet<TbPlayer>();
        }

        public int BranchNo { get; set; }
        public string BranchNum { get; set; }

        public virtual ICollection<TbPlayer> TbPlayer { get; set; }
    }
}
