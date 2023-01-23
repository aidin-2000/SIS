using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dental_sys.Models
{
    public partial class Position
    {
        public Position()
        {
            TableDoctor = new HashSet<TableDoctor>();
        }

        public int Id { get; set; }
        public string Position1 { get; set; }

        public virtual ICollection<TableDoctor> TableDoctor { get; set; }
    }
}
