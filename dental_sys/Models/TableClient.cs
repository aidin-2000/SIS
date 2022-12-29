using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dental_sys.Models
{
    public partial class TableClient
    {
        public TableClient()
        {
            AppointmentDoctor = new HashSet<AppointmentDoctor>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? Date { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<AppointmentDoctor> AppointmentDoctor { get; set; }
    }
}
