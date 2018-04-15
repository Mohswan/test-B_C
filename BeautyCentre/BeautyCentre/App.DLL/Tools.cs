namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tools
    {
        [Key]
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

      

       

        public virtual Companies Companies { get; set; }

        public virtual TypeUnits TypeUnits { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }

   
    }
}
