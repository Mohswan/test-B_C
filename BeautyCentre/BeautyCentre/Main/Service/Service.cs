using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections;
using System.Linq;

namespace Main.Service
{

    public static class Service

    {
        /// <summary>
        ///Service.Service.ResetBoxes(this);
        /// </summary>
        /// <param name="this"></param>
        public static void ResetBoxes(Control form)
        {
            if (form is TextEdit)
            {
                ((TextEdit)form).Text = string.Empty;
            }

            foreach (Control child in form.Controls)
            {
                if (child is TextEdit || child is MemoEdit || child is DateEdit || child is LookUpEdit)
                {
                    child.Text = string.Empty;
                }


                if (child is CheckEdit)
                {
                    ((CheckEdit)child).Checked = false;
                }
                ResetBoxes(child);
            }
        }
        /// <summary>
        ///    Control c = Service.Service.Check_Boxes(this, this, dxErrorProvider1)
        ///if ((c.Name != txtNote.Name && c != null && c.Name != this.Name && c.Name != Code.Name))
        ///{
        ///    dxErrorProvider1.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
        ///   dxErrorProvider1.SetError(c, "البيان مطلوب");
        ///    c.Select();
        ///    return;
        ///}
        /// </summary> 
        ///  /// <param name="this"></param>
        /// <param name="this"></param>
        /// <param name="dxErrorProvider1"></param>
        /// 
        public static Control Check_Boxes(Control form, Control child1, DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1)
        {
            dxErrorProvider1.ClearErrors();
            foreach (Control parentDet in form.Controls)
            {
                foreach (Control child in parentDet.Controls)
                {
                    if (child is TextEdit || child is MemoEdit || child is DateEdit)
                    {
                        {
                            if (string.IsNullOrWhiteSpace(child.Text) || child.Text == "0")
                            {
                                child1 = child;
                                return child1;
                            }
                        }
                    }
                }
            }

            return child1;
        }

        /// <summary>
        /// لعملية فتح وغلق الباتونات الخاصة بالعمليات
        /// </summary>
        /// <param name="btn_Update"></param>
        /// <param name="btn_Edit"></param>
        /// <param name="btn_Delete"></param>
        /// <param name="EditDeleteEqFalseSaveEqTrue"></param>
        public static void buttonSaveEditDelete(DevExpress.XtraBars.BarButtonItem btn_Update, DevExpress.XtraBars.BarButtonItem btn_Edit, DevExpress.XtraBars.BarButtonItem btn_Delete, bool EditDeleteEqFalseSaveEqTrue)
        {
            btn_Update.Enabled = EditDeleteEqFalseSaveEqTrue;
            btn_Delete.Enabled = !EditDeleteEqFalseSaveEqTrue;
            btn_Edit.Enabled = !EditDeleteEqFalseSaveEqTrue;
        }
        /// <summary>
        /// fillLoK tools in forms
        /// </summary>
        /// <param name="lok"></param>
        /// <param name="datasource"></param>
        /// <param name="DisplayMember"></param>
        /// <param name="ValueMember"></param>
        /// <param name="NullText"></param>
        /// <param name="captionCol1"></param>
        /// <param name="captionCol2"></param
        public static void fillLoK(DevExpress.XtraEditors.LookUpEdit lok, object datasource, string DisplayMember, string ValueMember, string NullText = null, string captionCol1 = null, string captionCol2 = null)
        {
            lok.Properties.Columns.Clear();
            lok.Properties.DataSource = datasource;
            lok.Properties.DisplayMember = DisplayMember;
            lok.Properties.ValueMember = ValueMember;
            lok.Properties.NullText = NullText;
            lok.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayMember, captionCol1));
            lok.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(ValueMember, captionCol2));
        }
        public static void fillCombo(DevExpress.XtraEditors.ComboBoxEdit combo, IEnumerable<string> datasource)
        {
            combo.Properties.Items.Clear();
            foreach (var item in datasource)
            {
                combo.Properties.Items.Add(item);
            }

        }
        /// <summary>
        /// لملئ الجريد بالبيانات
        /// </summary>
        /// <param name="list"></param>
        /// <param name="gridview"></param>
        /// <param name="gridcontrol"></param>
        public static void fillGrid(object list, DevExpress.XtraGrid.Views.Grid.GridView gridview, DevExpress.XtraGrid.GridControl gridcontrol)
        {
            gridview.Columns.Clear();
            gridcontrol.DataSource = list;
            gridview.BestFitColumns();

            gridview.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridview.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridview.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;

            gridview.FixedLineWidth = 1;
            gridview.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridview.GridControl = gridcontrol;
            gridview.GroupPanelText = "يمكنك سحب  الحقل ووضعه هنا ";

            gridview.OptionsBehavior.Editable = false;
            gridview.OptionsCustomization.AllowRowSizing = true;
            gridview.OptionsFind.AlwaysVisible = true;
            gridview.OptionsFind.FindNullPrompt = "ابحث عن اى قيمه وسيتم الاستعلام عنها";
            gridview.OptionsLayout.Columns.AddNewColumns = false;
            gridview.OptionsPrint.PrintPreview = true;
            gridview.OptionsView.BestFitMaxRowCount = 2;
            gridview.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            gridview.OptionsView.ColumnAutoWidth = false;
            gridview.OptionsView.EnableAppearanceEvenRow = true;
            gridview.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            gridview.PaintStyleName = "Skin";
            gridview.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
        }
        public static void GridPrev(object list, DevExpress.XtraGrid.Views.Grid.GridView gridview, DevExpress.XtraGrid.GridControl gridcontrol)
        {
            gridview.Columns.Clear();
            //IList collection = (IList)list;

            //Service.data = list;
            gridcontrol.DataSource = list;

            gridview.BestFitColumns();
            gridview.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridview.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            RepositoryItemButtonEdit buttonEdit1 = new RepositoryItemButtonEdit();
            buttonEdit1.Buttons[0].Kind = ButtonPredefines.Delete;
            buttonEdit1.TextEditStyle = TextEditStyles.HideTextEditor;
            buttonEdit1.ButtonClick += new ButtonPressedEventHandler(buttonEdit_ButtonClick2);

            GridColumn unbColumn1 = gridview.Columns.AddField("حذف");
            unbColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            unbColumn1.VisibleIndex = gridview.Columns.Count;
            unbColumn1.ColumnEdit = buttonEdit1;

            gridview.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            Service.gridview = gridview;

        }
        private static object data;
        private static object datarow;
        private static DevExpress.XtraGrid.GridControl gridcontrol;
        private static DevExpress.XtraGrid.Views.Grid.GridView gridview;

        private static void buttonEdit_ButtonClick2(object sender, ButtonPressedEventArgs e)
        {
            IList collection = (IList)Service.data;
         //   collection.Remove(

            ButtonEdit ed = Service.gridview.ActiveEditor as ButtonEdit;
            if (ed == null) return;
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
              Service.gridview.DeleteRow(Service.gridview.FocusedRowHandle);


        }

    }
}
