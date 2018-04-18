using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.MVVM
{
    public class SalesReps
    {
        [DisplayName("كود المندوب")]
        public int Id { get; set; }
        [DisplayName("مندوب صيانة")]
        public byte Support { get; set; }
        [DisplayName("اسم المندوب")]
        public string Name { get; set; }
        [DisplayName("عنوان المندوب")]
        public string Address { get; set; }
        [DisplayName("واتس المندوب")]
        public string TelWhats { get; set; }
        [DisplayName("تليفون المندوب")]
        public string Tel { get; set; }
        [DisplayName("موبايل المندوب")]
        public string Mob { get; set; }
        [DisplayName("ايميل المندوب")]
        public string Email { get; set; }
        [DisplayName("حظر المندوب")]
        public byte blocked { get; set; }
        [DisplayName("ملاحظات")]
        public string Note { get; set; }
        [DisplayName("تاريخ الاضافة")]
        public string DateAdd { get; set; }
        [DisplayName("تاريخ التعديل")]
        public string DateUpdate { get; set; }
        [DisplayName("اسم الشركة")]
        public string Companies { get; set; }
        [DisplayName("نوع المندوب")]
        public string Genders { get; set; }
        [DisplayName("كيف تعرف علينا")]
        public string HowAbouts { get; set; }
        [DisplayName("جنسية المندوب")]
        public string Nations { get; set; }
        [DisplayName("الفرع")]
        public string Sections { get; set; }
        [DisplayName("قام بالاضافة")]
        public string UserAdd { get; set; }
        [DisplayName("قام بالتعديل")]
        public string UserUpdate { get; set; }

    }
}
