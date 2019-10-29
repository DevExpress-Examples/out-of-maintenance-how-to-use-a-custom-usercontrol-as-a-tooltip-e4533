Namespace ToolTipControllerExample
	Partial Public Class DetailControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
			Me.imageEdit = New DevExpress.XtraEditors.PictureEdit()
			Me.stateToggleSwitch = New DevExpress.XtraEditors.ToggleSwitch()
			Me.infoMemoEdit = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.tablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tablePanel1.SuspendLayout()
			CType(Me.imageEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stateToggleSwitch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.infoMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tablePanel1
			' 
			Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {
				New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
				New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)
			})
			Me.tablePanel1.Controls.Add(Me.infoMemoEdit)
			Me.tablePanel1.Controls.Add(Me.stateToggleSwitch)
			Me.tablePanel1.Controls.Add(Me.imageEdit)
			Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
			Me.tablePanel1.Name = "tablePanel1"
			Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {
				New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
				New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)
			})
			Me.tablePanel1.Size = New System.Drawing.Size(321, 215)
			Me.tablePanel1.TabIndex = 0
			' 
			' pictureEdit
			' 
			Me.tablePanel1.SetColumn(Me.imageEdit, 0)
			Me.imageEdit.Location = New System.Drawing.Point(3, 6)
			Me.imageEdit.Name = "pictureEdit"
			Me.imageEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
			Me.tablePanel1.SetRow(Me.imageEdit, 0)
			Me.imageEdit.Size = New System.Drawing.Size(155, 96)
			Me.imageEdit.TabIndex = 0
			' 
			' stateToggleSwitch
			' 
			Me.tablePanel1.SetColumn(Me.stateToggleSwitch, 0)
			Me.stateToggleSwitch.Location = New System.Drawing.Point(3, 152)
			Me.stateToggleSwitch.Name = "stateToggleSwitch"
			Me.stateToggleSwitch.Properties.OffText = "InActive"
			Me.stateToggleSwitch.Properties.OnText = "Active"
			Me.tablePanel1.SetRow(Me.stateToggleSwitch, 1)
			Me.stateToggleSwitch.Size = New System.Drawing.Size(155, 18)
			Me.stateToggleSwitch.TabIndex = 1
			' 
			' infoMemoEdit
			' 
			Me.tablePanel1.SetColumn(Me.infoMemoEdit, 1)
			Me.infoMemoEdit.Location = New System.Drawing.Point(164, 113)
			Me.infoMemoEdit.Name = "infoMemoEdit"
			Me.tablePanel1.SetRow(Me.infoMemoEdit, 1)
			Me.infoMemoEdit.Size = New System.Drawing.Size(155, 96)
			Me.infoMemoEdit.TabIndex = 2
			' 
			' DetailControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tablePanel1)
			Me.Name = "DetailControl"
			Me.Size = New System.Drawing.Size(321, 215)
			CType(Me.tablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tablePanel1.ResumeLayout(False)
			CType(Me.imageEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stateToggleSwitch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.infoMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tablePanel1 As DevExpress.Utils.Layout.TablePanel
		Private stateToggleSwitch As DevExpress.XtraEditors.ToggleSwitch
		Private imageEdit As DevExpress.XtraEditors.PictureEdit
		Private infoMemoEdit As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace
