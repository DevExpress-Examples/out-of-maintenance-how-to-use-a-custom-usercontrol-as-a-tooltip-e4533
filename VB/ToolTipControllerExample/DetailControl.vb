Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace ToolTipControllerExample
	Partial Public Class DetailControl
		Inherits DevExpress.XtraEditors.XtraUserControl

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub UpdateContent(ByVal record As Record)
			imageEdit.SvgImage = record.Image
			stateToggleSwitch.EditValue = record.State
			infoMemoEdit.EditValue = record.Info
		End Sub
	End Class
End Namespace
