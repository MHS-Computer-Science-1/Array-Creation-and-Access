<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ListBox1 = New ListBox()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightBlue
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(22, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 28)
        Button1.TabIndex = 0
        Button1.Text = "Favorite Foods"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightCyan
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(22, 54)
        Button2.Name = "Button2"
        Button2.Size = New Size(181, 28)
        Button2.TabIndex = 1
        Button2.Text = "Favorite Apps"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightBlue
        Button3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(22, 88)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 28)
        Button3.TabIndex = 2
        Button3.Text = "Test Average"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightCyan
        Button4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(22, 122)
        Button4.Name = "Button4"
        Button4.Size = New Size(181, 28)
        Button4.TabIndex = 3
        Button4.Text = "Test Corrections"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.LightCyan
        ListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(222, 22)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(266, 193)
        ListBox1.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightBlue
        Button5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(22, 156)
        Button5.Name = "Button5"
        Button5.Size = New Size(181, 28)
        Button5.TabIndex = 5
        Button5.Text = "Half Off"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.LightCyan
        Button6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(22, 190)
        Button6.Name = "Button6"
        Button6.Size = New Size(181, 28)
        Button6.TabIndex = 6
        Button6.Text = "Extra Credit: Swap"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(510, 238)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ListBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Array Creation and Access"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
