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
using App.DLL;

namespace Main
{
    public partial class frmCompany : DevExpress.XtraEditors.XtraForm
    {
        AppDBContext db = new AppDBContext();
        public frmCompany()
        {
            InitializeComponent();
            Service.Service.buttonSaveEditDelete(btn_Update, btn_Edit, btn_Delete, true);
            Service.Service.fillCombo(txtSpectial,db.specializations.ToList().Select(FUN=>FUN.Name));
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Service.Service.ResetBoxes(this);
            Service.Service.buttonSaveEditDelete(btn_Update, btn_Edit, btn_Delete, true);
            Service.Service.fillGrid(db.Companies.ToList(), gridView1, gridControl1);
        }

        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<specializations> specializations_ = new List<specializations>();
            specializations_.Add(db.specializations.Where(fun => fun.Name == txtSpectial.Text).SingleOrDefault());
            if (specializations_.Count == 0)
            {
                specializations_.Add(new specializations { Name = txtSpectial.Text });
            }
            db.Companies.Add(new Companies
                {
                    Address = txtAddress.Text,
                    Name = txtName.Text,
                    taxID = txtId.Text,
                    regID = txtSegel.Text,
                    products = txtProducts.Text,
                    specializations = specializations_.SingleOrDefault(),
                    Mob = txtMob.Text,
                    Tel1 = txtTel.Text,
                    TelWhats = txtWhats.Text,

                    UsersAdd = db.Users.Find(0),
                    UserUpdate = db.Users.Find(0),
                    DateAdd = DateTime.Now.ToString(),
                });
                
            db.SaveChanges();
        }

    }
}