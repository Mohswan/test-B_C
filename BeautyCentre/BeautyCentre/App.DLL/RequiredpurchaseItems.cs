namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RequiredpurchaseItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequiredpurchaseItems()
        {
            PurchaseItems = new HashSet<PurchaseItems>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateEnd { get; set; }

        public string Note { get; set; }

        public decimal Price { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? SalesRep_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Companies Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseItems> PurchaseItems { get; set; }

        public virtual SalesReps SalesReps { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
