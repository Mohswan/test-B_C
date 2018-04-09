namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemsConvs
    {
        public int Id { get; set; }

        public double quantity { get; set; }

        public decimal Price { get; set; }

        public decimal amount { get; set; }

        public int? CatQuanItems_Id { get; set; }

        public int? ConvItems_Id { get; set; }

        public int? Items_Id { get; set; }

        public virtual CatQuanItems CatQuanItems { get; set; }

        public virtual ConvItems ConvItems { get; set; }

        public virtual Items Items { get; set; }
    }
}
