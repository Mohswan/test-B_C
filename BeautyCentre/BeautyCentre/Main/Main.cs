using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Main
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmMachine());

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmSection());
        }
        public void CALLFORM(XtraForm FRM)
        {
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmEmp());

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmExport());

            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmSalary());

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmDiagnose());

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCourse());

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRoom());

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCompany());

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRepresentative());

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCategoryItem());

        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmItems());

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmTool());

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRequestItems());

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRequestTools());

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRequestMachine());

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmPurchaseItems());

        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmConvertMachine());

        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmConvertTool());

        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmConvertItem());

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmReturnItems());

        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmReturnTools());

        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmReturnMachine());

        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmPurchaseMachine());

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmPurchaseTools());

        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCashCompany());

        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCashMonthCompany());

        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRepaymentCompany());

        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmExportOther());

        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmMonyReturn());

        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmEmployeeSalary());

        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmEmployeeSol());

        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmEmployeeGzaaa());

        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCustMonthSalary());

        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmCallDate());

        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmRoomMachine());

        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmReservationCust());

        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmReservationRep());

        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            CALLFORM(new frmReservationTool());

        }
    }
}