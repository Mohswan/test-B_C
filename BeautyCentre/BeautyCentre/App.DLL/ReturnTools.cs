namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReturnTools
    {
        [Key]
        public int MyProperty { get; set; }

        public int Id { get; set; }

        public int PurchaseTools { get; set; }

        public decimal Discount { get; set; }

        public decimal Amount { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public decimal AmountReturn { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

      

       

        public virtual Companies Companies { get; set; }

        public virtual SalesReps SalesReps { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }
    }
}

