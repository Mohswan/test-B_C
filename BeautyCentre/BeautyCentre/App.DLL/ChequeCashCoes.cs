namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChequeCashCoes
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public int? Bank_Id { get; set; }

        public int? CashCo_Id { get; set; }

        public virtual Banks Banks { get; set; }

        public virtual CashCoes CashCoes { get; set; }
    }
}
