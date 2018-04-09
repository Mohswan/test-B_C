namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tools
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tools()
        {
            ToolsConvs = new HashSet<ToolsConvs>();
            ToolsPurchases = new HashSet<ToolsPurchases>();
            ToolsRequiredpurchases = new HashSet<ToolsRequiredpurchases>();
            ToolsReturnTools = new HashSet<ToolsReturnTools>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Note { get; set; }

        public decimal Packagecost { get; set; }

        public decimal Cartoonprice { get; set; }

        public decimal Unitprice { get; set; }

        public int Noofunitsperpackage { get; set; }

        public int Noofpackagespercartoon { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? TypeUnit_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual TypeUnits TypeUnits { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolsConvs> ToolsConvs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolsPurchases> ToolsPurchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolsRequiredpurchases> ToolsRequiredpurchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolsReturnTools> ToolsReturnTools { get; set; }
    }
}
