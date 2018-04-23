Imports Microsoft.VisualBasic
Imports System
Namespace Rolodex
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
			Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
			Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
			Me.viewGroup = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
			Me.popupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit()
			Me.iExit = New DevExpress.XtraBars.BarButtonItem()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.someLabelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.someLabelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
			Me.iFind = New DevExpress.XtraBars.BarButtonItem()
			Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
			Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
			Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
			Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
			Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
			Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
			Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
			Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
			Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
			Me.grid = New DevExpress.XtraGrid.GridControl()
			Me.contactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.rolodexDataSet = New Rolodex.RolodexDataSet()
			Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageGender = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.smallImages = New DevExpress.Utils.ImageCollection(Me.components)
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colZip = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAZ = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layout = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.layoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn3 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn4 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn5 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn6 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn7 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn8 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn9 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn10 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn11 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn12 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewColumn13 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.contactTableAdapter = New Rolodex.RolodexDataSetTableAdapters.ContactTableAdapter()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.layoutViewField_colFirstName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colLastName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colEmail = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colPhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colNotes = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.Group1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutViewField_colPicture = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colCity = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colAddress = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colState = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colZip = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colGender = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colAZ = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl.SuspendLayout()
			CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarControl.SuspendLayout()
			Me.navBarGroupControlContainer1.SuspendLayout()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer2.SuspendLayout()
			CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer1.SuspendLayout()
			CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.contactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rolodexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageGender, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.smallImages, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layout, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colLastName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colEmail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPhone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colNotes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Group1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPicture, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colState, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colZip, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colGender, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colAZ, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainerControl
			' 
			Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl.Location = New System.Drawing.Point(0, 144)
			Me.splitContainerControl.Name = "splitContainerControl"
			Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6)
			Me.splitContainerControl.Panel1.Controls.Add(Me.navBarControl)
			Me.splitContainerControl.Panel1.Text = "Panel1"
			Me.splitContainerControl.Panel2.Controls.Add(Me.grid)
			Me.splitContainerControl.Panel2.Text = "Panel2"
			Me.splitContainerControl.Size = New System.Drawing.Size(1100, 525)
			Me.splitContainerControl.SplitterPosition = 110
			Me.splitContainerControl.TabIndex = 0
			Me.splitContainerControl.Text = "splitContainerControl1"
			' 
			' navBarControl
			' 
			Me.navBarControl.ActiveGroup = Me.viewGroup
			Me.navBarControl.Controls.Add(Me.navBarGroupControlContainer1)
			Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.viewGroup})
			Me.navBarControl.LargeImages = Me.navbarImageCollectionLarge
			Me.navBarControl.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl.Name = "navBarControl"
			Me.navBarControl.OptionsNavPane.ExpandedWidth = 110
			Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
			Me.navBarControl.Size = New System.Drawing.Size(110, 513)
			Me.navBarControl.SmallImages = Me.navbarImageCollection
			Me.navBarControl.StoreDefaultPaintStyleName = True
			Me.navBarControl.TabIndex = 0
			' 
			' viewGroup
			' 
			Me.viewGroup.Caption = "View"
			Me.viewGroup.ControlContainer = Me.navBarGroupControlContainer1
			Me.viewGroup.Expanded = True
			Me.viewGroup.GroupClientHeight = 80
			Me.viewGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.viewGroup.Name = "viewGroup"
			Me.viewGroup.SmallImage = (CType(resources.GetObject("viewGroup.SmallImage"), System.Drawing.Image))
			' 
			' navBarGroupControlContainer1
			' 
			Me.navBarGroupControlContainer1.Controls.Add(Me.radioGroup)
			Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
			Me.navBarGroupControlContainer1.Size = New System.Drawing.Size(110, 408)
			Me.navBarGroupControlContainer1.TabIndex = 0
			' 
			' radioGroup
			' 
			Me.radioGroup.Dock = System.Windows.Forms.DockStyle.Top
			Me.radioGroup.EditValue = "List"
			Me.radioGroup.Location = New System.Drawing.Point(0, 0)
			Me.radioGroup.MenuManager = Me.ribbonControl
			Me.radioGroup.Name = "radioGroup"
			Me.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.radioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem("List", "List"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Card", "Card")})
			Me.radioGroup.Size = New System.Drawing.Size(110, 65)
			Me.radioGroup.TabIndex = 0
'			Me.radioGroup.SelectedIndexChanged += New System.EventHandler(Me.SelectedIndexChanged);
			' 
			' ribbonControl
			' 
			Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
			Me.ribbonControl.ApplicationButtonText = Nothing
			Me.ribbonControl.ExpandCollapseItem.Id = 0
			Me.ribbonControl.Images = Me.ribbonImageCollection
			Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.iFind, Me.iExit, Me.siStatus, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins})
			Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
			Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl.MaxItemId = 62
			Me.ribbonControl.Name = "ribbonControl"
			Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.homeRibbonPage})
			Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.ribbonControl.Size = New System.Drawing.Size(1100, 144)
			Me.ribbonControl.StatusBar = Me.ribbonStatusBar
			' 
			' appMenu
			' 
			Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2
			Me.appMenu.ItemLinks.Add(Me.iExit)
			Me.appMenu.Name = "appMenu"
			Me.appMenu.Ribbon = Me.ribbonControl
			Me.appMenu.RightPaneControlContainer = Me.popupControlContainer1
			Me.appMenu.ShowRightPane = True
			' 
			' popupControlContainer2
			' 
			Me.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.popupControlContainer2.Appearance.Options.UseBackColor = True
			Me.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer2.Controls.Add(Me.buttonEdit)
			Me.popupControlContainer2.Location = New System.Drawing.Point(238, 289)
			Me.popupControlContainer2.Name = "popupControlContainer2"
			Me.popupControlContainer2.Ribbon = Me.ribbonControl
			Me.popupControlContainer2.Size = New System.Drawing.Size(118, 28)
			Me.popupControlContainer2.TabIndex = 3
			Me.popupControlContainer2.Visible = False
			' 
			' buttonEdit
			' 
			Me.buttonEdit.EditValue = "Some Text"
			Me.buttonEdit.Location = New System.Drawing.Point(3, 5)
			Me.buttonEdit.MenuManager = Me.ribbonControl
			Me.buttonEdit.Name = "buttonEdit"
			Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit.TabIndex = 0
			' 
			' iExit
			' 
			Me.iExit.Caption = "Exit"
			Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
			Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
			Me.iExit.Id = 20
			Me.iExit.ImageIndex = 6
			Me.iExit.LargeImageIndex = 6
			Me.iExit.Name = "iExit"
