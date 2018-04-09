namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machins()
        {
            ConvMachins = new HashSet<ConvMachins>();
            MachinCourses = new HashSet<MachinCourses>();
            MachinDocOthers = new HashSet<MachinDocOthers>();
            PurchaseMachins = new HashSet<PurchaseMachins>();
            RequiredpurchaseMachins = new HashSet<RequiredpurchaseMachins>();
            ReturnMachins = new HashSet<ReturnMachins>();
            RoomMachins = new HashSet<RoomMachins>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Note { get; set; }

        public byte ChekMachin { get; set; }

        public string applications { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Companies Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConvMachins> ConvMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachinCourses> MachinCourses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachinDocOthers> MachinDocOthers { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMachins> PurchaseMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredpurchaseMachins> RequiredpurchaseMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnMachins> ReturnMachins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomMachins> RoomMachins { get; set; }
    }
}
