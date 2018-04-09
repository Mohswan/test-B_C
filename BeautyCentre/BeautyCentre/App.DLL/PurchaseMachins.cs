namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PurchaseMachins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseMachins()
        {
            installments = new HashSet<installments>();
            MonthMachinCoes = new HashSet<MonthMachinCoes>();
        }

        public int Id { get; set; }

        public decimal Cost { get; set; }

        public string warranty { get; set; }

        public decimal amount { get; set; }

        public decimal Price { get; set; }

        public string Note { get; set; }

        public byte[] Image { get; set; }

        public DateTime Date { get; set; }

        public decimal discount { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? Machin_Id { get; set; }

        public int? PaymentMethod_Id { get; set; }

        public int? RequiredpurchaseMachin_Id { get; set; }

        public int? SalesRep_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Companies Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<installments> installments { get; set; }

        public virtual Machins Machins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthMachinCoes> MonthMachinCoes { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        public virtual RequiredpurchaseMachins RequiredpurchaseMachins { get; set; }

        public virtual SalesReps SalesReps { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
