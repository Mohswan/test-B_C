namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        public int Id { get; set; }

        public byte Car { get; set; }

        public byte Njob { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public string TelWhats { get; set; }

        public string Tel { get; set; }

        public string Mob { get; set; }

        public string Email { get; set; }

        public string Note { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

     

       

   
        public virtual CatJobs CatJobs { get; set; }

        public virtual Sections Sections { get; set; }

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }

    
    }
}
