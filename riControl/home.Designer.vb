<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.btnBills = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblDatabaseStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(317, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(244, 21)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "segunda-feira, 1 de abril de 2019"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(403, 36)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClock.Size = New System.Drawing.Size(72, 21)
        Me.lblClock.TabIndex = 3
        Me.lblClock.Text = "22:56:00"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnBalance)
        Me.Panel1.Controls.Add(Me.btnBills)
        Me.Panel1.Controls.Add(Me.btnOrders)
        Me.Panel1.Controls.Add(Me.btnProducts)
        Me.Panel1.Controls.Add(Me.btnSuppliers)
        Me.Panel1.Controls.Add(Me.btnClients)
        Me.Panel1.Location = New System.Drawing.Point(12, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 402)
        Me.Panel1.TabIndex = 4
        '
        'btnReports
        '
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Image = Global.riControl.My.Resources.Resources.iconfinder_157_95830
        Me.btnReports.Location = New System.Drawing.Point(587, 237)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(165, 156)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Relatórios"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnBalance
        '
        Me.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnBalance.FlatAppearance.BorderSize = 0
        Me.btnBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.Image = Global.riControl.My.Resources.Resources.iconfinder_033_95841
        Me.btnBalance.Location = New System.Drawing.Point(345, 237)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(165, 156)
        Me.btnBalance.TabIndex = 5
        Me.btnBalance.Text = "Balanço"
        Me.btnBalance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'btnBills
        '
        Me.btnBills.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnBills.FlatAppearance.BorderSize = 0
        Me.btnBills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBills.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBills.Image = Global.riControl.My.Resources.Resources.iconfinder_055_95797
        Me.btnBills.Location = New System.Drawing.Point(103, 237)
        Me.btnBills.Name = "btnBills"
        Me.btnBills.Size = New System.Drawing.Size(165, 156)
        Me.btnBills.TabIndex = 4
        Me.btnBills.Text = "Contas"
        Me.btnBills.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBills.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrders.Image = Global.riControl.My.Resources.Resources.iconfinder_036_95741
        Me.btnOrders.Location = New System.Drawing.Point(676, 14)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(165, 156)
        Me.btnOrders.TabIndex = 3
        Me.btnOrders.Text = "Pedidos"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.Image = Global.riControl.My.Resources.Resources.iconfinder_128_95777
        Me.btnProducts.Location = New System.Drawing.Point(456, 14)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(165, 156)
        Me.btnProducts.TabIndex = 2
        Me.btnProducts.Text = "Produtos"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnSuppliers.FlatAppearance.BorderSize = 0
        Me.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.Image = Global.riControl.My.Resources.Resources.iconfinder_038_95845
        Me.btnSuppliers.Location = New System.Drawing.Point(234, 14)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(165, 156)
        Me.btnSuppliers.TabIndex = 1
        Me.btnSuppliers.Text = "Fornecedores"
        Me.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnClients
        '
        Me.btnClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnClients.FlatAppearance.BorderSize = 0
        Me.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.Image = Global.riControl.My.Resources.Resources.iconfinder_173_95790
        Me.btnClients.Location = New System.Drawing.Point(12, 14)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(165, 156)
        Me.btnClients.TabIndex = 0
        Me.btnClients.Text = "Clientes"
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClients.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Image = Global.riControl.My.Resources.Resources.settings
        Me.btnSettings.Location = New System.Drawing.Point(730, 533)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(137, 51)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Configurações"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.riControl.My.Resources.Resources.none
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Image = Global.riControl.My.Resources.Resources.about
        Me.btnAbout.Location = New System.Drawing.Point(761, 12)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(106, 51)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "Sobre o riControl"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.riControl.My.Resources.Resources.dbError
        Me.PictureBox2.Location = New System.Drawing.Point(12, 543)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'lblDatabaseStatus
        '
        Me.lblDatabaseStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDatabaseStatus.AutoSize = True
        Me.lblDatabaseStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseStatus.Location = New System.Drawing.Point(52, 550)
        Me.lblDatabaseStatus.Name = "lblDatabaseStatus"
        Me.lblDatabaseStatus.Size = New System.Drawing.Size(106, 17)
        Me.lblDatabaseStatus.TabIndex = 8
        Me.lblDatabaseStatus.Text = "Banco de Dados"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(879, 596)
        Me.Controls.Add(Me.lblDatabaseStatus)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblClock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Início | riControl"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClients As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblClock As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnBills As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnBalance As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblDatabaseStatus As Label
End Class
