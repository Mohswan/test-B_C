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
using DevExpress.XtraEditors.Controls;

namespace Main
{
    public partial class frmRequestItems : DevExpress.XtraEditors.XtraForm
    {
        List<App.DLL.ItemsRequiredpurchases> item = new List<App.DLL.ItemsRequiredpurchases>();
        App.DLL.AppDBContext db = new App.DLL.AppDBContext();
        int idDetails = 0;
        public frmRequestItems()
        {
            InitializeComponent();
            Service.Service.fillLoK(lokItem, db.Items.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الصنف", "اسم الصنف", "كود الصنف");
            Service.Service.fillLoK(lokCom, db.Companies.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الشركة", "اسم الشركة", "كود الشركة");
            Service.Service.fillLoK(lokSection, db.Sections.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم الفرع", "اسم الفرع", "كود الفرع");
            Service.Service.fillLoK(lokRep, db.SalesReps.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم المندوب", "اسم المندوب", "كود المندوب");
            Service.Service.fillLoK(lokTypeItem, db.CatQuanItems.ToList().Select(f => new { f.Name, f.Id }), "Name", "Id", "اسم نوع الكمية", "اسم نوع الكمية", "كود نوع الكمية");

            Service.Service.fillGrid(GetData(db.RequiredpurchaseItems.ToList()), gridView1, gridControl1);
        }

        private void frmRequestItems_Load(object sender, EventArgs e)
        {

        }
        List<MVVM.RequiredpurchaseItems> GetData(List<App.DLL.RequiredpurchaseItems> getRequiredpurchaseItems)
        {
            List<MVVM.RequiredpurchaseItems> requiredpurchaseItems = new List<MVVM.RequiredpurchaseItems>();
            foreach (var item in getRequiredpurchaseItems)
            {
                requiredpurchaseItems.Add(new MVVM.RequiredpurchaseItems
                {

                    Id = item.Id,

                    Companies = item.Companies.Name,
                    SalesReps = item.SalesReps.Name,
                    Date = item.Date,
                    DateEnd = item.DateEnd,
                    Price = item.Price,
                    Note = item.Note,
                    Sections = item.Sections.Name,

                    DateAdd = item.DateAdd,
                    DateUpdate = item.DateUpdate,
                    UserAdd = item.UserAdd.Name,
                    UserUpdate = item.UserUpdate.Name
                });


            }
            return requiredpurchaseItems;
        }

        List<MVVM.ItemsRequiredpurchases> GetDataDetails(List<App.DLL.ItemsRequiredpurchases> getItemsRequiredpurchases)
        {
            List<MVVM.ItemsRequiredpurchases> requiredpurchaseItems = new List<MVVM.ItemsRequiredpurchases>();
            foreach (var item in getItemsRequiredpurchases)
            {
                requiredpurchaseItems.Add(new MVVM.ItemsRequiredpurchases
                {

                    Id = item.Id,

                    amount = item.amount,
                    CatQuanItems = item.CatQuanItems.Name,
                    Items = item.Items.Name,
                    Price = item.Price,
                    Quantity = item.Quantity
                });
            }
            return requiredpurchaseItems;
        }
        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            App.DLL.RequiredpurchaseItems requiredpurchaseItems = new App.DLL.RequiredpurchaseItems
            {
                Companies = db.Companies.Find(lokCom.GetColumnValue("Id")),
                Date = dateRequest.DateTime,
                DateEnd = dateTaslim.DateTime,
                Note = txtNote.Text,
                Price = Convert.ToDecimal(txtSalaryTotal.Text),
                SalesReps = db.SalesReps.Find(lokRep.GetColumnValue("Id")),
                Sections = db.Sections.Find(lokSection.GetColumnValue("Id")),
                DateAdd = DateTime.Now.ToString(),
                UserAdd = db.Users.Find(0),
                UserUpdate = db.Users.Find(0),
            };
            db.RequiredpurchaseItems.Add(requiredpurchaseItems);
            List<App.DLL.ItemsRequiredpurchases> itemsRequiredpurchases = new List<App.DLL.ItemsRequiredpurchases>();


            foreach (var item in item)
            {
                itemsRequiredpurchases.Add(new App.DLL.ItemsRequiredpurchases
                {
                    Items = item.Items,
                    amount = item.amount,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    CatQuanItems = item.CatQuanItems,
                    RequiredpurchaseItems = requiredpurchaseItems
                });
            }
            db.ItemsRequiredpurchases.AddRange(itemsRequiredpurchases);

            db.SaveChanges();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            item.Add(new App.DLL.ItemsRequiredpurchases
            {
                Items = db.Items.Find(lokItem.GetColumnValue("Id")),
                CatQuanItems = db.CatQuanItems.Find(lokTypeItem.GetColumnValue("Id")),
                Price = Convert.ToDecimal(txtSalary.Text),
                Quantity = Convert.ToDouble(txtQuantity.Text),
                Id=idDetails++,
                amount = Convert.ToDecimal(txtSalary.Text) * Convert.ToDecimal(txtQuantity.Text),

            });
            Service.Service.GridPrev(GetDataDetails(item), gridView2, gridControl2);
           
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            item.RemoveAt(gridView2.GetFocusedDataSourceRowIndex());
        }
    }
}