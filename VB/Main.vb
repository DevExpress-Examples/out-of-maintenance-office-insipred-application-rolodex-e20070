Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Ribbon


Namespace Rolodex
	Partial Public Class Main
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
			InitSkinGallery()
		End Sub

		Private Sub InitSkinGallery()
			SkinHelper.InitSkinGallery(rgbiSkins, True)
		End Sub

		Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.contactTableAdapter.Fill(Me.rolodexDataSet.Contact)
		End Sub

		Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
			Close()
		End Sub

		Private Sub SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup.SelectedIndexChanged
			Select Case radioGroup.SelectedIndex
				Case 0
					grid.MainView = view
				Case 1
					grid.MainView = layout
			End Select
		End Sub

		Private Sub iFind_DownChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFind.DownChanged
			view.OptionsFind.AlwaysVisible = iFind.Down
			layout.OptionsFind.AlwaysVisible = iFind.Down
		End Sub

		Private Sub ViewRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles view.FocusedRowChanged
			Dim row As DataRow = CType(view.GetFocusedDataRow(), DataRow)
			If row IsNot Nothing Then
				siStatus.Caption = CType(row("Email"), String)
			Else
				siStatus.Caption = String.Empty
			End If
		End Sub

		Private Sub LayoutRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles layout.FocusedRowChanged
			Dim row As DataRow = CType(layout.GetFocusedDataRow(), DataRow)
			If row IsNot Nothing Then
				siStatus.Caption = CType(row("Email"), String)
			Else
				siStatus.Caption = String.Empty
			End If
		End Sub

	End Class
End Namespace