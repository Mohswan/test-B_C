namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesReps
    {
        [Key]
        public int Id { get; set; }

        public byte Support { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string TelWhats { get; set; }

        public string Tel { get; set; }

        public string Mob { get; set; }

        public string Email { get; set; }

        public byte blocked { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

        public int? Company_MyProperty { get; set; }

        public int? Gender_Id { get; set; }

        public int? HowAbout_Id { get; set; }

        public int? Nation_Id { get; set; }

        public int? Section_Id { get; set; }

      

       

      

        public virtual Companies Companies { get; set; }

        public virtual Genders Genders { get; set; }

        public virtual HowAbouts HowAbouts { get; set; }

    

        public virtual Nations Nations { get; set; }

    

        public virtual Sections Sections { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }
    }
}
