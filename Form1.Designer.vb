<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpMeasurement = New System.Windows.Forms.GroupBox()
        Me.radMetersto = New System.Windows.Forms.RadioButton()
        Me.radInchesto = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConvert = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMeasurement.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(675, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(350, 61)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Converter App"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.midtermgui.My.Resources.Resources.building
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(514, 128)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(434, 92)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter a value and choose conversion:"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.MediumOrchid
        Me.txtInput.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(762, 202)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(133, 35)
        Me.txtInput.TabIndex = 3
        '
        'grpMeasurement
        '
        Me.grpMeasurement.BackColor = System.Drawing.Color.MediumOrchid
        Me.grpMeasurement.Controls.Add(Me.radMetersto)
        Me.grpMeasurement.Controls.Add(Me.radInchesto)
        Me.grpMeasurement.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMeasurement.ForeColor = System.Drawing.Color.White
        Me.grpMeasurement.Location = New System.Drawing.Point(310, 259)
        Me.grpMeasurement.Name = "grpMeasurement"
        Me.grpMeasurement.Size = New System.Drawing.Size(291, 134)
        Me.grpMeasurement.TabIndex = 4
        Me.grpMeasurement.TabStop = False
        Me.grpMeasurement.Text = "Convert Measurement"
        '
        'radMetersto
        '
        Me.radMetersto.AutoSize = True
        Me.radMetersto.Location = New System.Drawing.Point(6, 81)
        Me.radMetersto.Name = "radMetersto"
        Me.radMetersto.Size = New System.Drawing.Size(215, 33)
        Me.radMetersto.TabIndex = 1
        Me.radMetersto.TabStop = True
        Me.radMetersto.Text = "Meters to Inches"
        Me.radMetersto.UseVisualStyleBackColor = True
        '
        'radInchesto
        '
        Me.radInchesto.AutoSize = True
        Me.radInchesto.Location = New System.Drawing.Point(6, 42)
        Me.radInchesto.Name = "radInchesto"
        Me.radInchesto.Size = New System.Drawing.Size(215, 33)
        Me.radInchesto.TabIndex = 0
        Me.radInchesto.TabStop = True
        Me.radInchesto.Text = "Inches to Meters"
        Me.radInchesto.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnConvert.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(91, 432)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(156, 59)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(565, 432)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 59)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1007, 432)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 59)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(757, 340)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(0, 29)
        Me.lblConvert.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1230, 552)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpMeasurement)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMeasurement.ResumeLayout(False)
        Me.grpMeasurement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents grpMeasurement As GroupBox
    Friend WithEvents radMetersto As RadioButton
    Friend WithEvents radInchesto As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConvert As Label
End Class
