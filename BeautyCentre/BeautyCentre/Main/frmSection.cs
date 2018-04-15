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
        public frmSection()
        {
            InitializeComponent();
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppDBContext db = new AppDBContext();

            Service.Service.fillGrid(db.Sections.ToList(), gridView1, gridControl1);

        }
    }
}