Imports System.Data.OleDb

Public Class Form1

    ' Connection to database (States.mdb must be in Debug folder)
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\States.mdb")

    ' Open connection when form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
    End Sub

    ' Show all states
    Private Sub btnStates_Click(sender As Object, e As EventArgs) Handles btnStates.Click
        ShowAll()


    End Sub


    Private Sub ShowAll()

        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter("SELECT * FROM States", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table

    End Sub





    ' Show population less than 1 million
    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click

        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter("SELECT * FROM States WHERE Population < 1000000", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table

    End Sub


    Private Sub ShowByAbbreviation()

        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter(
            "SELECT * FROM States WHERE Abbreviation = '" & txtOutput.Text & "'", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table

    End Sub

    Private Sub cboOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOptions.SelectedIndexChanged
        If cboOptions.SelectedIndex = 0 Then
            DisplayStateByAbbreviation()
        ElseIf cboOptions.SelectedIndex = 1 Then
            DisplayLandAreaLess2000()
        End If
    End Sub


    Private Sub DisplayLandAreaLess2000()

        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter(
        "SELECT * FROM States WHERE [Land Area] < 2000", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table

    End Sub





    Private Sub DisplayStateByAbbreviation()

        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter(
        "SELECT * FROM States WHERE Abbreviation = '" & txtOutput.Text & "'", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table

    End Sub



    Private Sub ShowAreaLessThan2000()

        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter(
            "SELECT * FROM States WHERE [Land Area] < 2000", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table

    End Sub

    Private Sub btnCities_Click(sender As Object, e As EventArgs) Handles btnCities.Click
        Dim table As New DataTable
        Dim adapter As New OleDbDataAdapter("SELECT * FROM Cities", conn)

        adapter.Fill(table)
        dgvStates.DataSource = table
    End Sub
End Class