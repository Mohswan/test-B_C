namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListOthers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListOthers()
        {
            DocOthers = new HashSet<DocOthers>();
        }

        public int Id { get; set; }

        public byte Type { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string Reasons { get; set; }

        public byte VisitNo { get; set; }

        public byte VisitIn { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Section_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocOthers> DocOthers { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
