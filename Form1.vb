Imports System.Data.SqlClient
Public Class Form1
    Dim MyDb As String = "Data source=MPIYUSH3510-AMD;Initial catalog=Admin574;Integrated Security =true"
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub CreateTable()
        cmd = New SqlCommand("create table demo(rno int unique ,name varchar(20))", con)

        Try
            cmd.ExecuteNonQuery()
        Catch d As Exception
            MsgBox(d.Message)
        End Try
    End Sub

    Private Sub InsertData()

        Dim rno As Integer = Convert.ToInt32(TextBoxRno.Text)
        Dim name As String = TextBoxName.Text

        cmd = New SqlCommand("insert into demo values (@rno,@name)", con)
        cmd.Parameters.AddWithValue("@rno", rno)
        cmd.Parameters.AddWithValue("@name", name)

        Try
            cmd.ExecuteNonQuery()
        Catch d As Exception
            MsgBox(d.Message)
        End Try
        ShowData()
    End Sub

    Private Sub ShowData()
        Dim dtAdapter As SqlDataAdapter
        Dim dtSet As DataSet

        dtAdapter = New SqlDataAdapter("select * from demo order by rno", con)
        dtSet = New DataSet
        dtAdapter.Fill(dtSet, "demo")
        GridViewReader.DataSource = dtSet.Tables(0).DefaultView
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        con = New SqlConnection(MyDb)
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                ' MsgBox("Connected ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If TextBoxRno.Text = "" And TextBoxName.Text = "" Then
            MsgBox("all fields are blank !")
            Return
        End If

        If TextBoxRno.Text = "" Then
            MsgBox("Rno can't be empty")
            Return
        End If

        If TextBoxName.Text = "" Then
            MsgBox("Name can't be empty")
            Return
        End If
        'CreateTable()
        InsertData()
        ButtonClear_Click(sender, e)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxRno.Clear()
        TextBoxName.Clear()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click   ''try something
        con = New SqlConnection(MyDb)
        con.Open()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As DataSet

            dtAdapter = New SqlDataAdapter("select * from demo order by rno", con)
            dtSet = New DataSet
            dtAdapter.Fill(dtSet, "demo")
            GridViewReader.DataSource = dtSet.Tables(0).DefaultView

        Catch ex As Exception
            'con.Dispose()
            'con = Nothing
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        con = New SqlConnection(MyDb)
        con.Open()

        If GridViewReader.RowCount = 0 Then
            MsgBox("unable to deleted, table is empty !", MsgBoxStyle.Critical, "failed")
            Return
        End If

        If MsgBox("Delete record ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If GridViewReader.AreAllCellsSelected(0) = True Then
                cmd = New SqlCommand("delete from demo", con)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            For Each row As DataGridViewRow In GridViewReader.SelectedRows
                If row.Selected Then
                    cmd = New SqlCommand("delete from demo where rno = '" & row.DataBoundItem(0).ToString & "'", con)
                    cmd.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ButtonRefresh_Click(sender, e)
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TextBoxName.Text = "" Then
            MsgBox("Fill Up Name !")
            Return
        End If

        If TextBoxRno.Text = "" Then
            MsgBox("Fill Up Rno !")
            Return
        End If

        con = New SqlConnection(MyDb)
        con.Open()

        Try
            Dim rno As Integer = Convert.ToUInt32(TextBoxRno.Text)
            Dim name As String = TextBoxName.Text

            cmd = New SqlCommand("update demo set name= @name where rno = @rno", con)
            cmd.Parameters.AddWithValue("@rno", rno)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.ExecuteNonQuery()
            MsgBox("Update Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ButtonRefresh_Click(sender, e)
        ButtonClear_Click(sender, e)
    End Sub
End Class
