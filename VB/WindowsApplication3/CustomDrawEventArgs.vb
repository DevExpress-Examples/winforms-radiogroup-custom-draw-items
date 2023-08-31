Imports System
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication3

    Public Delegate Sub CustomDrawEventHandler(ByVal sender As Object, ByVal e As CustomDrawEventArgs)

    Public Class CustomDrawEventArgs
        Inherits EventArgs

        Private cacheField As GraphicsCache

        Private itemInfoField As RadioGroupItemViewInfo

        Private checkPainterField As CheckObjectPainter

        Private handledField As Boolean

        Public Sub New(ByVal cache As GraphicsCache, ByVal itemInfo As RadioGroupItemViewInfo, ByVal checkPainter As CheckObjectPainter, ByVal handled As Boolean)
            cacheField = cache
            itemInfoField = itemInfo
            checkPainterField = checkPainter
            handledField = handled
        End Sub

        Public ReadOnly Property Cache As GraphicsCache
            Get
                Return cacheField
            End Get
        End Property

        Public ReadOnly Property ItemInfo As RadioGroupItemViewInfo
            Get
                Return itemInfoField
            End Get
        End Property

        Public ReadOnly Property CheckPainter As CheckObjectPainter
            Get
                Return checkPainterField
            End Get
        End Property

        Public Property Handled As Boolean
            Get
                Return handledField
            End Get

            Set(ByVal value As Boolean)
                If handledField <> value Then handledField = value
            End Set
        End Property
    End Class
End Namespace
