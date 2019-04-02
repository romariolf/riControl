<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientList
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
        Me.RiControl_dbDataSet1 = New riControl.riControl_dbDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomecliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipocliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoccliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuacliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairrocliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadecliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UfcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CepcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaiscliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObscliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbClientesTableAdapter = New riControl.riControl_dbDataSetTableAdapters.tbClientesTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.RiControl_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RiControl_dbDataSet1
        '
        Me.RiControl_dbDataSet1.DataSetName = "riControl_dbDataSet"
        Me.RiControl_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcliDataGridViewTextBoxColumn, Me.NomecliDataGridViewTextBoxColumn, Me.TipocliDataGridViewTextBoxColumn, Me.DoccliDataGridViewTextBoxColumn, Me.TelcliDataGridViewTextBoxColumn, Me.CelcliDataGridViewTextBoxColumn, Me.RuacliDataGridViewTextBoxColumn, Me.NumcliDataGridViewTextBoxColumn, Me.BairrocliDataGridViewTextBoxColumn, Me.CidadecliDataGridViewTextBoxColumn, Me.UfcliDataGridViewTextBoxColumn, Me.CepcliDataGridViewTextBoxColumn, Me.PaiscliDataGridViewTextBoxColumn, Me.ObscliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbClientesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(854, 278)
        Me.DataGridView1.TabIndex = 0
        '
        'IdcliDataGridViewTextBoxColumn
        '
        Me.IdcliDataGridViewTextBoxColumn.DataPropertyName = "id_cli"
        Me.IdcliDataGridViewTextBoxColumn.HeaderText = "#"
        Me.IdcliDataGridViewTextBoxColumn.Name = "IdcliDataGridViewTextBoxColumn"
        Me.IdcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomecliDataGridViewTextBoxColumn
        '
        Me.NomecliDataGridViewTextBoxColumn.DataPropertyName = "nome_cli"
        Me.NomecliDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomecliDataGridViewTextBoxColumn.Name = "NomecliDataGridViewTextBoxColumn"
        Me.NomecliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipocliDataGridViewTextBoxColumn
        '
        Me.TipocliDataGridViewTextBoxColumn.DataPropertyName = "tipo_cli"
        Me.TipocliDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipocliDataGridViewTextBoxColumn.Name = "TipocliDataGridViewTextBoxColumn"
        Me.TipocliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DoccliDataGridViewTextBoxColumn
        '
        Me.DoccliDataGridViewTextBoxColumn.DataPropertyName = "doc_cli"
        Me.DoccliDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ"
        Me.DoccliDataGridViewTextBoxColumn.Name = "DoccliDataGridViewTextBoxColumn"
        Me.DoccliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelcliDataGridViewTextBoxColumn
        '
        Me.TelcliDataGridViewTextBoxColumn.DataPropertyName = "tel_cli"
        Me.TelcliDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelcliDataGridViewTextBoxColumn.Name = "TelcliDataGridViewTextBoxColumn"
        Me.TelcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelcliDataGridViewTextBoxColumn
        '
        Me.CelcliDataGridViewTextBoxColumn.DataPropertyName = "cel_cli"
        Me.CelcliDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelcliDataGridViewTextBoxColumn.Name = "CelcliDataGridViewTextBoxColumn"
        Me.CelcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RuacliDataGridViewTextBoxColumn
        '
        Me.RuacliDataGridViewTextBoxColumn.DataPropertyName = "rua_cli"
        Me.RuacliDataGridViewTextBoxColumn.HeaderText = "Rua"
        Me.RuacliDataGridViewTextBoxColumn.Name = "RuacliDataGridViewTextBoxColumn"
        Me.RuacliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumcliDataGridViewTextBoxColumn
        '
        Me.NumcliDataGridViewTextBoxColumn.DataPropertyName = "num_cli"
        Me.NumcliDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.NumcliDataGridViewTextBoxColumn.Name = "NumcliDataGridViewTextBoxColumn"
        Me.NumcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BairrocliDataGridViewTextBoxColumn
        '
        Me.BairrocliDataGridViewTextBoxColumn.DataPropertyName = "bairro_cli"
        Me.BairrocliDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairrocliDataGridViewTextBoxColumn.Name = "BairrocliDataGridViewTextBoxColumn"
        Me.BairrocliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CidadecliDataGridViewTextBoxColumn
        '
        Me.CidadecliDataGridViewTextBoxColumn.DataPropertyName = "cidade_cli"
        Me.CidadecliDataGridViewTextBoxColumn.HeaderText = "Cidade"
        Me.CidadecliDataGridViewTextBoxColumn.Name = "CidadecliDataGridViewTextBoxColumn"
        Me.CidadecliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UfcliDataGridViewTextBoxColumn
        '
        Me.UfcliDataGridViewTextBoxColumn.DataPropertyName = "uf_cli"
        Me.UfcliDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.UfcliDataGridViewTextBoxColumn.Name = "UfcliDataGridViewTextBoxColumn"
        Me.UfcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CepcliDataGridViewTextBoxColumn
        '
        Me.CepcliDataGridViewTextBoxColumn.DataPropertyName = "cep_cli"
        Me.CepcliDataGridViewTextBoxColumn.HeaderText = "CEP"
        Me.CepcliDataGridViewTextBoxColumn.Name = "CepcliDataGridViewTextBoxColumn"
        Me.CepcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaiscliDataGridViewTextBoxColumn
        '
        Me.PaiscliDataGridViewTextBoxColumn.DataPropertyName = "pais_cli"
        Me.PaiscliDataGridViewTextBoxColumn.HeaderText = "País"
        Me.PaiscliDataGridViewTextBoxColumn.Name = "PaiscliDataGridViewTextBoxColumn"
        Me.PaiscliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObscliDataGridViewTextBoxColumn
        '
        Me.ObscliDataGridViewTextBoxColumn.DataPropertyName = "obs_cli"
        Me.ObscliDataGridViewTextBoxColumn.HeaderText = "Observações"
        Me.ObscliDataGridViewTextBoxColumn.Name = "ObscliDataGridViewTextBoxColumn"
        Me.ObscliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbClientesBindingSource
        '
        Me.TbClientesBindingSource.DataMember = "tbClientes"
        Me.TbClientesBindingSource.DataSource = Me.RiControl_dbDataSet1
        '
        'TbClientesTableAdapter
        '
        Me.TbClientesTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 278)
        Me.Panel1.TabIndex = 1
        '
        'clientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "clientList"
        Me.Text = "Clientes | riControl"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RiControl_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RiControl_dbDataSet1 As riControl_dbDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TbClientesBindingSource As BindingSource
    Friend WithEvents TbClientesTableAdapter As riControl_dbDataSetTableAdapters.tbClientesTableAdapter
    Friend WithEvents IdcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomecliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipocliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoccliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RuacliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BairrocliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CidadecliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UfcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CepcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaiscliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObscliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
