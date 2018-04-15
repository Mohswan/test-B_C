namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Companies
    {
    

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string TelWhats { get; set; }

        public string Tel1 { get; set; }

        public string Mob { get; set; }

        public string taxID { get; set; }

        public string regID { get; set; }

        public string products { get; set; }

        public string DateEnd { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

      

       

    

        public virtual specializations specializations { get; set; }

        public virtual Users UsersAdd { get; set; }

         public virtual Users UserUpdate{ get; set; }

      
    }
}
