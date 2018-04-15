namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remedies
    {
        [Key]
        public int Id { get; set; }

        public double Quantity { get; set; }

        public int? CatQuanItems_Id { get; set; }

        public int? Diagnosis_Id { get; set; }

        public int? Items_Id { get; set; }

        public virtual CatQuanItems CatQuanItems { get; set; }

        public virtual Diagnosis Diagnosis { get; set; }

        public virtual Items Items { get; set; }
    }
}
