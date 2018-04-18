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
    public partial class frmSection : DevExpress.XtraEditors.XtraForm
    {
        AppDBContext db = new AppDBContext();

        public frmSection()
        {
            InitializeComponent();
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Service.Service.fillGrid(db.Sections.ToList(), gridView1, gridControl1);

        }

        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.Sections.Add(new Sections
            {
                Name=txtName.Text,

                UserAdd=db.Users.Find(0),
                UserUpdate=db.Users.Find(0)
                
            });
            db.SaveChanges();
        }
    }
}