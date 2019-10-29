Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace ToolTipControllerExample
	Public Class Record
		Implements INotifyPropertyChanged

		Public Sub New()
			Details = New BindingList(Of Detail)()
		End Sub
'INSTANT VB NOTE: The field id was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private id_Renamed As Integer
		Public Property ID() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				If id_Renamed <> value Then
					id_Renamed = value
					OnPropertyChanged("ID")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field parentID was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private parentID_Renamed As Integer
		Public Property ParentID() As Integer
			Get
				Return parentID_Renamed
			End Get
			Set(ByVal value As Integer)
				If parentID_Renamed <> value Then
					parentID_Renamed = value
					OnPropertyChanged("ParentID")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field text was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private text_Renamed As String
		Public Property Text() As String
			Get
				Return text_Renamed
			End Get
			Set(ByVal value As String)
				If text_Renamed <> value Then
					text_Renamed = value
					OnPropertyChanged("Text")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field info was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private info_Renamed As String
		Public Property Info() As String
			Get
				Return info_Renamed
			End Get
			Set(ByVal value As String)
				If info_Renamed <> value Then
					info_Renamed = value
					OnPropertyChanged("Info")
				End If
			End Set
		End Property
		Private val? As Decimal
		Public Property Value() As Decimal?
			Get
				Return val
			End Get
			Set(ByVal value? As Decimal)
				If Not val.Equals(value) Then
					val = value
					OnPropertyChanged("Value")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field dt was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private dt_Renamed As Date
		Public Property Dt() As Date
			Get
				Return dt_Renamed
			End Get
			Set(ByVal value As Date)
				If dt_Renamed <> value Then
					dt_Renamed = value
					OnPropertyChanged("Dt")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field state was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private state_Renamed As Boolean
		Public Property State() As Boolean
			Get
				Return state_Renamed
			End Get
			Set(ByVal value As Boolean)
				If state_Renamed <> value Then
					state_Renamed = value
					OnPropertyChanged("State")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field image was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private image_Renamed() As Byte
		Public Property Image() As Byte()
			Get
				Return image_Renamed
			End Get
			Set(ByVal value As Byte())
				If image_Renamed IsNot value Then
					image_Renamed = value
					OnPropertyChanged("Image")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field details was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private details_Renamed As BindingList(Of Detail)
		Public Property Details() As BindingList(Of Detail)
			Get
				Return details_Renamed
			End Get
			Set(ByVal value As BindingList(Of Detail))
				If details_Renamed IsNot value Then
					details_Renamed = value
					OnPropertyChanged("Details")
				End If
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return String.Format("ID = {0}", ID, Text)
		End Function
'INSTANT VB NOTE: The field detail was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private detail_Renamed As Detail
		Public Property Detail() As Detail
			Get
				Return detail_Renamed
			End Get
			Set(ByVal value As Detail)
				If detail_Renamed IsNot value Then
					detail_Renamed = value
					OnPropertyChanged("Detail")
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
	Public Class Detail
		Implements INotifyPropertyChanged

		Public Sub New()
		End Sub
'INSTANT VB NOTE: The field id was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private id_Renamed As Integer
		Public Property ID() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				If id_Renamed <> value Then
					id_Renamed = value
					OnPropertyChanged("ID")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field name was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				If name_Renamed <> value Then
					name_Renamed = value
					OnPropertyChanged("Name")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field info was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private info_Renamed As String
		Public Property Info() As String
			Get
				Return info_Renamed
			End Get
			Set(ByVal value As String)
				If info_Renamed <> value Then
					info_Renamed = value
					OnPropertyChanged("Info")
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field state was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private state_Renamed As Boolean
		Public Property State() As Boolean
			Get
				Return state_Renamed
			End Get
			Set(ByVal value As Boolean)
				If state_Renamed <> value Then
					state_Renamed = value
					OnPropertyChanged("State")
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
	Public Class DataHelper
		Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
			Dim records As New BindingList(Of Record)()
			For i As Integer = 0 To count - 1
				records.Add(New Record() With {
					.ParentID = If(i < 5, 1, 2),
					.ID = i,
					.Text = String.Format("Text {0}", i),
					.Info = String.Format("Info {0} Line 1" & vbCrLf & " Line 2" & vbCrLf & " Line 3" & vbCrLf & " Line 4" & vbCrLf & " Line 5" & vbCrLf, i),
					.Dt = If(i Mod 2 = 0, Date.Now.AddDays(i), Date.MinValue),
					.State = i Mod 2 = 0,
					.Image = If(i Mod 2 = 0, My.Resources.macbook, My.Resources.photo_camera),
					.Value = (i * 0.00001D),
					.Detail = New Detail() With {
						.ID = i,
						.Name = String.Format("Text {0}", i),
						.State = i Mod 2 = 0
					}
				})
			Next i
			Return records
		End Function
	End Class
End Namespace
