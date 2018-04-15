namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sections
    {
     

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string Tel1 { get; set; }

        public string receptionist { get; set; }

        public string mob { get; set; }

        public string Email { get; set; }

        public string DayJob { get; set; }

        public string HourJob { get; set; }

        public string Mark { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }


        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

      
    }
}
