namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RequiredpurchaseMachins
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string warranty { get; set; }

        public DateTime DateEnd { get; set; }

        public string Support { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        //public int? Company_MyProperty { get; set; }

        //public int? Machin_Id { get; set; }

        //public int? SalesRep_Id { get; set; }

        //public int? Section_Id { get; set; }

      

       

        public virtual Companies Companies { get; set; }

        public virtual Machins Machins { get; set; }

   

        public virtual SalesReps SalesReps { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }
    }
}
