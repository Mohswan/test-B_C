namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PurchaseTools
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseTools()
        {
            ToolsPurchases = new HashSet<ToolsPurchases>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal discount { get; set; }

        public decimal amount { get; set; }

        public decimal Price { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? PaymentMethod_Id { get; set; }

        public int? RequiredpurchaseTools_Id { get; set; }

        public int? SalesRep_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        public virtual RequiredpurchaseTools RequiredpurchaseTools { get; set; }

        public virtual SalesReps SalesReps { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolsPurchases> ToolsPurchases { get; set; }
    }
}
