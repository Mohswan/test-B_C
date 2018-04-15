namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListCusts
    {
        [Key]
        public int Id { get; set; }

        public int Type { get; set; }

        public DateTime Date { get; set; }

        public string purpose { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal Discount { get; set; }

        public decimal RequiredForToday { get; set; }

        public decimal total { get; set; }

        public decimal payed { get; set; }

        public string Note { get; set; }

        public decimal Balance { get; set; }

        public byte VisitNo { get; set; }

        public byte VisitIn { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Pation_Id { get; set; }

        public int? PaymentMethod_Id { get; set; }

        public int? Section_Id { get; set; }

      

       

    
        public virtual ICollection<DocCusts> DocCusts { get; set; }

        public virtual Pations Pations { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }
    }
}
