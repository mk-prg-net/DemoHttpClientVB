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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageLog = New System.Windows.Forms.TabPage()
        Me.lbxLog = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLeseVonAustausch = New System.Windows.Forms.Button()
        Me.TabPageCBList = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MassInEarthmassesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MassInEarthmoonMassesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HasRingsDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GravityInMeterPerSecSecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AequatorialDiameterInKmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolarDiameterInKmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrbitRadiusInAuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.tbxCount = New System.Windows.Forms.TextBox()
        Me.btnRequery = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCBTyp = New System.Windows.Forms.ComboBox()
        Me.CbxCBTypeItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOrderCBsDesc = New System.Windows.Forms.Button()
        Me.btnOrderCBsAsc = New System.Windows.Forms.Button()
        Me.OpenExcelFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageLog.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPageCBList.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.CbxCBTypeItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1064, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "beenden"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 558)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1064, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageLog)
        Me.TabControl1.Controls.Add(Me.TabPageCBList)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1064, 534)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageLog
        '
        Me.TabPageLog.Controls.Add(Me.lbxLog)
        Me.TabPageLog.Controls.Add(Me.Panel1)
        Me.TabPageLog.Location = New System.Drawing.Point(4, 22)
        Me.TabPageLog.Name = "TabPageLog"
        Me.TabPageLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLog.Size = New System.Drawing.Size(1056, 508)
        Me.TabPageLog.TabIndex = 0
        Me.TabPageLog.Text = "Log"
        Me.TabPageLog.UseVisualStyleBackColor = True
        '
        'lbxLog
        '
        Me.lbxLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxLog.FormattingEnabled = True
        Me.lbxLog.Location = New System.Drawing.Point(3, 54)
        Me.lbxLog.Name = "lbxLog"
        Me.lbxLog.Size = New System.Drawing.Size(1050, 451)
        Me.lbxLog.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLeseVonAustausch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 51)
        Me.Panel1.TabIndex = 0
        '
        'btnLeseVonAustausch
        '
        Me.btnLeseVonAustausch.Location = New System.Drawing.Point(16, 15)
        Me.btnLeseVonAustausch.Name = "btnLeseVonAustausch"
        Me.btnLeseVonAustausch.Size = New System.Drawing.Size(136, 23)
        Me.btnLeseVonAustausch.TabIndex = 0
        Me.btnLeseVonAustausch.Text = "Lese von Austausch"
        Me.btnLeseVonAustausch.UseVisualStyleBackColor = True
        '
        'TabPageCBList
        '
        Me.TabPageCBList.Controls.Add(Me.SplitContainer1)
        Me.TabPageCBList.Controls.Add(Me.Panel2)
        Me.TabPageCBList.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCBList.Name = "TabPageCBList"
        Me.TabPageCBList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCBList.Size = New System.Drawing.Size(1056, 508)
        Me.TabPageCBList.TabIndex = 1
        Me.TabPageCBList.Text = "Liste der Himmelskörper"
        Me.TabPageCBList.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 67)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 438)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CBTypeDataGridViewTextBoxColumn, Me.MassInEarthmassesDataGridViewTextBoxColumn, Me.MassInEarthmoonMassesDataGridViewTextBoxColumn, Me.HasRingsDataGridViewCheckBoxColumn, Me.GravityInMeterPerSecSecDataGridViewTextBoxColumn, Me.AequatorialDiameterInKmDataGridViewTextBoxColumn, Me.PolarDiameterInKmDataGridViewTextBoxColumn, Me.OrbitRadiusInAuDataGridViewTextBoxColumn, Me.OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CBListBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1050, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CBTypeDataGridViewTextBoxColumn
        '
        Me.CBTypeDataGridViewTextBoxColumn.DataPropertyName = "CBType"
        Me.CBTypeDataGridViewTextBoxColumn.HeaderText = "Typ"
        Me.CBTypeDataGridViewTextBoxColumn.Name = "CBTypeDataGridViewTextBoxColumn"
        Me.CBTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MassInEarthmassesDataGridViewTextBoxColumn
        '
        Me.MassInEarthmassesDataGridViewTextBoxColumn.DataPropertyName = "MassInEarthmasses"
        Me.MassInEarthmassesDataGridViewTextBoxColumn.HeaderText = "Masse [x Erde]"
        Me.MassInEarthmassesDataGridViewTextBoxColumn.Name = "MassInEarthmassesDataGridViewTextBoxColumn"
        Me.MassInEarthmassesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MassInEarthmoonMassesDataGridViewTextBoxColumn
        '
        Me.MassInEarthmoonMassesDataGridViewTextBoxColumn.DataPropertyName = "MassInEarthmoonMasses"
        Me.MassInEarthmoonMassesDataGridViewTextBoxColumn.HeaderText = "... [x Mond]"
        Me.MassInEarthmoonMassesDataGridViewTextBoxColumn.Name = "MassInEarthmoonMassesDataGridViewTextBoxColumn"
        Me.MassInEarthmoonMassesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HasRingsDataGridViewCheckBoxColumn
        '
        Me.HasRingsDataGridViewCheckBoxColumn.DataPropertyName = "HasRings"
        Me.HasRingsDataGridViewCheckBoxColumn.HeaderText = "hat Ringe ?"
        Me.HasRingsDataGridViewCheckBoxColumn.Name = "HasRingsDataGridViewCheckBoxColumn"
        Me.HasRingsDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GravityInMeterPerSecSecDataGridViewTextBoxColumn
        '
        Me.GravityInMeterPerSecSecDataGridViewTextBoxColumn.DataPropertyName = "GravityInMeterPerSecSec"
        Me.GravityInMeterPerSecSecDataGridViewTextBoxColumn.HeaderText = "g"
        Me.GravityInMeterPerSecSecDataGridViewTextBoxColumn.Name = "GravityInMeterPerSecSecDataGridViewTextBoxColumn"
        Me.GravityInMeterPerSecSecDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AequatorialDiameterInKmDataGridViewTextBoxColumn
        '
        Me.AequatorialDiameterInKmDataGridViewTextBoxColumn.DataPropertyName = "AequatorialDiameterInKm"
        Me.AequatorialDiameterInKmDataGridViewTextBoxColumn.HeaderText = "D Äquator"
        Me.AequatorialDiameterInKmDataGridViewTextBoxColumn.Name = "AequatorialDiameterInKmDataGridViewTextBoxColumn"
        Me.AequatorialDiameterInKmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PolarDiameterInKmDataGridViewTextBoxColumn
        '
        Me.PolarDiameterInKmDataGridViewTextBoxColumn.DataPropertyName = "PolarDiameterInKm"
        Me.PolarDiameterInKmDataGridViewTextBoxColumn.HeaderText = "D Polar"
        Me.PolarDiameterInKmDataGridViewTextBoxColumn.Name = "PolarDiameterInKmDataGridViewTextBoxColumn"
        Me.PolarDiameterInKmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrbitRadiusInAuDataGridViewTextBoxColumn
        '
        Me.OrbitRadiusInAuDataGridViewTextBoxColumn.DataPropertyName = "OrbitRadiusInAu"
        Me.OrbitRadiusInAuDataGridViewTextBoxColumn.HeaderText = "Orbit Radius [AE]"
        Me.OrbitRadiusInAuDataGridViewTextBoxColumn.Name = "OrbitRadiusInAuDataGridViewTextBoxColumn"
        Me.OrbitRadiusInAuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn
        '
        Me.OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn.DataPropertyName = "OrbitalSpeedInKilometerPerSec"
        Me.OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn.HeaderText = "Orbitalgeschw. [km/sec]"
        Me.OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn.Name = "OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn"
        Me.OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CBListBindingSource
        '
        Me.CBListBindingSource.DataSource = GetType(OpenXml25ExcelDemo.ICB)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblFileName)
        Me.Panel2.Controls.Add(Me.tbxCount)
        Me.Panel2.Controls.Add(Me.btnRequery)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbxCBTyp)
        Me.Panel2.Controls.Add(Me.btnOrderCBsDesc)
        Me.Panel2.Controls.Add(Me.btnOrderCBsAsc)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1050, 64)
        Me.Panel2.TabIndex = 0
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(16, 48)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(118, 13)
        Me.lblFileName.TabIndex = 6
        Me.lblFileName.Text = "keine Datei ausgewählt"
        '
        'tbxCount
        '
        Me.tbxCount.Location = New System.Drawing.Point(417, 22)
        Me.tbxCount.Name = "tbxCount"
        Me.tbxCount.ReadOnly = True
        Me.tbxCount.Size = New System.Drawing.Size(100, 20)
        Me.tbxCount.TabIndex = 5
        Me.tbxCount.Text = "0"
        Me.tbxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRequery
        '
        Me.btnRequery.Location = New System.Drawing.Point(287, 20)
        Me.btnRequery.Name = "btnRequery"
        Me.btnRequery.Size = New System.Drawing.Size(75, 23)
        Me.btnRequery.TabIndex = 4
        Me.btnRequery.Text = "Requery"
        Me.btnRequery.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Himmelskörpertyp"
        '
        'cbxCBTyp
        '
        Me.cbxCBTyp.DataSource = Me.CbxCBTypeItemBindingSource
        Me.cbxCBTyp.DisplayMember = "CBType"
        Me.cbxCBTyp.FormattingEnabled = True
        Me.cbxCBTyp.Location = New System.Drawing.Point(138, 22)
        Me.cbxCBTyp.Name = "cbxCBTyp"
        Me.cbxCBTyp.Size = New System.Drawing.Size(121, 21)
        Me.cbxCBTyp.TabIndex = 2
        Me.cbxCBTyp.Tag = "CBTypeName"
        Me.cbxCBTyp.ValueMember = "CBType"
        '
        'CbxCBTypeItemBindingSource
        '
        Me.CbxCBTypeItemBindingSource.DataSource = GetType(OpenXml25ExcelDemo.Client.WinForm.cbxCBTypeItem)
        '
        'btnOrderCBsDesc
        '
        Me.btnOrderCBsDesc.Location = New System.Drawing.Point(71, 20)
        Me.btnOrderCBsDesc.Name = "btnOrderCBsDesc"
        Me.btnOrderCBsDesc.Size = New System.Drawing.Size(49, 23)
        Me.btnOrderCBsDesc.TabIndex = 1
        Me.btnOrderCBsDesc.Text = "Down"
        Me.btnOrderCBsDesc.UseVisualStyleBackColor = True
        '
        'btnOrderCBsAsc
        '
        Me.btnOrderCBsAsc.Location = New System.Drawing.Point(16, 20)
        Me.btnOrderCBsAsc.Name = "btnOrderCBsAsc"
        Me.btnOrderCBsAsc.Size = New System.Drawing.Size(49, 23)
        Me.btnOrderCBsAsc.TabIndex = 0
        Me.btnOrderCBsAsc.Text = "Up"
        Me.btnOrderCBsAsc.UseVisualStyleBackColor = True
        '
        'OpenExcelFileDialog
        '
        Me.OpenExcelFileDialog.FileName = "KeplerBI-CBs.xlsx"
        Me.OpenExcelFileDialog.Filter = "Excel|*.xlsx|All|*.*"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Asteroid.bmp")
        Me.ImageList1.Images.SetKeyName(1, "Galaxie.bmp")
        Me.ImageList1.Images.SetKeyName(2, "Komet.bmp")
        Me.ImageList1.Images.SetKeyName(3, "Mond.bmp")
        Me.ImageList1.Images.SetKeyName(4, "Planet-2.bmp")
        Me.ImageList1.Images.SetKeyName(5, "Raumschiff.bmp")
        Me.ImageList1.Images.SetKeyName(6, "Schwarzes-Loch.bmp")
        Me.ImageList1.Images.SetKeyName(7, "Sonne.bmp")
        Me.ImageList1.Images.SetKeyName(8, "Urknall.bmp")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 580)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageLog.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabPageCBList.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CbxCBTypeItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageLog As System.Windows.Forms.TabPage
    Friend WithEvents lbxLog As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabPageCBList As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MassInEarthmassesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MassInEarthmoonMassesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HasRingsDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GravityInMeterPerSecSecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AequatorialDiameterInKmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolarDiameterInKmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrbitRadiusInAuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrbitalSpeedInKilometerPerSecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnOrderCBsDesc As System.Windows.Forms.Button
    Friend WithEvents btnOrderCBsAsc As System.Windows.Forms.Button
    Friend WithEvents btnRequery As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCBTyp As System.Windows.Forms.ComboBox
    Friend WithEvents CbxCBTypeItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbxCount As System.Windows.Forms.TextBox
    Friend WithEvents OpenExcelFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnLeseVonAustausch As System.Windows.Forms.Button

End Class
