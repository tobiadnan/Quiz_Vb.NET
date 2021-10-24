Imports System.Data
Imports System.Data.SqlClient

Public Class Form_Anggota
    Dim objCmd As New SqlCommand
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataSet As New DataSet
    Dim objDataTableForShow As New DataTable
    Dim objDataTable2 As New DataTable
    Dim objDataReader As SqlDataReader
    Dim myConnection As New dbHelper.dbConnection
    Dim strSQL, tbJenisK As String

    Private Sub Form_Anggota_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbQuizDataSet.tblAnggota' table. You can move, or remove it, as needed.
        ' Me.TblAnggotaTableAdapter.Fill(Me.DbQuizDataSet.tblAnggota)
        MdiParent = Form_StartUp
        On Error Resume Next

        Call dgStyle()
        Call getData()
        Call clearData()
        Call idAnggota()

        
    End Sub
    Sub dgStyle()
        With dataGridAnggota
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .DefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub
    Private Sub getData()
        On Error Resume Next
        objDataTableForShow.Clear()
        strSQL = "SELECT * FROM tblAnggota"

        objCmd.Connection = myConnection.Open
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = strSQL
        objDataAdapter = New SqlDataAdapter(objCmd)
        objDataAdapter.Fill(objDataSet, "dataAnggota")
        myConnection.Close()
        objDataTableForShow = objDataSet.Tables("dataAnggota")
        dataGridAnggota.DataSource = objDataTableForShow

        strSQL = ""

    End Sub
    Private Sub clearData()
        tbNAMA.Text = ""
        tbKTP.Text = ""
        radioPria.Checked = False
        radioWanita.Checked = False
        tbALAMAT.Text = ""
        comboGOLDAR.Text = "A"
        tbTLP.Text = ""
        comboAGAMA.Text = "ISLAM"
        tbUMUR.Text = ""
        tbHOBI.Text = ""
        tbIBU.Text = ""
        comboSTATUSNIKAH.Text = "SINGLE"


        btnSAVE.Enabled = False
        btnDELETE.Enabled = False

        btnSAVE.Text = "SAVE"
        btnCLOSE.Text = "CLOSE"
        tbID.Focus()
    End Sub
    Private Sub idAnggota()
        Call getAuto()
        If objDataTable2.Rows.Count = 0 Then
            tbID.Text = "TI-0002019"
        Else
            With objDataTable2.Rows(0)
                tbID.Text = .Item("idAnggota")
            End With
            tbID.Text = Val(Microsoft.VisualBasic.Mid(tbID.Text, 4, 7)) + 1
            If Len(tbID.Text) = 1 Then
                tbID.Text = "TI-000201" & tbID.Text & ""
            ElseIf Len(tbID.Text) = 2 Then
                tbID.Text = "TI-00020" & tbID.Text & ""
            ElseIf Len(tbID.Text) = 3 Then
                tbID.Text = "TI-0002" & tbID.Text & ""
            ElseIf Len(tbID.Text) = 4 Then
                tbID.Text = "TI-000" & tbID.Text & ""
            ElseIf Len(tbID.Text) = 5 Then
                tbID.Text = "TI-00" & tbID.Text & ""
            ElseIf Len(tbID.Text) = 6 Then
                tbID.Text = "TI-0" & tbID.Text & ""
            ElseIf Len(tbID.Text) = 7 Then
                tbID.Text = "TI-" & tbID.Text & ""
            End If
        End If
    End Sub

    Private Sub getAuto()

        objDataTable2.Clear()
        strSQL = "SELECT * FROM tblAnggota ORDER BY idAnggota DESC"
        objCmd.Connection = myConnection.Open
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = strSQL
        objDataAdapter = New SqlDataAdapter(objCmd)
        objDataAdapter.Fill(objDataSet, "getAuto")
        myConnection.Close()
        objDataTable2 = objDataSet.Tables("getAuto")
        'dgPasien.DataSource = objDataTable2

    End Sub

    Private Sub checkAnggota()
        Try
            objDataTable2.Clear()
            strSQL = "SELECT * FROM tblAnggota WHERE idAnggota = '" & tbID.Text & "'"
            objCmd.Connection = myConnection.Open
            objCmd.CommandType = CommandType.Text
            objCmd.CommandText = strSQL
            objDataAdapter = New SqlDataAdapter(objCmd)
            objDataAdapter.Fill(objDataSet, "checkAnggota")
            myConnection.Close()
            objDataTable2 = objDataSet.Tables("checkAnggota")
            'dgPasien.DataSource = objDataTableForShow
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbID_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbID.KeyUp
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Call checkAnggota()
            If objDataTable2.Rows.Count = 0 Then
                btnDELETE.Enabled = False
            Else
                objCmd = myConnection.Open.CreateCommand
                objCmd.CommandText = "SELECT * FROM tblAnggota WHERE idAnggota = '" & tbID.Text & "'"
                objDataReader = objCmd.ExecuteReader
                objDataReader.Read()
                tbNAMA.Text = objDataReader.Item("namaAnggota")
                tbKTP.Text = objDataReader.Item("noKtp")
                If objDataReader.Item("jenisKelamin") = "L" Then
                    radioPria.Checked = True
                ElseIf objDataReader.Item("jenisKelamin") = "P" Then
                    radioWanita.Checked = True
                End If
                tbALAMAT.Text = objDataReader.Item("alamat")
                comboGOLDAR.Text = objDataReader.Item("golDarah")
                tbTLP.Text = objDataReader.Item("noTlp")
                comboAGAMA.Text = objDataReader.Item("agama")
                tbUMUR.Text = objDataReader.Item("umur")
                tbHOBI.Text = objDataReader.Item("hobi")
                tbIBU.Text = objDataReader.Item("namaIbu")
                comboSTATUSNIKAH.Text = objDataReader.Item("statusPerkawinan")
                myConnection.Close()
                btnDELETE.Enabled = True
                btnSAVE.Text = "UPDATE"
            End If

            If tbJenisK = "L" Then
                radioPria.Checked = True
            Else
                radioWanita.Checked = True
            End If
            btnCLOSE.Text = "CANCLE"
            btnSAVE.Enabled = True
            tbNAMA.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            tbKTP.Focus()
        End If
    End Sub

    Private Sub tbKTP_KeyDowln(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbKTP.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbNAMA.Focus()
        End If
    End Sub

    Private Sub radioPria_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioPria.CheckedChanged
        tbALAMAT.Focus()

    End Sub

    Private Sub radioWanita_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioWanita.CheckedChanged
        tbALAMAT.Focus()
    End Sub

    Private Sub tbALAMAT_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbALAMAT.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbUMUR.Focus()
        End If
    End Sub

    Private Sub tbUMUR_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbUMUR.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbTLP.Focus()
        End If

    End Sub

    Private Sub tbTLP_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbTLP.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbHOBI.Focus()
        End If

    End Sub

    Private Sub tbHOBI_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbHOBI.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbIBU.Focus()
        End If

    End Sub

    Private Sub btnSAVE_Click(sender As System.Object, e As System.EventArgs) Handles btnSAVE.Click
        On Error Resume Next
        If radioPria.Checked = True Then
            tbJenisK = "L"
        ElseIf radioWanita.Checked = True Then
            tbJenisK = "P"
        End If
        If btnSAVE.Text = "SAVE" Then

            strSQL = "INSERT INTO tblAnggota VALUES ('" & tbID.Text & "', '" & tbNAMA.Text & "','" & tbKTP.Text & "', '" & tbJenisK & "','" & tbALAMAT.Text & "', '" & comboGOLDAR.Text & "','" & tbTLP.Text & "', '" & comboAGAMA.Text & "','" & tbUMUR.Text & "', '" & tbHOBI.Text & "','" & tbIBU.Text & "', '" & comboSTATUSNIKAH.Text & "')"
            MsgBox("Data Saved", vbInformation)
        Else
            If radioPria.Checked = True Then
                tbJenisK = "L"
            ElseIf radioWanita.Checked = True Then
                tbJenisK = "P"
            End If
            strSQL = "UPDATE tblAnggota SET namaAnggota = '" & tbNAMA.Text & "', noKtp = '" & tbKTP.Text & "', jenisKelamin = '" & tbJenisK & "', alamat = '" & tbALAMAT.Text & "', golDarah = '" & comboGOLDAR.Text & "', noTlp = '" & tbTLP.Text & "', agama = '" & comboAGAMA.Text & "', umur = '" & tbUMUR.Text & "', hobi = '" & tbHOBI.Text & "', namaIbu = '" & tbIBU.Text & "', statusPerkawinan = '" & comboSTATUSNIKAH.Text & "' WHERE idAnggota = '" & tbID.Text & "'"
            MsgBox("Data Updated", vbInformation)
        End If
        Call executeCRUD()
        Call getData()
        Call clearData()
        Call idAnggota()
    End Sub
    Private Sub executeCRUD()
        myConnection.Close()
        objCmd.CommandText = strSQL
        objCmd.Connection = myConnection.Open
        objCmd.ExecuteNonQuery()
        myConnection.Close()
        strSQL = ""

    End Sub

    Private Sub btnCLOSE_Click(sender As System.Object, e As System.EventArgs) Handles btnCLOSE.Click
        If btnCLOSE.Text = "CLOSE" Then
            Me.Close()
        Else
            Call clearData()
            Call idAnggota()

        End If
    End Sub

    Private Sub btnDELETE_Click(sender As System.Object, e As System.EventArgs) Handles btnDELETE.Click
        If Len(Trim(tbID.Text)) = 0 Then
            Exit Sub
        End If
        Dim mYes_No As String = MsgBox("Delete " & tbNAMA.Text & " Are you sure ?", vbYesNo)
        If mYes_No = vbYes Then
            strSQL = "DELETE FROM tblAnggota WHERE idAnggota = '" & tbID.Text & "'"

            Call executeCRUD()
            MsgBox("Data Deleted", vbInformation)
            Call getData()
            Call clearData()

        End If
    End Sub
End Class