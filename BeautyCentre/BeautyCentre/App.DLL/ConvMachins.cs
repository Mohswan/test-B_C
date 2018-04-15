namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConvMachins
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public double quantity { get; set; }

        public decimal amount { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Machin_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? SectionTo_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Machins Machins { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Sections Sections1 { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
