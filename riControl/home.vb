Public Class home

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        clientList.Show()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = FormatDateTime(DateTime.Now, DateFormat.LongDate)
        lblClock.Text = TimeString
    End Sub

    Private Sub home_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Tem certeza que deseja sair? Todas as Janelas serão encerradas!", vbExclamation + vbOKCancel, "Sair da Aplicação?") = vbCancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            PictureBox1.Image = New Bitmap(open.FileName)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.BackgroundImage = Nothing
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSettings.Click

    End Sub

    Private Sub lblDatabaseStatus_Click(sender As Object, e As EventArgs) Handles lblDatabaseStatus.Click

    End Sub

    Private Sub RiControl_dbDataSet_Initialized(sender As Object, e As EventArgs)

    End Sub

End Class
