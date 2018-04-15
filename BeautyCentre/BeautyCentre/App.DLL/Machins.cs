namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machins
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Note { get; set; }

        public byte ChekMachin { get; set; }

        public string applications { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

      

       

        public virtual Companies Companies { get; set; }
        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }

    }
}
