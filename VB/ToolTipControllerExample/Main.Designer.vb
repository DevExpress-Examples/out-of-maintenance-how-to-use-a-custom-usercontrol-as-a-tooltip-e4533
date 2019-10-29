Namespace ToolTipControllerExample
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
			If disposing AndAlso flyoutControl_Renamed IsNot Nothing Then
				flyoutControl_Renamed.Dispose()
				flyoutControl_Renamed = Nothing
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
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colParentID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colText = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colInfo = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colValue = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colDt = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colState = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colImage = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colDetail = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
			Me.treeList1.DataSource = Me.recordBindingSource
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.ImageIndexFieldName = "IMAGEINDEX"
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.ParentFieldName = "PARENTID"
			Me.treeList1.Size = New System.Drawing.Size(791, 565)
			Me.treeList1.TabIndex = 0
			Me.treeList1.ToolTipController = Me.toolTipController1
			' 
			' colParentID
			' 
			Me.colParentID.FieldName = "ParentID"
			Me.colParentID.Name = "colParentID"
			Me.colParentID.Visible = True
			Me.colParentID.VisibleIndex = 0
			' 
			' colText
			' 
			Me.colText.FieldName = "Text"
			Me.colText.Name = "colText"
			Me.colText.Visible = True
			Me.colText.VisibleIndex = 1
			' 
			' colInfo
			' 
			Me.colInfo.FieldName = "Info"
			Me.colInfo.Name = "colInfo"
			' 
			' colValue
			' 
			Me.colValue.FieldName = "Value"
			Me.colValue.Name = "colValue"
			Me.colValue.Visible = True
			Me.colValue.VisibleIndex = 2
			' 
			' colDt
			' 
			Me.colDt.FieldName = "Dt"
			Me.colDt.Name = "colDt"
			Me.colDt.Visible = True
			Me.colDt.VisibleIndex = 3
			' 
			' colState
			' 
			Me.colState.FieldName = "State"
			Me.colState.Name = "colState"
			' 
			' colImage
			' 
			Me.colImage.FieldName = "Image"
			Me.colImage.Name = "colImage"
			' 
			' colDetail
			' 
			Me.colDetail.FieldName = "Detail"
			Me.colDetail.Name = "colDetail"
			' 
			' recordBindingSource
			' 
			Me.recordBindingSource.DataSource = GetType(ToolTipControllerExample.Record)
			' 
			' toolTipController1
			' 
			Me.toolTipController1.CloseOnClick = DevExpress.Utils.DefaultBoolean.False
			Me.toolTipController1.KeepWhileHovered = True
			Me.toolTipController1.ShowBeak = True
			Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.Flyout
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.OnGetActiveObjectInfo);
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(791, 565)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Main"
			Me.Text = "Flyout Hints"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
		Private colParentID As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colText As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colInfo As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colValue As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colDt As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colState As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colImage As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colDetail As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private recordBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

