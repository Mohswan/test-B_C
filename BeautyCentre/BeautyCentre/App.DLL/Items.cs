namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Items()
        {
            ItemsConvs = new HashSet<ItemsConvs>();
            ItemsCourses = new HashSet<ItemsCourses>();
            ItemsDocCusts = new HashSet<ItemsDocCusts>();
            ItemsPurchases = new HashSet<ItemsPurchases>();
            ItemsRequiredpurchases = new HashSet<ItemsRequiredpurchases>();
            ItemsReturnItems = new HashSet<ItemsReturnItems>();
            Remedies = new HashSet<Remedies>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Data { get; set; }

        public byte[] Image { get; set; }

        public decimal Packagecost { get; set; }

        public decimal Minprice { get; set; }

        public int MinOrder { get; set; }

        public decimal Cartoonprice { get; set; }

        public int Noofunitsperpackage { get; set; }

        public int Noofpackagespercartoon { get; set; }

        public decimal Unitprice { get; set; }

        public string Purpose { get; set; }

        public string Dose { get; set; }

        public string Precautions { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? CatItem_Id { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? TypeUnit_Id { get; set; }

        public int? UserAdd_Id { get; set; }

        public int? UserUpdate_Id { get; set; }

        public virtual CatItems CatItems { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual TypeUnits TypeUnits { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsConvs> ItemsConvs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsCourses> ItemsCourses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsDocCusts> ItemsDocCusts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsPurchases> ItemsPurchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsRequiredpurchases> ItemsRequiredpurchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsReturnItems> ItemsReturnItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remedies> Remedies { get; set; }
    }
}
