namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConvItems
    {
        [Key]
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

    

      

       

        public virtual Sections Sections { get; set; }

        public virtual Sections Sections1 { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }

    }
}
