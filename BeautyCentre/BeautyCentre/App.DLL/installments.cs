namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class installments
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public byte State { get; set; }

        public DateTime Date { get; set; }

        public int? PurchaseMachin_Id { get; set; }

        public virtual PurchaseMachins PurchaseMachins { get; set; }
    }
}
