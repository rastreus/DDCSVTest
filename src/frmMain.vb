#If False Then
Copyright © 2015 Russell Dillin

This file is part of DDCSVTest.

DDCSVTest is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

DDCSVTest is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with DDCSVTest. If not, see <http://www.gnu.org/licenses/>.
#End If

Imports DDCSVTest.SpBtn

''' <summary>
''' DDCSVTest;
''' Russell Dillin;
''' 08/18/2015;
''' </summary>
''' <remarks>
''' DDCSVTest parses and manipulates
''' a CSV file which has been
''' dragged onto a panel.
''' </remarks>
Public Class frmMain

#Region "Properties"
	Private _xIndex As Integer = -1
	Private _yIndex As Integer = -1

	Public Property xIndex As Integer
		Get
			Return _xIndex
		End Get
		Set(value As Integer)
			_xIndex = value
		End Set
	End Property

	Public Property yIndex As Integer
		Get
			Return _yIndex
		End Get
		Set(value As Integer)
			_yIndex = value
		End Set
	End Property
#End Region
#Region "DragDrop"
	Private Delegate Sub DelegateChangeLabel(ByVal s As String)
	Private m_DelegateChangeLabel As DelegateChangeLabel

	Private Delegate Sub DelegateCSVtoComboBox(ByVal s As String)
	Private m_DelegateCSVtoComboBox As DelegateCSVtoComboBox

	Private Sub frmMain_Load(sender As Object, _
							 e As EventArgs) _
		Handles Me.Load
		m_DelegateChangeLabel = _
			New DelegateChangeLabel(AddressOf Me.ChangeLabel)
		m_DelegateCSVtoComboBox = _
			New DelegateCSVtoComboBox(AddressOf Me.CSVtoComboBox)
	End Sub

	Private Sub pnlDrag_DragEnter(sender As Object, _
								  e As DragEventArgs) _
		Handles pnlDrag.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub pnlDrag_DragDrop(sender As Object, _
								 e As DragEventArgs) _
		Handles pnlDrag.DragDrop
		Try
			Dim a As Array = _
				CType(e.Data.GetData(DataFormats.FileDrop), Array)
			If Not IsNothing(a) Then
				Dim s As String = a.GetValue(0).ToString
				Me.BeginInvoke(m_DelegateChangeLabel, New Object() {s})
				Me.BeginInvoke(m_DelegateCSVtoComboBox, New Object() {s})
				Me.pnlDrag.BackColor = Color.PaleGreen
				enableSpB(Me.spbX, "X")
				enableSpB(Me.spbY, "Y")
			End If
		Catch ex As Exception
			Trace.WriteLine("Error in DragDrop: " & ex.Message)
			Me.lblDrag.Text = "Error in DragDrop: " & ex.Message
			Me.pnlDrag.BackColor = Color.Red
		End Try
	End Sub

	Private Sub ChangeLabel(ByVal s As String)
		Me.lblDrag.Text = s
	End Sub
#End Region
#Region "CSVtoComboBox"
	Private Sub CSVtoComboBox(ByVal filePath As String)
		Dim parser As New FileIO.TextFieldParser(filePath)
		parser.Delimiters = New String() {","}
		parser.HasFieldsEnclosedInQuotes = False
		parser.TrimWhiteSpace = True

		For Each header As String In parser.ReadFields()
			Me.cbY.Items.Add(header)
			Me.cbX.Items.Add(header)
		Next
	End Sub
#End Region
#Region "UI/UX"
	Private Sub toggleComboBox(ByRef cb As ComboBox)
		If cb.Enabled = False Then
			cb.Enabled = True
			cb.DroppedDown = True
		Else
			cb.Enabled = False
			cb.DroppedDown = False
		End If
	End Sub

	Private Sub enableSpB(ByRef spb As SpBtn, _
						  ByVal txt As String)
		spb.Enabled = True
		spb.BackColor = Color.LightCyan
		spb.Text = txt
	End Sub

	Private Sub disableSpB(ByRef spb As SpBtn)
		spb.Disable()
	End Sub

	Private Sub spbPromoID_Click(sender As Object, _
								 e As EventArgs) _
		Handles spbX.Click
		toggleComboBox(Me.cbX)
	End Sub

	Private Sub spbNumOfTickets_Click(sender As Object, _
									  e As EventArgs) _
		Handles spbY.Click
		toggleComboBox(Me.cbY)
	End Sub

	Private Sub cbPromoID_DropDownClosed(sender As Object, _
										 e As EventArgs) _
		Handles cbX.DropDownClosed
		disableSpB(Me.spbX)
		toggleComboBox(Me.cbX)
		Me.xIndex = Me.cbX.SelectedIndex
		checkToEnableSet()
		Me.ActiveControl = Me.pnlDrag
	End Sub

	Private Sub cbNumOfTickets_DropDownClosed(sender As Object, _
											  e As EventArgs) _
		Handles cbY.DropDownClosed
		disableSpB(Me.spbY)
		toggleComboBox(Me.cbY)
		Me.yIndex = Me.cbY.SelectedIndex
		checkToEnableSet()
		Me.ActiveControl = Me.pnlDrag
	End Sub

	Private Sub checkToEnableSet()
		If Me.yIndex >= 0 AndAlso _
			Me.xIndex >= 0 Then
			Me.btnSet.BackColor = Color.LavenderBlush
			Me.btnSet.Text = "Set"
			Me.btnSet.Enabled = True
		End If
	End Sub

	Private Sub enableLabel(ByRef lbl As Label)
		lbl.Enabled = True
		lbl.Visible = True
	End Sub

	Private Sub btnSet_Click(sender As Object, _
							 e As EventArgs) _
		Handles btnSet.Click
		Me.lblX.Text = _
			"X Index: " & Me.xIndex.ToString
		Me.lblY.Text = _
			"Y Index: " & Me.yIndex.ToString
		If (Me.lblX.Enabled = False AndAlso _
			Me.lblY.Enabled = False) Then
			enableLabel(Me.lblX)
			enableLabel(Me.lblY)
		End If
	End Sub
#End Region
End Class
