namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GzaEmps
    {
        public int Id { get; set; }

        public decimal salary { get; set; }

        public DateTime Date { get; set; }

        public string Note { get; set; }

        public string Gza { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Employee_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
