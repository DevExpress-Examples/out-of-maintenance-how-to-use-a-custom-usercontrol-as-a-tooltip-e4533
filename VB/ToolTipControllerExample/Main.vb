Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace ToolTipControllerExample
	Partial Public Class Main
		Inherits XtraForm

'INSTANT VB NOTE: The field flyoutControl was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private flyoutControl_Renamed As DetailControl
		Public Sub New()
			InitializeComponent()
			treeList1.DataSource = DataHelper.GetData(10)
		End Sub
		Private ReadOnly Property FlyoutControl() As DetailControl
			Get
				If flyoutControl_Renamed Is Nothing Then
					flyoutControl_Renamed = New DetailControl()
				End If
				Return flyoutControl_Renamed
			End Get
		End Property
		Private Sub OnGetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
			Dim tree As TreeList = TryCast(e.SelectedControl, TreeList)
			If tree IsNot Nothing Then
				Dim hitInfo As TreeListHitInfo = tree.CalcHitInfo(e.ControlMousePosition)
				Dim record As Record = DirectCast(tree.GetDataRecordByNode(hitInfo.Node), Record)
				If hitInfo.HitInfoType = HitInfoType.Cell Then
					e.Info = New ToolTipControlInfo()
					e.Info.Object = $"Column={hitInfo.Column.FieldName}, NodeId={hitInfo.Node.Id}"
					e.Info.FlyoutControl = FlyoutControl
					FlyoutControl.UpdateContent(record)
				End If
			End If
		End Sub
	End Class
End Namespace