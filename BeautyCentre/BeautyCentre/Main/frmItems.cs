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
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        AppDBContext db = new AppDBContext();
        public frmItems()
        {
            InitializeComponent();
            Service.Service.fillLoK(lokCom, db.Companies.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الشركة", "اسم الشركة", "كود الشركة");
            Service.Service.fillLoK(lokCat, db.CatItems.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الشركة", "اسم الشركة", "كود الشركة");
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

            db.Items.Add(new Items
            {
                Name = txtName.Text,

                Data = txtData.Text,
                Precautions = txtPrecautions.Text,
                Cartoonprice = Convert.ToDecimal(txtSalCartoon.Text),
                Unitprice = Convert.ToDecimal(txtSalUnit.Text),
               Packagecost = Convert.ToDecimal(txtSalPackege.Text),
                Minprice = Convert.ToDecimal(txtSalarySal.Text),
            
                
                Purpose = txtPurpose.Text,
                Dose = txtDose.Text,
                


            });
        }

        private void frmItems_Load(object sender, EventArgs e)
        {

        }
    }
}