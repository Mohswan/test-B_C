namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Genders
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    
    }
}