'			Me.iExit.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.iExit_ItemClick);
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.popupControlContainer1.Appearance.Options.UseBackColor = True
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Controls.Add(Me.someLabelControl2)
			Me.popupControlContainer1.Controls.Add(Me.someLabelControl1)
			Me.popupControlContainer1.Location = New System.Drawing.Point(111, 197)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Ribbon = Me.ribbonControl
			Me.popupControlContainer1.Size = New System.Drawing.Size(76, 70)
			Me.popupControlContainer1.TabIndex = 2
			Me.popupControlContainer1.Visible = False
			' 
			' someLabelControl2
			' 
			Me.someLabelControl2.Location = New System.Drawing.Point(3, 57)
			Me.someLabelControl2.Name = "someLabelControl2"
			Me.someLabelControl2.Size = New System.Drawing.Size(49, 13)
			Me.someLabelControl2.TabIndex = 0
			Me.someLabelControl2.Text = "Some Info"
			' 
			' someLabelControl1
			' 
			Me.someLabelControl1.Location = New System.Drawing.Point(3, 3)
			Me.someLabelControl1.Name = "someLabelControl1"
			Me.someLabelControl1.Size = New System.Drawing.Size(49, 13)
			Me.someLabelControl1.TabIndex = 0
			Me.someLabelControl1.Text = "Some Info"
			' 
			' ribbonImageCollection
			' 
			Me.ribbonImageCollection.ImageStream = (CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
			Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
			' 
			' iFind
			' 
			Me.iFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iFind.Caption = "Find"
			Me.iFind.Description = "Searches for the specified info."
			Me.iFind.Hint = "Searches for the specified info"
			Me.iFind.Id = 15
			Me.iFind.ImageIndex = 3
			Me.iFind.LargeImageIndex = 3
			Me.iFind.Name = "iFind"
			Me.iFind.RibbonStyle = (CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
'			Me.iFind.DownChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.iFind_DownChanged);
			' 
			' siStatus
			' 
			Me.siStatus.Caption = "Some Status Info"
			Me.siStatus.Id = 31
			Me.siStatus.Name = "siStatus"
			Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' iBoldFontStyle
			' 
			Me.iBoldFontStyle.Caption = "Bold"
			Me.iBoldFontStyle.Id = 53
			Me.iBoldFontStyle.ImageIndex = 9
			Me.iBoldFontStyle.Name = "iBoldFontStyle"
			' 
			' iItalicFontStyle
			' 
			Me.iItalicFontStyle.Caption = "Italic"
			Me.iItalicFontStyle.Id = 54
			Me.iItalicFontStyle.ImageIndex = 10
			Me.iItalicFontStyle.Name = "iItalicFontStyle"
			' 
			' iUnderlinedFontStyle
			' 
			Me.iUnderlinedFontStyle.Caption = "Underlined"
			Me.iUnderlinedFontStyle.Id = 55
			Me.iUnderlinedFontStyle.ImageIndex = 11
			Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
			' 
			' iLeftTextAlign
			' 
			Me.iLeftTextAlign.Caption = "Left"
			Me.iLeftTextAlign.Id = 57
			Me.iLeftTextAlign.ImageIndex = 12
			Me.iLeftTextAlign.Name = "iLeftTextAlign"
			' 
			' iCenterTextAlign
			' 
			Me.iCenterTextAlign.Caption = "Center"
			Me.iCenterTextAlign.Id = 58
			Me.iCenterTextAlign.ImageIndex = 13
			Me.iCenterTextAlign.Name = "iCenterTextAlign"
			' 
			' iRightTextAlign
			' 
			Me.iRightTextAlign.Caption = "Right"
			Me.iRightTextAlign.Id = 59
			Me.iRightTextAlign.ImageIndex = 14
			Me.iRightTextAlign.Name = "iRightTextAlign"
			' 
			' rgbiSkins
			' 
			Me.rgbiSkins.Caption = "Skins"
			' 
			' 
			' 
			Me.rgbiSkins.Gallery.AllowHoverImages = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiSkins.Gallery.ColumnCount = 4
			Me.rgbiSkins.Gallery.FixedHoverImageSize = False
			Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
			Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
			Me.rgbiSkins.Gallery.RowCount = 4
			Me.rgbiSkins.Id = 60
			Me.rgbiSkins.Name = "rgbiSkins"
			' 
			' ribbonImageCollectionLarge
			' 
			Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
			Me.ribbonImageCollectionLarge.ImageStream = (CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
			Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
			' 
			' homeRibbonPage
			' 
			Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.fileRibbonPageGroup, Me.skinsRibbonPageGroup, Me.exitRibbonPageGroup})
			Me.homeRibbonPage.Name = "homeRibbonPage"
			Me.homeRibbonPage.Text = "Home"
			' 
			' fileRibbonPageGroup
			' 
			Me.fileRibbonPageGroup.ItemLinks.Add(Me.iFind)
			Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
			Me.fileRibbonPageGroup.Text = "File"
			' 
			' skinsRibbonPageGroup
			' 
			Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
			Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
			Me.skinsRibbonPageGroup.ShowCaptionButton = False
			Me.skinsRibbonPageGroup.Text = "Skins"
			' 
			' exitRibbonPageGroup
			' 
			Me.exitRibbonPageGroup.ItemLinks.Add(Me.iExit)
			Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
			Me.exitRibbonPageGroup.Text = "Exit"
			' 
			' ribbonStatusBar
			' 
			Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
			Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 669)
			Me.ribbonStatusBar.Name = "ribbonStatusBar"
			Me.ribbonStatusBar.Ribbon = Me.ribbonControl
			Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 31)
			' 
			' navbarImageCollectionLarge
			' 
			Me.navbarImageCollectionLarge.ImageStream = (CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
			Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png")
			Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png")
			' 
			' navbarImageCollection
			' 
			Me.navbarImageCollection.ImageStream = (CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
			Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
			Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
			Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
			Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
			Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
			Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
			' 
			' grid
			' 
			Me.grid.DataSource = Me.contactBindingSource
			Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.grid.Location = New System.Drawing.Point(0, 0)
			Me.grid.MainView = Me.view
			Me.grid.Name = "grid"
			Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageGender})
			Me.grid.Size = New System.Drawing.Size(973, 513)
			Me.grid.TabIndex = 0
			Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.view, Me.layout})
			' 
			' contactBindingSource
			' 
			Me.contactBindingSource.DataMember = "Contact"
			Me.contactBindingSource.DataSource = Me.rolodexDataSet
			' 
			' rolodexDataSet
			' 
			Me.rolodexDataSet.DataSetName = "RolodexDataSet"
			Me.rolodexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' view
			' 
			Me.view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colGender, Me.colFirstName, Me.colLastName, Me.colEmail, Me.colPhone, Me.colAddress, Me.colCity, Me.colState, Me.colZip, Me.colPicture, Me.colNotes, Me.colAZ})
			Me.view.CustomizationFormBounds = New System.Drawing.Rectangle(715, 422, 210, 326)
			Me.view.GridControl = Me.grid
			Me.view.GroupCount = 1
			Me.view.GroupFormat = "[#image]{1} {2}"
			Me.view.Name = "view"
			Me.view.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAZ, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.view.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.ViewRowChanged);
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			' 
			' colGender
			' 
			Me.colGender.Caption = " "
			Me.colGender.ColumnEdit = Me.repositoryItemImageGender
			Me.colGender.FieldName = "Gender"
			Me.colGender.Name = "colGender"
			Me.colGender.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
			Me.colGender.Visible = True
			Me.colGender.VisibleIndex = 0
			Me.colGender.Width = 41
			' 
			' repositoryItemImageGender
			' 
			Me.repositoryItemImageGender.AutoHeight = False
			Me.repositoryItemImageGender.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageGender.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "M", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "F", 1)})
			Me.repositoryItemImageGender.Name = "repositoryItemImageGender"
			Me.repositoryItemImageGender.SmallImages = Me.smallImages
			' 
			' smallImages
			' 
			Me.smallImages.ImageStream = (CType(resources.GetObject("smallImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.smallImages.Images.SetKeyName(0, "Mr.png")
			Me.smallImages.Images.SetKeyName(1, "Mrs.png")
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			Me.colFirstName.Width = 214
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			Me.colLastName.Width = 214
			' 
			' colEmail
			' 
			Me.colEmail.FieldName = "Email"
			Me.colEmail.Name = "colEmail"
			Me.colEmail.Visible = True
			Me.colEmail.VisibleIndex = 3
			Me.colEmail.Width = 214
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 4
			Me.colPhone.Width = 217
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			' 
			' colState
			' 
			Me.colState.FieldName = "State"
			Me.colState.Name = "colState"
			' 
			' colZip
			' 
			Me.colZip.FieldName = "Zip"
			Me.colZip.Name = "colZip"
			' 
			' colPicture
			' 
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.Name = "colPicture"
			' 
			' colNotes
			' 
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.Name = "colNotes"
			' 
			' colAZ
			' 
			Me.colAZ.Caption = "A-Z"
			Me.colAZ.FieldName = "colAZ"
			Me.colAZ.Name = "colAZ"
			Me.colAZ.UnboundExpression = "Substring([FirstName], 0, 1)"
			Me.colAZ.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.colAZ.Visible = True
			Me.colAZ.VisibleIndex = 0
			' 
			' layout
			' 
			Me.layout.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.layout.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.layoutViewColumn1, Me.layoutViewColumn2, Me.layoutViewColumn3, Me.layoutViewColumn4, Me.layoutViewColumn5, Me.layoutViewColumn6, Me.layoutViewColumn7, Me.layoutViewColumn8, Me.layoutViewColumn9, Me.layoutViewColumn10, Me.layoutViewColumn11, Me.layoutViewColumn12, Me.layoutViewColumn13})
			Me.layout.GridControl = Me.grid
			Me.layout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colID, Me.layoutViewField_colGender, Me.layoutViewField_colAZ})
			Me.layout.Name = "layout"
			Me.layout.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
			Me.layout.TemplateCard = Me.layoutViewCard1
