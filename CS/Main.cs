using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Ribbon;


namespace Rolodex {
    public partial class Main : RibbonForm {
        public Main() {
            InitializeComponent();
            InitSkinGallery();
        }
        
        void InitSkinGallery() {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        
        private void Main_Load(object sender, EventArgs e) {
            this.contactTableAdapter.Fill(this.rolodexDataSet.Contact);
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }

        private void SelectedIndexChanged(object sender, EventArgs e) {
            switch (radioGroup.SelectedIndex) {
                case 0:
                    grid.MainView = view;
                    break;
                case 1:
                    grid.MainView = layout;
                    break;
            }
        }

        private void iFind_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            view.OptionsFind.AlwaysVisible = iFind.Down;
            layout.OptionsFind.AlwaysVisible = iFind.Down;
        }

        private void ViewRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            DataRow row = (DataRow)view.GetFocusedDataRow();
            if (row != null) {
                siStatus.Caption = (String)row["Email"];
            } else {
                siStatus.Caption = String.Empty;
            }
        }

        private void LayoutRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            DataRow row = (DataRow)layout.GetFocusedDataRow();
            if (row != null) {
                siStatus.Caption = (String)row["Email"];
            } else {
                siStatus.Caption = String.Empty;
            }
        }

    }
}