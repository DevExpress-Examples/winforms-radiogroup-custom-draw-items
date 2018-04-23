Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication3
	Public Delegate Sub CustomDrawEventHandler(ByVal sender As Object, ByVal e As CustomDrawEventArgs)
	Public Class CustomDrawEventArgs
		Inherits EventArgs
		Private graphics_Renamed As Graphics
		Private itemInfo_Renamed As RadioGroupItemViewInfo
		Private checkPainter_Renamed As CheckObjectPainter
		Private handled_Renamed As Boolean

		Public Sub New(ByVal graphics As Graphics, ByVal itemInfo As RadioGroupItemViewInfo, ByVal checkPainter As CheckObjectPainter, ByVal handled As Boolean)
			Me.graphics_Renamed = graphics
			Me.itemInfo_Renamed = itemInfo
			Me.checkPainter_Renamed = checkPainter
			Me.handled_Renamed = handled
		End Sub

		Public ReadOnly Property Graphics() As Graphics
			Get
				Return graphics_Renamed
			End Get
		End Property

		Public ReadOnly Property ItemInfo() As RadioGroupItemViewInfo
			Get
				Return itemInfo_Renamed
			End Get
		End Property

		Public ReadOnly Property CheckPainter() As CheckObjectPainter
			Get
				Return checkPainter_Renamed
			End Get
		End Property

		Public Property Handled() As Boolean
			Get
				Return handled_Renamed
			End Get
			Set(ByVal value As Boolean)
				If handled_Renamed <> value Then
					handled_Renamed = value
				End If
			End Set
		End Property
	End Class
End Namespace