'			Me.layout.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.LayoutRowChanged);
			' 
			' layoutViewColumn1
			' 
			Me.layoutViewColumn1.FieldName = "ID"
			Me.layoutViewColumn1.LayoutViewField = Me.layoutViewField_colID
			Me.layoutViewColumn1.Name = "layoutViewColumn1"
			' 
			' layoutViewColumn2
			' 
			Me.layoutViewColumn2.Caption = " "
			Me.layoutViewColumn2.ColumnEdit = Me.repositoryItemImageGender
			Me.layoutViewColumn2.FieldName = "Gender"
			Me.layoutViewColumn2.LayoutViewField = Me.layoutViewField_colGender
			Me.layoutViewColumn2.Name = "layoutViewColumn2"
			Me.layoutViewColumn2.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
			Me.layoutViewColumn2.Width = 41
			' 
			' layoutViewColumn3
			' 
			Me.layoutViewColumn3.FieldName = "FirstName"
			Me.layoutViewColumn3.LayoutViewField = Me.layoutViewField_colFirstName
			Me.layoutViewColumn3.Name = "layoutViewColumn3"
			Me.layoutViewColumn3.Width = 214
			' 
			' layoutViewColumn4
			' 
			Me.layoutViewColumn4.FieldName = "LastName"
			Me.layoutViewColumn4.LayoutViewField = Me.layoutViewField_colLastName
			Me.layoutViewColumn4.Name = "layoutViewColumn4"
			Me.layoutViewColumn4.Width = 214
			' 
			' layoutViewColumn5
			' 
			Me.layoutViewColumn5.FieldName = "Email"
			Me.layoutViewColumn5.LayoutViewField = Me.layoutViewField_colEmail
			Me.layoutViewColumn5.Name = "layoutViewColumn5"
			Me.layoutViewColumn5.Width = 214
			' 
			' layoutViewColumn6
			' 
			Me.layoutViewColumn6.FieldName = "Phone"
			Me.layoutViewColumn6.LayoutViewField = Me.layoutViewField_colPhone
			Me.layoutViewColumn6.Name = "layoutViewColumn6"
			Me.layoutViewColumn6.Width = 217
			' 
			' layoutViewColumn7
			' 
			Me.layoutViewColumn7.FieldName = "Address"
			Me.layoutViewColumn7.LayoutViewField = Me.layoutViewField_colAddress
			Me.layoutViewColumn7.Name = "layoutViewColumn7"
			' 
			' layoutViewColumn8
			' 
			Me.layoutViewColumn8.FieldName = "City"
			Me.layoutViewColumn8.LayoutViewField = Me.layoutViewField_colCity
			Me.layoutViewColumn8.Name = "layoutViewColumn8"
			' 
			' layoutViewColumn9
			' 
			Me.layoutViewColumn9.FieldName = "State"
			Me.layoutViewColumn9.LayoutViewField = Me.layoutViewField_colState
			Me.layoutViewColumn9.Name = "layoutViewColumn9"
			' 
			' layoutViewColumn10
			' 
			Me.layoutViewColumn10.FieldName = "Zip"
			Me.layoutViewColumn10.LayoutViewField = Me.layoutViewField_colZip
			Me.layoutViewColumn10.Name = "layoutViewColumn10"
			' 
			' layoutViewColumn11
			' 
			Me.layoutViewColumn11.FieldName = "Picture"
			Me.layoutViewColumn11.LayoutViewField = Me.layoutViewField_colPicture
			Me.layoutViewColumn11.Name = "layoutViewColumn11"
			' 
			' layoutViewColumn12
			' 
			Me.layoutViewColumn12.FieldName = "Notes"
			Me.layoutViewColumn12.LayoutViewField = Me.layoutViewField_colNotes
			Me.layoutViewColumn12.Name = "layoutViewColumn12"
			' 
			' layoutViewColumn13
			' 
			Me.layoutViewColumn13.Caption = "A-Z"
			Me.layoutViewColumn13.FieldName = "colAZ"
			Me.layoutViewColumn13.LayoutViewField = Me.layoutViewField_colAZ
			Me.layoutViewColumn13.Name = "layoutViewColumn13"
			Me.layoutViewColumn13.UnboundExpression = "Substring([FirstName], 0, 1)"
			Me.layoutViewColumn13.UnboundType = DevExpress.Data.UnboundColumnType.String
			' 
			' contactTableAdapter
			' 
			Me.contactTableAdapter.ClearBeforeFill = True
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colFirstName, Me.layoutViewField_colLastName, Me.layoutViewField_colEmail, Me.layoutViewField_colPhone, Me.layoutViewField_colNotes, Me.Group1, Me.layoutViewField_colPicture})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' layoutViewField_colFirstName
			' 
			Me.layoutViewField_colFirstName.EditorPreferredWidth = 122
			Me.layoutViewField_colFirstName.Location = New System.Drawing.Point(0, 24)
			Me.layoutViewField_colFirstName.Name = "layoutViewField_colFirstName"
			Me.layoutViewField_colFirstName.Size = New System.Drawing.Size(186, 24)
			Me.layoutViewField_colFirstName.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colFirstName.TextToControlDistance = 5
			' 
			' layoutViewField_colLastName
			' 
			Me.layoutViewField_colLastName.EditorPreferredWidth = 122
			Me.layoutViewField_colLastName.Location = New System.Drawing.Point(0, 48)
			Me.layoutViewField_colLastName.Name = "layoutViewField_colLastName"
			Me.layoutViewField_colLastName.Size = New System.Drawing.Size(186, 24)
			Me.layoutViewField_colLastName.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colLastName.TextToControlDistance = 5
			' 
			' layoutViewField_colEmail
			' 
			Me.layoutViewField_colEmail.EditorPreferredWidth = 122
			Me.layoutViewField_colEmail.Location = New System.Drawing.Point(0, 72)
			Me.layoutViewField_colEmail.Name = "layoutViewField_colEmail"
			Me.layoutViewField_colEmail.Size = New System.Drawing.Size(186, 24)
			Me.layoutViewField_colEmail.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colEmail.TextToControlDistance = 5
			' 
			' layoutViewField_colPhone
			' 
			Me.layoutViewField_colPhone.EditorPreferredWidth = 122
			Me.layoutViewField_colPhone.Location = New System.Drawing.Point(0, 96)
			Me.layoutViewField_colPhone.Name = "layoutViewField_colPhone"
			Me.layoutViewField_colPhone.Size = New System.Drawing.Size(186, 24)
			Me.layoutViewField_colPhone.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colPhone.TextToControlDistance = 5
			' 
			' layoutViewField_colNotes
			' 
			Me.layoutViewField_colNotes.EditorPreferredWidth = 122
			Me.layoutViewField_colNotes.Location = New System.Drawing.Point(0, 120)
			Me.layoutViewField_colNotes.Name = "layoutViewField_colNotes"
			Me.layoutViewField_colNotes.Size = New System.Drawing.Size(186, 24)
			Me.layoutViewField_colNotes.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colNotes.TextToControlDistance = 5
			' 
			' Group1
			' 
			Me.Group1.CustomizationFormText = "Address"
			Me.Group1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colCity, Me.layoutViewField_colAddress, Me.layoutViewField_colState, Me.layoutViewField_colZip})
			Me.Group1.Location = New System.Drawing.Point(0, 144)
			Me.Group1.Name = "Group1"
			Me.Group1.Size = New System.Drawing.Size(186, 109)
			Me.Group1.Text = "Address"
			' 
			' layoutViewField_colPicture
			' 
			Me.layoutViewField_colPicture.EditorPreferredWidth = 182
			Me.layoutViewField_colPicture.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colPicture.Name = "layoutViewField_colPicture"
			Me.layoutViewField_colPicture.Size = New System.Drawing.Size(186, 24)
			Me.layoutViewField_colPicture.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPicture.TextToControlDistance = 0
			Me.layoutViewField_colPicture.TextVisible = False
			' 
			' layoutViewField_colCity
			' 
			Me.layoutViewField_colCity.EditorPreferredWidth = 66
			Me.layoutViewField_colCity.Location = New System.Drawing.Point(0, 24)
			Me.layoutViewField_colCity.Name = "layoutViewField_colCity"
			Me.layoutViewField_colCity.Size = New System.Drawing.Size(70, 42)
			Me.layoutViewField_colCity.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colCity.TextToControlDistance = 0
			Me.layoutViewField_colCity.TextVisible = False
			' 
			' layoutViewField_colAddress
			' 
			Me.layoutViewField_colAddress.EditorPreferredWidth = 158
			Me.layoutViewField_colAddress.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colAddress.Name = "layoutViewField_colAddress"
			Me.layoutViewField_colAddress.Size = New System.Drawing.Size(162, 24)
			Me.layoutViewField_colAddress.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colAddress.TextToControlDistance = 0
			Me.layoutViewField_colAddress.TextVisible = False
			' 
			' layoutViewField_colState
			' 
			Me.layoutViewField_colState.EditorPreferredWidth = 42
			Me.layoutViewField_colState.Location = New System.Drawing.Point(70, 24)
			Me.layoutViewField_colState.Name = "layoutViewField_colState"
			Me.layoutViewField_colState.Size = New System.Drawing.Size(46, 42)
			Me.layoutViewField_colState.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colState.TextToControlDistance = 0
			Me.layoutViewField_colState.TextVisible = False
			' 
			' layoutViewField_colZip
			' 
			Me.layoutViewField_colZip.EditorPreferredWidth = 42
			Me.layoutViewField_colZip.Location = New System.Drawing.Point(116, 24)
			Me.layoutViewField_colZip.Name = "layoutViewField_colZip"
			Me.layoutViewField_colZip.Size = New System.Drawing.Size(46, 42)
			Me.layoutViewField_colZip.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colZip.TextToControlDistance = 0
			Me.layoutViewField_colZip.TextVisible = False
			' 
			' layoutViewField_colID
			' 
			Me.layoutViewField_colID.EditorPreferredWidth = 20
			Me.layoutViewField_colID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colID.Name = "layoutViewField_colID"
			Me.layoutViewField_colID.Size = New System.Drawing.Size(203, 235)
			Me.layoutViewField_colID.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colID.TextToControlDistance = 5
			' 
			' layoutViewField_colGender
			' 
			Me.layoutViewField_colGender.EditorPreferredWidth = 20
			Me.layoutViewField_colGender.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colGender.Name = "layoutViewField_colGender"
			Me.layoutViewField_colGender.Size = New System.Drawing.Size(203, 235)
			Me.layoutViewField_colGender.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colGender.TextToControlDistance = 5
			' 
			' layoutViewField_colAZ
			' 
			Me.layoutViewField_colAZ.EditorPreferredWidth = 20
			Me.layoutViewField_colAZ.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colAZ.Name = "layoutViewField_colAZ"
			Me.layoutViewField_colAZ.Size = New System.Drawing.Size(203, 235)
			Me.layoutViewField_colAZ.TextSize = New System.Drawing.Size(55, 13)
			Me.layoutViewField_colAZ.TextToControlDistance = 5
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1100, 700)
			Me.Controls.Add(Me.splitContainerControl)
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Controls.Add(Me.popupControlContainer2)
			Me.Controls.Add(Me.ribbonStatusBar)
			Me.Controls.Add(Me.ribbonControl)
			Me.Name = "Main"
			Me.Ribbon = Me.ribbonControl
			Me.StatusBar = Me.ribbonStatusBar
			Me.Text = "Rolodex"
