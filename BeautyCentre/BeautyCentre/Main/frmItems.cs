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
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        App.DLL.AppDBContext db = new App.DLL.AppDBContext();
        public frmItems()
        {
            InitializeComponent();
            Service.Service.fillLoK(lokCom, db.Companies.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الشركة", "اسم الشركة", "كود الشركة");
            Service.Service.fillLoK(lokCat, db.CatItems.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الفئة", "اسم الفئة", "كود الفئة");
            Service.Service.fillCombo(comTypeUnit, db.TypeUnits.ToList().Select(f => f.Name));

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Service.Service.ResetBoxes(this);
            Service.Service.buttonSaveEditDelete(btn_Update, btn_Edit, btn_Delete, true);
        }

        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<App.DLL.TypeUnits> TypeUnits_ = new List<App.DLL.TypeUnits>();
            TypeUnits_.Add(db.TypeUnits.Where(fun => fun.Name == comTypeUnit.Text).SingleOrDefault());
            if (TypeUnits_.Count == 0)
            {
                TypeUnits_.Add(new App.DLL.TypeUnits { Name = comTypeUnit.Text });
            }
            db.Items.Add(new App.DLL.Items
            {
                Name = txtName.Text,

                Data = txtData.Text,
                Precautions = txtPrecautions.Text,
                Cartoonprice = Convert.ToDecimal(txtSalCartoon.Text),
                Unitprice = Convert.ToDecimal(txtSalUnit.Text),
                Packagecost = Convert.ToDecimal(txtSalPackege.Text),
                Minprice = Convert.ToDecimal(txtSalarySal.Text),
                Noofpackagespercartoon = Convert.ToInt32(txtCountPackege.Text),
                Noofunitsperpackage = Convert.ToInt32(txtCountUnit.Text),
                Companies =db.Companies.Find(Convert.ToInt32(lokCom.GetColumnValue("Id"))),
                CatItems= db.CatItems.Find(Convert.ToInt32(lokCat.GetColumnValue("Id"))),
                TypeUnits= TypeUnits_.SingleOrDefault(),
                Purpose = txtPurpose.Text,
                Dose = txtDose.Text,
                


                DateAdd = DateTime.Now.ToString(),
                UserAdd = db.Users.Find(0),
                UserUpdate = db.Users.Find(0)


            });
            db.SaveChanges();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {

        }
    }
}