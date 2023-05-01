Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Reflection
'Import of Real Time Graph Attempt 
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading
Imports DevExpress.Data.Helpers
Imports DevExpress.Utils.Filtering.Internal
Imports DevExpress.Data.Mask.Internal
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Utils
Imports Microsoft.VisualBasic.Devices
Imports DevExpress.XtraSpellChecker.Parser

Public Class Form1

    Public Property AxisX2 As Axis
    Dim StrParse, LDR_1, LDR_2, Pot, RTU, CUV_4, CUV_5, CUV_6, CUV_7, CUV_8 As String
    Dim LDR_1L, LDR_2L, PotL, RTUL, CUV_4L, CUV_5L, CUV_6L, CUV_7L, CUV_8L As Integer
    Dim Limit As Integer = 16200
    Dim FilePathAndName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.CenterToScreen()
        ButtonDisconnect.Enabled = False
        ButtonConnect.Enabled = False
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = False
        ComboBoxBaudRate.SelectedIndex = 3
        Chart1.ChartAreas(0).AxisX.IntervalAutoMode = True
        ButtonSaveToExcel.Height = 50

        For i = 0 To 30 Step 1
            Dim position As Integer = 0
            Dim blockSize As Integer = 10
            Dim size As Integer = blockSize

            Chart1.ChartAreas(0).AxisX.ScaleView.Zoom(position, size)
            Chart1.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All
            Chart1.ChartAreas(0).AxisX.ScaleView.SmallScrollSize = AutoScaleMode


            Chart1.Series("AU 1").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            'Chart1.ChartAreas(0).AxisY.Maximum = 1100

            Chart1.Series("AU 2").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 3").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 4").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(3).Points.Count = Limit Then
                Chart1.Series(3).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 5").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(4).Points.Count = Limit Then
                Chart1.Series(4).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 6").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(5).Points.Count = Limit Then
                Chart1.Series(5).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 7").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(6).Points.Count = Limit Then
                Chart1.Series(6).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 8").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(7).Points.Count = Limit Then
                Chart1.Series(7).Points.RemoveAt(0)
            End If

            '' ChartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll

            'HandleEmpty(empty)
            'Cursor.Current = Cursors.Default

        Next


        Chart1.ChartAreas(0).AxisY.Maximum = 1500




    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanport.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            ButtonConnect.Enabled = False
            ButtonStartRecording.Enabled = False
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub




    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
        SerialPort1.PortName = ComboBoxPort.SelectedItem
        SerialPort1.Open()
        TimerSerial.Start()

        ComboBoxPort.Enabled = False
        Label1.Enabled = False
        ComboBoxBaudRate.Enabled = False
        ButtonScanport.Enabled = False
        ButtonConnect.Enabled = False
        ButtonDisconnect.Enabled = True
        ButtonStartRecording.Enabled = True

        PictureBoxConnectionInd.Image = My.Resources.green
        LabelStatus.Text = "Status : Connected"
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PictureBoxConnectionInd.Image = My.Resources.red
        PictureBoxConnectionInd.Visible = True
        LabelStatus.Text = "Status : Disconnect"

        ComboBoxPort.Enabled = True
        Label1.Enabled = True
        ComboBoxBaudRate.Enabled = True
        ButtonScanport.Enabled = True
        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False

        TimerSerial.Stop()
        TimerDataLogRecord.Stop()

        ButtonSaveToExcel.Enabled = True
        ButtonStopRecording.Enabled = False

        SerialPort1.Close()
    End Sub

    Private Sub ButtonStartRecording_Click(sender As Object, e As EventArgs) Handles ButtonStartRecording.Click
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = True
        ButtonSaveToExcel.Enabled = False
        TimerDataLogRecord.Start()
        TimerDataLogRecord.Interval = 2500 - Now.Second
    End Sub

    Private Sub ButtonStopRecording_Click(sender As Object, e As EventArgs) Handles ButtonStopRecording.Click
        ButtonStartRecording.Enabled = True
        ButtonStopRecording.Enabled = False
        ButtonSaveToExcel.Enabled = True
        TimerDataLogRecord.Stop()
        PictureBoxRecordInd.Visible = True
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        For i = 0 To 30 Step 1
            Chart1.Series("AU 1").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            'Chart1.ChartAreas(0).AxisY.Maximum = 1100

            Chart1.Series("AU 2").Points.AddY(0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 3").Points.AddY(0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If
            Chart1.Series("AU 4").Points.AddY(0)
            If Chart1.Series(3).Points.Count = Limit Then
                Chart1.Series(3).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 5").Points.AddY(0)
            If Chart1.Series(4).Points.Count = Limit Then
                Chart1.Series(4).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 6").Points.AddY(0)
            If Chart1.Series(5).Points.Count = Limit Then
                Chart1.Series(5).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 7").Points.AddY(0)
            If Chart1.Series(6).Points.Count = Limit Then
                Chart1.Series(6).Points.RemoveAt(0)
            End If

            Chart1.Series("AU 8").Points.AddY(0)
            If Chart1.Series(7).Points.Count = Limit Then
                Chart1.Series(7).Points.RemoveAt(0)
            End If

        Next
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 7").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox1.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True



        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 7").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox2.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 7").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox3.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 7").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox4.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 7").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox5.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 7").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox6.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 8").Enabled = False

        End If
        If CheckBox7.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            Chart1.Series("AU 1").Enabled = False
            Chart1.Series("AU 2").Enabled = False
            Chart1.Series("AU 3").Enabled = False
            Chart1.Series("AU 4").Enabled = False
            Chart1.Series("AU 5").Enabled = False
            Chart1.Series("AU 6").Enabled = False
            Chart1.Series("AU 7").Enabled = False

        End If
        If CheckBox8.Checked = False Then
            Chart1.Series("AU 1").Enabled = True
            Chart1.Series("AU 2").Enabled = True
            Chart1.Series("AU 3").Enabled = True
            Chart1.Series("AU 4").Enabled = True
            Chart1.Series("AU 5").Enabled = True
            Chart1.Series("AU 6").Enabled = True
            Chart1.Series("AU 7").Enabled = True
            Chart1.Series("AU 8").Enabled = True
        End If
    End Sub

    Public Property RtsEnable As Boolean


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()


        Timer1.Interval = 1000 - Now.Second
        Timer1.Start()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        'Chart1.Series("AU 1").Color = Color.FromArgb(0, 0, 0, 0)

        'Chart1.Series("AU 1").ChartType = DataVisualization.Charting.SeriesChartType.FastLine = False
        ' Chart1.Series("AU 2").ChartType = DataVisualization.Charting.SeriesChartType.Spline = True
        'Chart1.ChartAreas("ChartArea1").AxisX2.Enabled = AxisEnabled.True
        'Chart1.Series(0).XAxisType = AxisType.Secondary
        ' Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = True
        ' Chart1.ChartAreas(0).AxisX.Enabled = AxisEnabled.True
        ' Chart1.ChartAreas(0).AxisX2.Enabled = AxisEnabled.True
        'Chart1.ChartAreas(0).AxisX2.LabelStyle.Enabled = True
        ' Chart1.ChartAreas(0).AxisX.Interval = 25

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Labelrtu.Click

    End Sub

    Private Sub LabelLDR1_Click(sender As Object, e As EventArgs) Handles LabelLDR1.Click

    End Sub

    Private Sub ButtonSaveToExcel_Click(sender As Object, e As EventArgs) Handles ButtonSaveToExcel.Click
        ButtonSaveToExcel.Height = 37
        ButtonSaveToExcel.Text = "Please Wait..."
        ButtonSaveToExcel.Enabled = False
        ButtonStartRecording.Enabled = False
        ProgressBarProcess.Visible = True
        ProgressBarProcess.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProcess.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        ProgressBarProcess.Value = 5

        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.RowHeadersVisible = False

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value
                Next
            Next
        Next

        ProgressBarProcess.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        xlWorkSheet.SaveAs(FilePathAndName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        ProgressBarProcess.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProcess.Visible = False

        Process.Start(FilePathAndName)

        ButtonSaveToExcel.Height = 50
        ButtonSaveToExcel.Text = "Save To MS Excel"
        ButtonSaveToExcel.Enabled = True
        ButtonStartRecording.Enabled = True
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(1)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TimerDataLogRecord_Tick(sender As Object, e As EventArgs) Handles TimerDataLogRecord.Tick

        Dim LDR_1Log, LDR_2Log, PotLog, RTULog, CUV_4Log, CUV_5Log, CUV_6Log, CUV_7Log, CUV_8Log As String
        Dim DT As DateTime = Now
        ' Me.Chart1.ChartAreas(0).AxisX.Interval = 1
        LDR_1Log = Mid(LDR_1, 3, LDR_1L)
        LDR_2Log = Mid(LDR_2, 3, LDR_2L)
        PotLog = Mid(Pot, 3, PotL)
        RTULog = Mid(RTU, 3, RTUL)
        CUV_4Log = Mid(CUV_4, 3, CUV_4L)
        CUV_5Log = Mid(CUV_5, 3, CUV_5L)
        CUV_6Log = Mid(CUV_6, 3, CUV_6L)
        CUV_7Log = Mid(CUV_7, 3, CUV_7L)
        CUV_8Log = Mid(CUV_8, 3, CUV_8L)


        DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, LDR_1Log, LDR_2Log, PotLog, CUV_4Log, CUV_5Log, CUV_6Log, CUV_7Log, CUV_8Log, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy")})
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1


        Chart1.Series("AU 1").Points.AddXY(DateTime.Now.ToLongTimeString, LDR_1Log)
        If Chart1.Series(0).Points.Count = Limit Then
            Chart1.Series(0).Points.RemoveAt(0)
        End If

        Chart1.Series("AU 2").Points.AddXY(DateTime.Now.ToLongTimeString, LDR_2Log)
        If Chart1.Series(1).Points.Count = Limit Then
            Chart1.Series(1).Points.RemoveAt(0)
        End If

        Chart1.Series("AU 3").Points.AddXY(DateTime.Now.ToLongTimeString, PotLog)
        If Chart1.Series(2).Points.Count = Limit Then
            Chart1.Series(2).Points.RemoveAt(0)
        End If

        Chart1.Series("AU 4").Points.AddXY(DateTime.Now.ToLongTimeString, CUV_4Log)
        If Chart1.Series(3).Points.Count = Limit Then
            Chart1.Series(3).Points.RemoveAt(0)
        End If


        Chart1.Series("AU 5").Points.AddXY(DateTime.Now.ToLongTimeString, CUV_5Log)
        If Chart1.Series(4).Points.Count = Limit Then
            Chart1.Series(4).Points.RemoveAt(0)
        End If

        Chart1.Series("AU 6").Points.AddXY(DateTime.Now.ToLongTimeString, CUV_6Log)
        If Chart1.Series(5).Points.Count = Limit Then
            Chart1.Series(5).Points.RemoveAt(0)
        End If

        Chart1.Series("AU 7").Points.AddXY(DateTime.Now.ToLongTimeString, CUV_7Log)
        If Chart1.Series(6).Points.Count = Limit Then
            Chart1.Series(6).Points.RemoveAt(0)
        End If


        Chart1.Series("AU 8").Points.AddXY(DateTime.Now.ToLongTimeString, CUV_8Log)
        If Chart1.Series(7).Points.Count = Limit Then
            Chart1.Series(7).Points.RemoveAt(0)
        End If



        If PictureBoxRecordInd.Visible = True Then
            PictureBoxRecordInd.Visible = False
        ElseIf PictureBoxRecordInd.Visible = False Then
            PictureBoxRecordInd.Visible = True
        End If
    End Sub

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Timer1.Start()
        TimerSerial.Interval = 500 - Now.Second

        Try
            Dim StrSerialIn As String = SerialPort1.ReadExisting
            Dim StrSerialInRam As String

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            StrSerialInRam = TB.Lines(0).Substring(0, 2)
            If StrSerialInRam = "L1" Then
                LDR_1 = TB.Lines(0)
                LDR_1L = LDR_1.Length
            Else
                LDR_1 = LDR_1
            End If

            StrSerialInRam = TB.Lines(1).Substring(0, 2)
            If StrSerialInRam = "L2" Then
                LDR_2 = TB.Lines(1)
                LDR_2L = LDR_2.Length
            Else
                LDR_2 = LDR_2
            End If

            StrSerialInRam = TB.Lines(2).Substring(0, 2)
            If StrSerialInRam = "Pt" Then
                Pot = TB.Lines(2)
                PotL = Pot.Length
            Else
                Pot = Pot
            End If
            StrSerialInRam = TB.Lines(3).Substring(0, 2)
            If StrSerialInRam = "RT" Then
                RTU = TB.Lines(3)
                RTUL = RTU.Length
            Else
                RTU = RTU
            End If
            StrSerialInRam = TB.Lines(5).Substring(0, 2)
            If StrSerialInRam = "C4" Then
                CUV_4 = TB.Lines(5)
                CUV_4L = CUV_4.Length
            Else
                CUV_4 = CUV_4
            End If

            StrSerialInRam = TB.Lines(6).Substring(0, 2)
            If StrSerialInRam = "C5" Then
                CUV_5 = TB.Lines(6)
                CUV_5L = CUV_5.Length
            Else
                CUV_5 = CUV_5
            End If

            StrSerialInRam = TB.Lines(7).Substring(0, 2)
            If StrSerialInRam = "C6" Then
                CUV_6 = TB.Lines(7)
                CUV_6L = CUV_6.Length
            Else
                CUV_6 = CUV_6
            End If

            StrSerialInRam = TB.Lines(8).Substring(0, 2)
            If StrSerialInRam = "C7" Then
                CUV_7 = TB.Lines(8)
                CUV_7L = CUV_6.Length
            Else
                CUV_7 = CUV_7
            End If

            StrSerialInRam = TB.Lines(9).Substring(0, 2)
            If StrSerialInRam = "C8" Then
                CUV_8 = TB.Lines(9)
                CUV_8L = CUV_6.Length
            Else
                CUV_8 = CUV_8
            End If




            If PictureBoxConnectionInd.Visible = True Then
                PictureBoxConnectionInd.Visible = False
            ElseIf PictureBoxConnectionInd.Visible = False Then
                PictureBoxConnectionInd.Visible = True
            End If


            StrSerialInRam = TB.Lines(4).Substring(0, 2)
            If StrSerialInRam = "RT" Then
                Label3.Text = "Phase Interval: Protien Concentration X detected"

            Else
                'Label3.Text = "Live interval: Waiting For Protien"
            End If

            StrSerialInRam = TB.Lines(4).Substring(0, 2)
            If StrSerialInRam = "RU" Then
                Label3.Text = "Phase Interval: Phase Switch Detected"

            Else
                'Label3.Text = "Live interval: Waiting For Protien"
            End If



            LabelLDR1.Text = "Ch.1 UV280= " & Mid(LDR_1, 3, LDR_1L)
            LabelLDR2.Text = "Ch.2 UV280= " & Mid(LDR_2, 3, LDR_2L)
            LabelPOT.Text = "Ch.3 UV280= " & Mid(Pot, 3, PotL)
            Labelrtu.Text = "REAL TIME UPDATES " & LSet(RTU, 4)
            LabelC4.Text = "Ch.4 UV280= " & Mid(CUV_4, 3, CUV_4L)
            LabelC5.Text = "Ch.5 UV280= " & Mid(CUV_5, 3, CUV_5L)
            LabelC6.Text = "Ch.6 UV280= " & Mid(CUV_6, 3, CUV_6L)
            LabelC7.Text = "Ch.7 UV280= " & Mid(CUV_7, 3, CUV_7L)
            LabelC8.Text = "Ch.8 UV280= " & Mid(CUV_8, 3, CUV_8L)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub SetDoubleBuffered(ByVal control As Control)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
    End Sub

End Class