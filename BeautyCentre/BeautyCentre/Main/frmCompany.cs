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

        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Service.Service.ResetBoxes(this);
            Service.Service.buttonSaveEditDelete(btn_Update, btn_Edit, btn_Delete, true);
            Service.Service.fillGrid(db.Companies.ToList(),gridView1,gridControl1);
        }

        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.Companies.Add(new Companies { Address = txtAddress.Text, Name = txtName.Text });
        }
    }
}