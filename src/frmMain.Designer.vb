<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.lblDrag = New System.Windows.Forms.Label()
		Me.pnlDrag = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cbY = New System.Windows.Forms.ComboBox()
		Me.pnlXY = New System.Windows.Forms.Panel()
		Me.cbX = New System.Windows.Forms.ComboBox()
		Me.btnSet = New System.Windows.Forms.Button()
		Me.lblX = New System.Windows.Forms.Label()
		Me.lblY = New System.Windows.Forms.Label()
		Me.spbY = New DDCSVTest.SpBtn()
		Me.spbX = New DDCSVTest.SpBtn()
		Me.pnlDrag.SuspendLayout()
		Me.pnlXY.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblDrag
		'
		Me.lblDrag.CausesValidation = False
		Me.lblDrag.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDrag.Location = New System.Drawing.Point(3, 13)
		Me.lblDrag.Name = "lblDrag"
		Me.lblDrag.Size = New System.Drawing.Size(236, 16)
		Me.lblDrag.TabIndex = 0
		Me.lblDrag.Text = "Drag Here"
		Me.lblDrag.UseMnemonic = False
		'
		'pnlDrag
		'
		Me.pnlDrag.AllowDrop = True
		Me.pnlDrag.BackColor = System.Drawing.Color.OldLace
		Me.pnlDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDrag.CausesValidation = False
		Me.pnlDrag.Controls.Add(Me.Label3)
		Me.pnlDrag.Controls.Add(Me.Label2)
		Me.pnlDrag.Controls.Add(Me.lblDrag)
		Me.pnlDrag.Location = New System.Drawing.Point(12, 12)
		Me.pnlDrag.Name = "pnlDrag"
		Me.pnlDrag.Size = New System.Drawing.Size(242, 100)
		Me.pnlDrag.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(662, 46)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(456, 54)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Label3"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(662, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(453, 100)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Label2"
		'
		'cbY
		'
		Me.cbY.BackColor = System.Drawing.Color.Gainsboro
		Me.cbY.CausesValidation = False
		Me.cbY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbY.Enabled = False
		Me.cbY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbY.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbY.ForeColor = System.Drawing.Color.Black
		Me.cbY.FormattingEnabled = True
		Me.cbY.Location = New System.Drawing.Point(127, 156)
		Me.cbY.Name = "cbY"
		Me.cbY.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbY.Size = New System.Drawing.Size(127, 21)
		Me.cbY.TabIndex = 0
		Me.cbY.TabStop = False
		'
		'pnlXY
		'
		Me.pnlXY.BackColor = System.Drawing.Color.Transparent
		Me.pnlXY.CausesValidation = False
		Me.pnlXY.Controls.Add(Me.spbY)
		Me.pnlXY.Controls.Add(Me.spbX)
		Me.pnlXY.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlXY.Location = New System.Drawing.Point(12, 118)
		Me.pnlXY.Name = "pnlXY"
		Me.pnlXY.Size = New System.Drawing.Size(109, 63)
		Me.pnlXY.TabIndex = 0
		'
		'cbX
		'
		Me.cbX.BackColor = System.Drawing.Color.Gainsboro
		Me.cbX.CausesValidation = False
		Me.cbX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbX.Enabled = False
		Me.cbX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbX.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbX.ForeColor = System.Drawing.Color.Black
		Me.cbX.FormattingEnabled = True
		Me.cbX.Location = New System.Drawing.Point(127, 125)
		Me.cbX.Name = "cbX"
		Me.cbX.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbX.Size = New System.Drawing.Size(127, 21)
		Me.cbX.TabIndex = 0
		Me.cbX.TabStop = False
		'
		'btnSet
		'
		Me.btnSet.BackColor = System.Drawing.Color.WhiteSmoke
		Me.btnSet.CausesValidation = False
		Me.btnSet.Enabled = False
		Me.btnSet.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
		Me.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
		Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSet.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSet.ForeColor = System.Drawing.Color.Black
		Me.btnSet.Location = New System.Drawing.Point(12, 187)
		Me.btnSet.Name = "btnSet"
		Me.btnSet.Size = New System.Drawing.Size(242, 23)
		Me.btnSet.TabIndex = 0
		Me.btnSet.TabStop = False
		Me.btnSet.UseMnemonic = False
		Me.btnSet.UseVisualStyleBackColor = False
		'
		'lblX
		'
		Me.lblX.AutoSize = True
		Me.lblX.BackColor = System.Drawing.Color.Transparent
		Me.lblX.CausesValidation = False
		Me.lblX.Enabled = False
		Me.lblX.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblX.Location = New System.Drawing.Point(9, 224)
		Me.lblX.Name = "lblX"
		Me.lblX.Size = New System.Drawing.Size(70, 15)
		Me.lblX.TabIndex = 0
		Me.lblX.Text = "X Index: "
		Me.lblX.UseMnemonic = False
		Me.lblX.Visible = False
		'
		'lblY
		'
		Me.lblY.AutoSize = True
		Me.lblY.BackColor = System.Drawing.Color.Transparent
		Me.lblY.CausesValidation = False
		Me.lblY.Enabled = False
		Me.lblY.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblY.Location = New System.Drawing.Point(9, 239)
		Me.lblY.Name = "lblY"
		Me.lblY.Size = New System.Drawing.Size(70, 15)
		Me.lblY.TabIndex = 0
		Me.lblY.Text = "Y Index: "
		Me.lblY.UseMnemonic = False
		Me.lblY.Visible = False
		'
		'spbY
		'
		Me.spbY.AutoSize = True
		Me.spbY.BackColor = System.Drawing.Color.WhiteSmoke
		Me.spbY.CausesValidation = False
		Me.spbY.Enabled = False
		Me.spbY.FlatAppearance.BorderColor = System.Drawing.Color.Blue
		Me.spbY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.spbY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
		Me.spbY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.spbY.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.spbY.ForeColor = System.Drawing.Color.Black
		Me.spbY.Location = New System.Drawing.Point(0, 33)
		Me.spbY.Name = "spbY"
		Me.spbY.Size = New System.Drawing.Size(100, 27)
		Me.spbY.TabIndex = 0
		Me.spbY.TabStop = False
		Me.spbY.UseVisualStyleBackColor = False
		'
		'spbX
		'
		Me.spbX.AutoSize = True
		Me.spbX.BackColor = System.Drawing.Color.WhiteSmoke
		Me.spbX.CausesValidation = False
		Me.spbX.Enabled = False
		Me.spbX.FlatAppearance.BorderColor = System.Drawing.Color.Blue
		Me.spbX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.spbX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
		Me.spbX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.spbX.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.spbX.ForeColor = System.Drawing.Color.Black
		Me.spbX.Location = New System.Drawing.Point(0, 2)
		Me.spbX.Name = "spbX"
		Me.spbX.Size = New System.Drawing.Size(100, 27)
		Me.spbX.TabIndex = 0
		Me.spbX.TabStop = False
		Me.spbX.UseVisualStyleBackColor = False
		'
		'frmMain
		'
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LemonChiffon
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(267, 269)
		Me.Controls.Add(Me.lblY)
		Me.Controls.Add(Me.lblX)
		Me.Controls.Add(Me.btnSet)
		Me.Controls.Add(Me.pnlXY)
		Me.Controls.Add(Me.cbX)
		Me.Controls.Add(Me.cbY)
		Me.Controls.Add(Me.pnlDrag)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.ShowIcon = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Text = "DDCSVTest"
		Me.pnlDrag.ResumeLayout(False)
		Me.pnlXY.ResumeLayout(False)
		Me.pnlXY.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Private WithEvents cbY As System.Windows.Forms.ComboBox
	Private WithEvents cbX As System.Windows.Forms.ComboBox
	Private WithEvents lblDrag As System.Windows.Forms.Label
	Private WithEvents pnlDrag As System.Windows.Forms.Panel
	Private WithEvents spbY As DDCSVTest.SpBtn
	Private WithEvents spbX As DDCSVTest.SpBtn
	Private WithEvents btnSet As System.Windows.Forms.Button
	Private WithEvents lblX As System.Windows.Forms.Label
	Private WithEvents lblY As System.Windows.Forms.Label
	Private WithEvents pnlXY As System.Windows.Forms.Panel

End Class
