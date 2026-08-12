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
        Me.dgvStates = New System.Windows.Forms.DataGridView()
        Me.btnPresidents = New System.Windows.Forms.Button()
        Me.btnStates = New System.Windows.Forms.Button()
        Me.btnPopulation = New System.Windows.Forms.Button()
        Me.cboOptions = New System.Windows.Forms.ComboBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnCities = New System.Windows.Forms.Button()
        CType(Me.dgvStates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStates
        '
        Me.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStates.Location = New System.Drawing.Point(21, 150)
        Me.dgvStates.Name = "dgvStates"
        Me.dgvStates.RowHeadersWidth = 51
        Me.dgvStates.RowTemplate.Height = 24
        Me.dgvStates.Size = New System.Drawing.Size(669, 278)
        Me.dgvStates.TabIndex = 0
        '
        'btnPresidents
        '
        Me.btnPresidents.Location = New System.Drawing.Point(21, 29)
        Me.btnPresidents.Name = "btnPresidents"
        Me.btnPresidents.Size = New System.Drawing.Size(172, 52)
        Me.btnPresidents.TabIndex = 2
        Me.btnPresidents.Text = "Get Presidents"
        Me.btnPresidents.UseVisualStyleBackColor = True
        '
        'btnStates
        '
        Me.btnStates.Location = New System.Drawing.Point(382, 29)
        Me.btnStates.Name = "btnStates"
        Me.btnStates.Size = New System.Drawing.Size(173, 52)
        Me.btnStates.TabIndex = 3
        Me.btnStates.Text = "Get States"
        Me.btnStates.UseVisualStyleBackColor = True
        '
        'btnPopulation
        '
        Me.btnPopulation.Location = New System.Drawing.Point(603, 29)
        Me.btnPopulation.Name = "btnPopulation"
        Me.btnPopulation.Size = New System.Drawing.Size(155, 52)
        Me.btnPopulation.TabIndex = 4
        Me.btnPopulation.Text = "Pop <  20 Million"
        Me.btnPopulation.UseVisualStyleBackColor = True
        '
        'cboOptions
        '
        Me.cboOptions.FormattingEnabled = True
        Me.cboOptions.Items.AddRange(New Object() {"Display State by Abbreviation", "Display only states where area < 2000"})
        Me.cboOptions.Location = New System.Drawing.Point(727, 150)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(251, 24)
        Me.cboOptions.TabIndex = 5
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(793, 222)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(100, 22)
        Me.txtOutput.TabIndex = 6
        '
        'btnCities
        '
        Me.btnCities.Location = New System.Drawing.Point(226, 29)
        Me.btnCities.Name = "btnCities"
        Me.btnCities.Size = New System.Drawing.Size(137, 52)
        Me.btnCities.TabIndex = 7
        Me.btnCities.Text = "Get Cities"
        Me.btnCities.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 450)
        Me.Controls.Add(Me.btnCities)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.cboOptions)
        Me.Controls.Add(Me.btnPopulation)
        Me.Controls.Add(Me.btnStates)
        Me.Controls.Add(Me.btnPresidents)
        Me.Controls.Add(Me.dgvStates)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvStates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStates As DataGridView
    Friend WithEvents btnPresidents As Button
    Friend WithEvents btnStates As Button
    Friend WithEvents btnPopulation As Button
    Friend WithEvents cboOptions As ComboBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnCities As Button
End Class
