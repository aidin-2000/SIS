using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dental_sys.Models
{
    public partial class AppointmentDoctor
    {
        public int Id { get; set; }
        public int? Фио { get; set; }
        public int? Диагноз { get; set; }
        public DateTime? Дата { get; set; }
        public int? ЦенаЗаУслугу { get; set; }
        public int? Посещение { get; set; }
        public int? ЛечВрач { get; set; }

        public virtual TableDiagnosis ДиагнозNavigation { get; set; }
        public virtual TableDoctor ЛечВрачNavigation { get; set; }
        public virtual TableClient ФиоNavigation { get; set; }
    }
}
