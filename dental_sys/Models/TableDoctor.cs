using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dental_sys.Models
{
    public partial class TableDoctor
    {
        public TableDoctor()
        {
            AppointmentDoctor = new HashSet<AppointmentDoctor>();
        }

        public int Id { get; set; }
        public string Фио { get; set; }
        public string Адрес { get; set; }
        public string Номер { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public int? Position { get; set; }
        public byte[] Image { get; set; }
        public string Status { get; set; }

        public virtual Position PositionNavigation { get; set; }
        public virtual ICollection<AppointmentDoctor> AppointmentDoctor { get; set; }
    }
}
