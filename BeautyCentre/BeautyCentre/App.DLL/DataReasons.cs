namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataReasons
    {
        public int Id { get; set; }

        public string Data { get; set; }

        public int IdCode { get; set; }

        public int? Reasons_Id { get; set; }

        public virtual Reasons Reasons { get; set; }
    }
}
