Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
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
                    Dim e As CustomDrawEventArgs = New CustomDrawEventArgs(info.Cache, itemInfo, vi.RadioPainter, False)
                    Dim item As RepositoryItemCustomRadioGroup = TryCast(vi.Item, RepositoryItemCustomRadioGroup)
                    item.RaiseCustomDrawItem(e)
                    If Not e.Handled Then vi.RadioPainter.DrawObject(itemInfo)
                    If itemInfo.Focused Then ControlPaint.DrawFocusRectangle(info.Graphics, vi.GetFocusRect(itemInfo))
                Finally
                    itemInfo.Cache = Nothing
                End Try
            Next
        End Sub
    End Class
End Namespace
