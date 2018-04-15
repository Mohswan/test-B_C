using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.MVVM
{
    public class Section
    {
        public int Id { get; set; }
      
        [DisplayName("اسم القسم")]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string Tel1 { get; set; }

        public string receptionist { get; set; }

        public string mob { get; set; }

        public string Email { get; set; }

        public string DayJob { get; set; }

        public string HourJob { get; set; }

        public string Mark { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

     
    }
}