'			Me.Load += New System.EventHandler(Me.Main_Load);
			CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl.ResumeLayout(False)
			CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarControl.ResumeLayout(False)
			Me.navBarGroupControlContainer1.ResumeLayout(False)
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer2.ResumeLayout(False)
			CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer1.ResumeLayout(False)
			Me.popupControlContainer1.PerformLayout()
			CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.contactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rolodexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageGender, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.smallImages, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layout, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colFirstName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colLastName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colEmail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPhone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colNotes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Group1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPicture, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colState, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colZip, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colGender, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colAZ, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
		Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
		Private WithEvents iFind As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
		Private siStatus As DevExpress.XtraBars.BarStaticItem
		Private iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
		Private iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
		Private iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
		Private iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
		Private iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
		Private iRightTextAlign As DevExpress.XtraBars.BarButtonItem
		Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
		Private homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private someLabelControl2 As DevExpress.XtraEditors.LabelControl
		Private someLabelControl1 As DevExpress.XtraEditors.LabelControl
		Private popupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
		Private buttonEdit As DevExpress.XtraEditors.ButtonEdit
		Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private ribbonImageCollection As DevExpress.Utils.ImageCollection
		Private ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
		Private navBarControl As DevExpress.XtraNavBar.NavBarControl
		Private navbarImageCollection As DevExpress.Utils.ImageCollection
		Private navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
		Private grid As DevExpress.XtraGrid.GridControl
		Private WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
		Private rolodexDataSet As RolodexDataSet
		Private contactBindingSource As System.Windows.Forms.BindingSource
		Private contactTableAdapter As Rolodex.RolodexDataSetTableAdapters.ContactTableAdapter
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colGender As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmail As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colState As DevExpress.XtraGrid.Columns.GridColumn
		Private colZip As DevExpress.XtraGrid.Columns.GridColumn
		Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
		Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageGender As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private smallImages As DevExpress.Utils.ImageCollection
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private colAZ As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents layout As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private layoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn3 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn4 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn5 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn6 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn7 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn8 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn9 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn10 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn11 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn12 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn13 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private viewGroup As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private WithEvents radioGroup As DevExpress.XtraEditors.RadioGroup
		Private layoutViewField_colID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colGender As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colFirstName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colLastName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colEmail As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPhone As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colAddress As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colCity As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colState As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colZip As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPicture As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colNotes As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colAZ As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private Group1 As DevExpress.XtraLayout.LayoutControlGroup

	End Class
End Namespace
