namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ToolsConvs
    {
        public int Id { get; set; }

        public double quantity { get; set; }

        public decimal Price { get; set; }

        public decimal amount { get; set; }

        public int? CatQuanTools_Id { get; set; }

        public int? ConvTools_Id { get; set; }

        public int? Tools_Id { get; set; }

        public virtual CatQuanTools CatQuanTools { get; set; }

        public virtual ConvTools ConvTools { get; set; }

        public virtual Tools Tools { get; set; }
    }
}
