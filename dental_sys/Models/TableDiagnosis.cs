using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dental_sys.Models
{
    public partial class TableDiagnosis
    {
        public TableDiagnosis()
        {
            AppointmentDoctor = new HashSet<AppointmentDoctor>();
        }

        public int Id { get; set; }
        public string Диагноз { get; set; }
        public int? Цена { get; set; }

        public virtual ICollection<AppointmentDoctor> AppointmentDoctor { get; set; }
    }
}
