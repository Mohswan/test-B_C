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
        [DisplayName("كود القسم")]
        public int Id { get; set; }
      
        [DisplayName("اسم القسم")]
        public string Name { get; set; }
        [DisplayName("عنوان القسم")]
        public string Address { get; set; }
        [DisplayName("التليفون القسم")]
        public string Tel { get; set; }
        [DisplayName("تليفون اخر للقسم")]

        public string Tel1 { get; set; }
        [DisplayName("تليفون اخر للقسم")]
        public string receptionist { get; set; }
        [DisplayName("موبايل القسم")]

        public string mob { get; set; }
        [DisplayName("ايميل القسم")]

        public string Email { get; set; }
        [DisplayName("يوم عمل القسم ")]

        public string DayJob { get; set; }
        [DisplayName("ساعة  عمل القسم")]

        public string HourJob { get; set; }
        [DisplayName("علامة القسم")]

        public string Mark { get; set; }

        [DisplayName("قام بالاضافة")]
        public string UserAdd{ get; set; }
        [DisplayName("تاريخ الاضافة")]

        public string DateAdd { get; set; }
        [DisplayName("قام بالتعديل")]

        public string UserUpdate{ get; set; }
        [DisplayName("تاريخ التعديل")]

        public string DateUpdate { get; set; }

     
    }
}
