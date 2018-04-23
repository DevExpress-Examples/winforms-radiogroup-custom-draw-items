Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace WindowsApplication3
	Public Class CustomRadioGroup
		Inherits RadioGroup

		Shared Sub New()
			RepositoryItemCustomRadioGroup.RegisterCustomEdit()
		End Sub

		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomRadioGroup.CustomEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomRadioGroup
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomRadioGroup)
			End Get
		End Property

	End Class

End Namespace