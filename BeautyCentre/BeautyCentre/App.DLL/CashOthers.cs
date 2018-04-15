namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CashOthers
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Exp_Id { get; set; }

        public int? PaymentMethod_Id { get; set; }

        public int? Section_Id { get; set; }

      

       

        public virtual Exps Exps { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }

      
    }
}
