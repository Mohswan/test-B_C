namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items
    {
      
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Data { get; set; }

        public byte?[] Image { get; set; }

        public decimal Packagecost { get; set; }

        public decimal Minprice { get; set; }

        public int MinOrder { get; set; }

        public decimal Cartoonprice { get; set; }

        public int Noofunitsperpackage { get; set; }

        public int Noofpackagespercartoon { get; set; }

        public decimal Unitprice { get; set; }

        public string Purpose { get; set; }

        public string Dose { get; set; }

        public string Precautions { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? CatItem_Id { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? TypeUnit_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual CatItems CatItems { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual TypeUnits TypeUnits { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

    }
}
