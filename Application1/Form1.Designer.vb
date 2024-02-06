<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Submit = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(634, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 84)
        Button1.TabIndex = 0
        Button1.Text = "Clickme"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(309, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(141, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(227, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 2
        Label1.Text = "First Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(309, 127)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(141, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(210, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 4
        Label2.Text = "Second Number"
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(321, 166)
        Submit.Name = "Submit"
        Submit.Size = New Size(107, 49)
        Submit.TabIndex = 5
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"BBA", "BBA-IB", "BBA-CA"})
        ListBox1.Location = New Point(653, 115)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 124)
        ListBox1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(Submit)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Submit As Button
    Friend WithEvents ListBox1 As ListBox

End Class
