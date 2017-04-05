<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbxNachricht = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSenden = New System.Windows.Forms.Button()
        Me.lblServerTime = New System.Windows.Forms.Label()
        Me.btnSendWithPost = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSendValue = New System.Windows.Forms.Button()
        Me.btnSendSimpleWithPost = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxNachricht
        '
        Me.tbxNachricht.Location = New System.Drawing.Point(12, 98)
        Me.tbxNachricht.Name = "tbxNachricht"
        Me.tbxNachricht.Size = New System.Drawing.Size(269, 20)
        Me.tbxNachricht.TabIndex = 0
        Me.tbxNachricht.Text = "Hallo, eine Nachricht von mir..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hier die Nachricht an den Webservice eingeben"
        '
        'btnSenden
        '
        Me.btnSenden.Location = New System.Drawing.Point(304, 94)
        Me.btnSenden.Name = "btnSenden"
        Me.btnSenden.Size = New System.Drawing.Size(147, 23)
        Me.btnSenden.TabIndex = 2
        Me.btnSenden.Text = "senden (get)"
        Me.btnSenden.UseVisualStyleBackColor = True
        '
        'lblServerTime
        '
        Me.lblServerTime.AutoSize = True
        Me.lblServerTime.Location = New System.Drawing.Point(12, 184)
        Me.lblServerTime.Name = "lblServerTime"
        Me.lblServerTime.Size = New System.Drawing.Size(16, 13)
        Me.lblServerTime.TabIndex = 3
        Me.lblServerTime.Text = "---"
        '
        'btnSendWithPost
        '
        Me.btnSendWithPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSendWithPost.Location = New System.Drawing.Point(304, 124)
        Me.btnSendWithPost.Name = "btnSendWithPost"
        Me.btnSendWithPost.Size = New System.Drawing.Size(147, 23)
        Me.btnSendWithPost.TabIndex = 4
        Me.btnSendWithPost.Text = "senden (post)"
        Me.btnSendWithPost.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Portnummer des Webdienstes"
        '
        'tbxPort
        '
        Me.tbxPort.Location = New System.Drawing.Point(12, 30)
        Me.tbxPort.Name = "tbxPort"
        Me.tbxPort.Size = New System.Drawing.Size(100, 20)
        Me.tbxPort.TabIndex = 6
        Me.tbxPort.Text = "7000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Response"
        '
        'btnSendValue
        '
        Me.btnSendValue.Location = New System.Drawing.Point(304, 197)
        Me.btnSendValue.Name = "btnSendValue"
        Me.btnSendValue.Size = New System.Drawing.Size(147, 23)
        Me.btnSendValue.TabIndex = 8
        Me.btnSendValue.Text = "Wert senden (post)"
        Me.btnSendValue.UseVisualStyleBackColor = True
        '
        'btnSendSimpleWithPost
        '
        Me.btnSendSimpleWithPost.Location = New System.Drawing.Point(304, 160)
        Me.btnSendSimpleWithPost.Name = "btnSendSimpleWithPost"
        Me.btnSendSimpleWithPost.Size = New System.Drawing.Size(147, 23)
        Me.btnSendSimpleWithPost.TabIndex = 9
        Me.btnSendSimpleWithPost.Text = "senden simple (post)"
        Me.btnSendSimpleWithPost.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 262)
        Me.Controls.Add(Me.btnSendSimpleWithPost)
        Me.Controls.Add(Me.btnSendValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSendWithPost)
        Me.Controls.Add(Me.lblServerTime)
        Me.Controls.Add(Me.btnSenden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxNachricht)
        Me.Name = "Form1"
        Me.Text = "Demo HTTP Client + WebAPI (c) Martin Korneffel 2017"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxNachricht As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSenden As System.Windows.Forms.Button
    Friend WithEvents lblServerTime As System.Windows.Forms.Label
    Friend WithEvents btnSendWithPost As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSendValue As Button
    Friend WithEvents btnSendSimpleWithPost As Button
End Class
