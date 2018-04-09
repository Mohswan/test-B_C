namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemsPurchases
    {
        public int Id { get; set; }

        public double quantity { get; set; }

        public decimal Price { get; set; }

        public decimal amount { get; set; }

        public int? CatQuanItems_Id { get; set; }

        public int? Items_Id { get; set; }

        public int? PurchaseItems_Id { get; set; }

        public virtual CatQuanItems CatQuanItems { get; set; }

        public virtual Items Items { get; set; }

        public virtual PurchaseItems PurchaseItems { get; set; }
    }
}
