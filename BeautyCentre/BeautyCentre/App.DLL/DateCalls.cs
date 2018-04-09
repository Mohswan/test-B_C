namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DateCalls
    {
        public int Id { get; set; }

        public DateTime DateOld { get; set; }

        public DateTime DateNext { get; set; }

        public string purpose { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Pation_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Pations Pations { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
