Namespace WindowsApplication3

    Partial Class Main

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.customRadioGroup1 = New WindowsApplication3.CustomRadioGroup()
            CType((Me.customRadioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
            ' 
            ' customRadioGroup1
            ' 
            Me.customRadioGroup1.Location = New System.Drawing.Point(110, 40)
            Me.customRadioGroup1.Name = "customRadioGroup1"
            Me.customRadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "A"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "B"), New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "C")})
            AddHandler Me.customRadioGroup1.Properties.CustomDrawItem, New WindowsApplication3.CustomDrawEventHandler(AddressOf Me.OnCustomDrawItem)
            Me.customRadioGroup1.Size = New System.Drawing.Size(361, 229)
            Me.customRadioGroup1.TabIndex = 0
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(605, 311)
            Me.Controls.Add(Me.customRadioGroup1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Main"
            Me.Text = "RadioGroup Custom Draw"
            CType((Me.customRadioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private customRadioGroup1 As WindowsApplication3.CustomRadioGroup
    End Class
End Namespace
