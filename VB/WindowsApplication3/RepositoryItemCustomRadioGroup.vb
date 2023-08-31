Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Reflection
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DXSample

Namespace WindowsApplication3

    <UserRepositoryItem("RegisterCustomEdit")>
    Public Class RepositoryItemCustomRadioGroup
        Inherits RepositoryItemRadioGroup

        Shared Sub New()
            Call RegisterCustomEdit()
        End Sub

        Public Sub New()
        End Sub

        Public Const CustomEditName As String = "CustomRadioGroup"

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomEdit()
            Dim img As Image = Nothing
            Try
                img = CType(Bitmap.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
            Catch
            End Try

            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomRadioGroup), GetType(RepositoryItemCustomRadioGroup), GetType(RadioGroupViewInfo), New CustomRadioGroupPainter(), True, img))
        End Sub

        Private Shared ReadOnly customDraw As Object = New Object()

        Public Custom Event CustomDrawItem As CustomDrawEventHandler
            AddHandler(ByVal value As CustomDrawEventHandler)
                Events.AddHandler(customDraw, value)
            End AddHandler

            RemoveHandler(ByVal value As CustomDrawEventHandler)
                Events.RemoveHandler(customDraw, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As CustomDrawEventArgs)
            End RaiseEvent
        End Event

        Friend Sub RaiseCustomDrawItem(ByVal e As CustomDrawEventArgs)
            Dim handler As CustomDrawEventHandler = CType(Events(customDraw), CustomDrawEventHandler)
            If handler IsNot Nothing Then handler(GetEventSender(), e)
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomRadioGroup = TryCast(item, RepositoryItemCustomRadioGroup)
                If source Is Nothing Then Return
                Events.AddHandler(customDraw, source.Events(customDraw))
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
