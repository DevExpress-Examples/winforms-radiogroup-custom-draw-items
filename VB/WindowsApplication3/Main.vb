Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Drawing.Drawing2D

Namespace WindowsApplication3

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnCustomDrawItem(ByVal sender As Object, ByVal e As CustomDrawEventArgs)
            If e.ItemInfo.CheckState = CheckState.Checked Then
                e.ItemInfo.Appearance.Font = New Font(e.ItemInfo.Appearance.Font, FontStyle.Bold Or FontStyle.Underline)
            End If

            If e.ItemInfo.State = DevExpress.Utils.Drawing.ObjectState.Hot Then
                Dim brush As LinearGradientBrush = New LinearGradientBrush(e.ItemInfo.Bounds, Color.LightBlue, Color.Indigo, LinearGradientMode.ForwardDiagonal)
                e.Cache.FillRectangle(brush, e.ItemInfo.Bounds)
                e.CheckPainter.DrawObject(e.ItemInfo)
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
