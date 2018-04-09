namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesReps
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesReps()
        {
            CashCoes = new HashSet<CashCoes>();
            CashReturns = new HashSet<CashReturns>();
            ListReps = new HashSet<ListReps>();
            MonthCoes = new HashSet<MonthCoes>();
            MonthMachinCoes = new HashSet<MonthMachinCoes>();
            PurchaseItems = new HashSet<PurchaseItems>();
            PurchaseMachins = new HashSet<PurchaseMachins>();
            PurchaseTools = new HashSet<PurchaseTools>();
            RequiredpurchaseItems = new HashSet<RequiredpurchaseItems>();
            RequiredpurchaseMachins = new HashSet<RequiredpurchaseMachins>();
            RequiredpurchaseTools = new HashSet<RequiredpurchaseTools>();
            ReturnItems = new HashSet<ReturnItems>();
            ReturnMachins = new HashSet<ReturnMachins>();
            ReturnTools = new HashSet<ReturnTools>();
        }

        public int Id { get; set; }

        public byte Support { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string TelWhats { get; set; }

        public string Tel { get; set; }

        public string Mob { get; set; }

        public string Email { get; set; }

        public byte blocked { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? Gender_Id { get; set; }

        public int? HowAbout_Id { get; set; }

        public int? Nation_Id { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashCoes> CashCoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashReturns> CashReturns { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual Genders Genders { get; set; }

        public virtual HowAbouts HowAbouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListReps> ListReps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthCoes> MonthCoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthMachinCoes> MonthMachinCoes { get; set; }

        public virtual Nations Nations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseItems> PurchaseItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMachins> PurchaseMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseTools> PurchaseTools { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredpurchaseItems> RequiredpurchaseItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredpurchaseMachins> RequiredpurchaseMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredpurchaseTools> RequiredpurchaseTools { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnItems> ReturnItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnMachins> ReturnMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnTools> ReturnTools { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
