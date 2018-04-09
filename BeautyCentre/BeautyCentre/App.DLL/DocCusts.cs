namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocCusts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocCusts()
        {
            ChequeDocCusts = new HashSet<ChequeDocCusts>();
            ItemsDocCusts = new HashSet<ItemsDocCusts>();
            MachinDocOthers = new HashSet<MachinDocOthers>();
        }

        public int Id { get; set; }

        public string purpose { get; set; }

        public string DiagnosisOld { get; set; }

        public DateTime DateOld { get; set; }

        public decimal PreviousBalance { get; set; }

        public DateTime Date { get; set; }

        public decimal RequiredForToday { get; set; }

        public decimal total { get; set; }

        public string Note { get; set; }

        public string Diagnosis { get; set; }

        public decimal Payed { get; set; }

        public string Precautions { get; set; }

        public decimal PriceCurse { get; set; }

        public decimal PriceIn { get; set; }

        public decimal PriceOld { get; set; }

        public decimal PriceAll { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public DateTime NextDate { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Course_Id { get; set; }

        public int? ListCust_Id { get; set; }

        public int? Pation_Id { get; set; }

        public int? PaymentMethod_Id { get; set; }

        public int? Room_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChequeDocCusts> ChequeDocCusts { get; set; }

        public virtual Courses Courses { get; set; }

        public virtual ListCusts ListCusts { get; set; }

        public virtual Pations Pations { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        public virtual Rooms Rooms { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsDocCusts> ItemsDocCusts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachinDocOthers> MachinDocOthers { get; set; }
    }
}
