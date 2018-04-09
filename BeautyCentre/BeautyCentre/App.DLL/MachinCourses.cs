namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MachinCourses
    {
        public int Id { get; set; }

        public int? Course_Id { get; set; }

        public int? Machin_Id { get; set; }

        public virtual Courses Courses { get; set; }

        public virtual Machins Machins { get; set; }
    }
}
