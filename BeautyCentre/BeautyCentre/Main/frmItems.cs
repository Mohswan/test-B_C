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
        public frmItems()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Service.Service.ResetBoxes(this);
            Service.Service.buttonSaveEditDelete(btn_Update, btn_Edit, btn_Delete, true);
        }
    }
}