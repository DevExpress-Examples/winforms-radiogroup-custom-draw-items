Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Drawing.Drawing2D


Namespace WindowsApplication3
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnCustomDrawItem(ByVal sender As Object, ByVal e As CustomDrawEventArgs) Handles customRadioGroup1.Properties.CustomDrawItem
			If e.ItemInfo.CheckState = CheckState.Checked Then
				e.ItemInfo.Appearance.Font = New Font(e.ItemInfo.Appearance.Font, FontStyle.Bold Or FontStyle.Underline)
			End If
			If e.ItemInfo.State = DevExpress.Utils.Drawing.ObjectState.Hot Then
				Dim brush As New LinearGradientBrush(e.ItemInfo.Bounds, Color.LightBlue, Color.Indigo, LinearGradientMode.ForwardDiagonal)
				e.Cache.FillRectangle(brush, e.ItemInfo.Bounds)
				e.CheckPainter.DrawObject(e.ItemInfo)

				e.Handled = True
			End If
		End Sub
	End Class
End Namespace
