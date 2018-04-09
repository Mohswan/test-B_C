namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pations()
        {
            DateCalls = new HashSet<DateCalls>();
            DocCusts = new HashSet<DocCusts>();
            ListCusts = new HashSet<ListCusts>();
            MonthCusts = new HashSet<MonthCusts>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Age { get; set; }

        public string Address { get; set; }

        public string TelWhats { get; set; }

        public string Tel { get; set; }

        public string Mob { get; set; }

        public string Email { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Gender_Id { get; set; }

        public int? HowAbout_Id { get; set; }

        public int? Nation_Id { get; set; }

        public int? Pationjob_Id { get; set; }

        public int? Price_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DateCalls> DateCalls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocCusts> DocCusts { get; set; }

        public virtual Genders Genders { get; set; }

        public virtual HowAbouts HowAbouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListCusts> ListCusts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthCusts> MonthCusts { get; set; }

        public virtual Nations Nations { get; set; }

        public virtual Pationjobs Pationjobs { get; set; }

        public virtual Prices Prices { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
