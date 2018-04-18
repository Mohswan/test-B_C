using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace Main
{
    public partial class frmRepresentative : DevExpress.XtraEditors.XtraForm
    {
        App.DLL.AppDBContext db = new App.DLL.AppDBContext();
        public frmRepresentative()
        {
            InitializeComponent();
            Service.Service.fillLoK(lokCom, db.Companies.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الشركة", "اسم الشركة", "كود الشركة");
            Service.Service.fillLoK(lokSection, db.Sections.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الفرع", "اسم الفرع", "كود الفرع");
            Service.Service.fillCombo(comGender, db.Genders.ToList().Select(f => f.Name));
            Service.Service.fillCombo(comHowAbouts, db.HowAbouts.ToList().Select(f => f.Name));
            Service.Service.fillCombo(comNation, db.Nations.ToList().Select(f => f.Name));
            Service.Service.fillGrid(GetData(db.SalesReps.ToList()), gridView1, gridControl1);

            

        }
        List<MVVM.SalesReps> GetData(List<App.DLL.SalesReps> getsalesRep)
        {
            List<MVVM.SalesReps> salesReps = new List<MVVM.SalesReps>();
            foreach (var item in getsalesRep)
            {
                salesReps.Add(new MVVM.SalesReps
                {
                    Name = item.Name,
                    Address = item.Address,
                    Email = item.Email,
                    Mob = item.Mob,
                    Id = item.Id,
                    Tel = item.Tel,
                    blocked = item.blocked,
                    Companies = item.Companies.Name,
                    DateAdd = item.DateAdd,
                    DateUpdate = item.DateUpdate,
                    Genders = item.Genders.Name,
                    HowAbouts = item.HowAbouts.Name,
                    Nations = item.Nations.Name,
                    Note = item.Note,
                    Sections = item.Sections.Name,
                    Support = item.Support,
                    TelWhats = item.TelWhats,
                    UserAdd = item.UserAdd.Name,
                    UserUpdate = item.UserUpdate.Name
                });
            }
            return salesReps;
        }

        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<App.DLL.HowAbouts> HowAbouts_ = new List<App.DLL.HowAbouts>();
            if (db.HowAbouts.Where(fun => fun.Name == comHowAbouts.Text).SingleOrDefault()==null)
            {
                HowAbouts_.Add(new App.DLL.HowAbouts { Name = comHowAbouts.Text });
            }
            else
            {
                HowAbouts_.Add(db.HowAbouts.Where(fun => fun.Name == comHowAbouts.Text).SingleOrDefault());
            }
           
           
            List<App.DLL.Nations> Nations_ = new List<App.DLL.Nations>();
            if (db.Nations.Where(fun => fun.Name == comNation.Text).SingleOrDefault()==null)
            {
                Nations_.Add(new App.DLL.Nations { Name = comNation.Text });
            }
            else
            {
                Nations_.Add(db.Nations.Where(fun => fun.Name == comNation.Text).SingleOrDefault());
            }
         
            List<App.DLL.Genders> Genders_ = new List<App.DLL.Genders>();
            if (db.Genders.Where(fun => fun.Name == comGender.Text).SingleOrDefault()==null)
            {
                Genders_.Add(new App.DLL.Genders { Name = comGender.Text });
            }
            else
            {
                Genders_.Add(db.Genders.Where(fun => fun.Name == comGender.Text).SingleOrDefault());
            }
           
            db.SalesReps.Add(new App.DLL.SalesReps
            {
                Name = txtName.Text,
                Companies = db.Companies.Find(Convert.ToInt32(lokCom.GetColumnValue("Id"))),
                HowAbouts = HowAbouts_.SingleOrDefault(),
                Nations = Nations_.SingleOrDefault(),
                Genders = Genders_.SingleOrDefault(),
                Sections = db.Sections.Find(Convert.ToInt32(lokSection.GetColumnValue("Id"))),

                DateAdd = DateTime.Now.ToString(),
                UserAdd = db.Users.Find(0),
                UserUpdate = db.Users.Find(0)
            });
            db.SaveChanges();

            Service.Service.fillGrid(GetData(db.SalesReps.ToList()), gridView1, gridControl1);

        }

        private void frmRepresentative_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}