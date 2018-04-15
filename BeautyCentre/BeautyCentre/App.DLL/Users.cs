namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Pass { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public string Tel1 { get; set; }

        public int UserAdd { get; set; }

        public string DateAdd { get; set; }

        public int UserUpdate { get; set; }

        public string DateUpdate { get; set; }

        public int? JobPermation_Id { get; set; }

      

        public virtual JobPermations JobPermations { get; set; }

      
    }
}
