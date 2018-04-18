namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemsRequiredpurchases
    {
        [Key]
        public int Id { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal amount { get; set; }
        public virtual RequiredpurchaseItems RequiredpurchaseItems { get; set; }
        public virtual CatQuanItems CatQuanItems { get; set; }
        public virtual Items Items { get; set; }
    }
}
