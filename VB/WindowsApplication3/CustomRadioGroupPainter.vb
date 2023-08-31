Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Windows.Forms
Imports WindowsApplication3

Namespace DXSample
	Public Class CustomRadioGroupPainter
		Inherits RadioGroupPainter
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Sub DrawRadioGroupItems(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As RadioGroupViewInfo = TryCast(info.ViewInfo, RadioGroupViewInfo)
			For Each itemInfo As RadioGroupItemViewInfo In vi.ItemsInfo
				itemInfo.Cache = info.Cache
				Try
					Dim e As New CustomDrawEventArgs(info.Cache, itemInfo, vi.RadioPainter, False)
					Dim item As RepositoryItemCustomRadioGroup = TryCast(vi.Item, RepositoryItemCustomRadioGroup)
					item.RaiseCustomDrawItem(e)
					If (Not e.Handled) Then
						vi.RadioPainter.DrawObject(itemInfo)
					End If
					If itemInfo.Focused Then
						ControlPaint.DrawFocusRectangle(info.Graphics, vi.GetFocusRect(itemInfo))
					End If
				Finally
				  itemInfo.Cache = Nothing
				End Try
			Next itemInfo
		End Sub
	End Class

End Namespace


