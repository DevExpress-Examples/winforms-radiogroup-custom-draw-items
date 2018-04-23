Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Reflection
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DXSample

Namespace WindowsApplication3
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemCustomRadioGroup
		Inherits RepositoryItemRadioGroup

		Shared Sub New()
			RegisterCustomEdit()
		End Sub

		Public Sub New()
		End Sub

		Public Const CustomEditName As String = "CustomRadioGroup"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property

		Public Shared Sub RegisterCustomEdit()
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly(). GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomRadioGroup), GetType(RepositoryItemCustomRadioGroup), GetType(RadioGroupViewInfo), New CustomRadioGroupPainter(), True, img))
		End Sub

		Private Shared ReadOnly customDraw As Object = New Object()

		Public Custom Event CustomDrawItem As CustomDrawEventHandler
			AddHandler(ByVal value As CustomDrawEventHandler)
				Me.Events.AddHandler(customDraw, value)
			End AddHandler
			RemoveHandler(ByVal value As CustomDrawEventHandler)
				Me.Events.RemoveHandler(customDraw, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As CustomDrawEventArgs)
			End RaiseEvent
		End Event

		Friend Sub RaiseCustomDrawItem(ByVal e As CustomDrawEventArgs)
			Dim handler As CustomDrawEventHandler = CType(Events(customDraw), CustomDrawEventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), e)
			End If
		End Sub

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemCustomRadioGroup = TryCast(item, RepositoryItemCustomRadioGroup)
				If source Is Nothing Then
					Return
				End If
				Events.AddHandler(customDraw, source.Events(customDraw))
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class

End Namespace