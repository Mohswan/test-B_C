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
    public partial class frmCategoryItem : DevExpress.XtraEditors.XtraForm
    {
        public frmCategoryItem()
        {
            InitializeComponent();
        }
        AppDBContext db = new AppDBContext();
        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.CatItems.Add(new CatItems
            {
                Name = txtName.Text,
                description=txtNote.Text,

                UserAdd = db.Users.Find(0),
                UserUpdate = db.Users.Find(0),
                DateAdd = DateTime.Now.ToString(),
            });

            db.SaveChanges();
        }
    }
}