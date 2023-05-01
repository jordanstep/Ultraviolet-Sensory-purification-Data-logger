<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.LabelPOT = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.PictureBoxConnectionInd = New System.Windows.Forms.PictureBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelC8 = New System.Windows.Forms.Label()
        Me.LabelC7 = New System.Windows.Forms.Label()
        Me.LabelC6 = New System.Windows.Forms.Label()
        Me.LabelC5 = New System.Windows.Forms.Label()
        Me.LabelC4 = New System.Windows.Forms.Label()
        Me.LabelLDR2 = New System.Windows.Forms.Label()
        Me.LabelLDR1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.Recording = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonStopRecording = New System.Windows.Forms.Button()
        Me.ButtonStartRecording = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProcess = New System.Windows.Forms.ProgressBar()
        Me.ButtonSaveToExcel = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AU4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Labelrtu = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelPOT
        '
        Me.LabelPOT.AutoSize = True
        Me.LabelPOT.Location = New System.Drawing.Point(0, 101)
        Me.LabelPOT.Name = "LabelPOT"
        Me.LabelPOT.Size = New System.Drawing.Size(94, 17)
        Me.LabelPOT.TabIndex = 2
        Me.LabelPOT.Text = "Waiting....."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ButtonDisconnect)
        Me.GroupBox1.Controls.Add(Me.PictureBoxConnectionInd)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPort)
        Me.GroupBox1.Controls.Add(Me.ButtonScanport)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(370, 94)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(100, 32)
        Me.ButtonDisconnect.TabIndex = 4
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'PictureBoxConnectionInd
        '
        Me.PictureBoxConnectionInd.Image = CType(resources.GetObject("PictureBoxConnectionInd.Image"), System.Drawing.Image)
        Me.PictureBoxConnectionInd.Location = New System.Drawing.Point(386, 0)
        Me.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd"
        Me.PictureBoxConnectionInd.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxConnectionInd.TabIndex = 2
        Me.PictureBoxConnectionInd.TabStop = False
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(18, 94)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(116, 32)
        Me.ButtonConnect.TabIndex = 3
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(208, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(148, 20)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.Text = "Status : Disconnect"
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200" & Global.Microsoft.VisualBasic.ChrW(9), "2400", "4800", "9600", "19200", "38400", "57600", "115200", ""})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(350, 55)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxBaudRate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baud Rate:"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(142, 55)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(106, 28)
        Me.ComboBoxPort.TabIndex = 1
        '
        'ButtonScanport
        '
        Me.ButtonScanport.Location = New System.Drawing.Point(18, 52)
        Me.ButtonScanport.Name = "ButtonScanport"
        Me.ButtonScanport.Size = New System.Drawing.Size(116, 31)
        Me.ButtonScanport.TabIndex = 0
        Me.ButtonScanport.Text = "ScanPort"
        Me.ButtonScanport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelC8)
        Me.GroupBox2.Controls.Add(Me.LabelC7)
        Me.GroupBox2.Controls.Add(Me.LabelC6)
        Me.GroupBox2.Controls.Add(Me.LabelC5)
        Me.GroupBox2.Controls.Add(Me.LabelC4)
        Me.GroupBox2.Controls.Add(Me.LabelPOT)
        Me.GroupBox2.Controls.Add(Me.LabelLDR2)
        Me.GroupBox2.Controls.Add(Me.LabelLDR1)
        Me.GroupBox2.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 504)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 280)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incoming Data(Time/Second)"
        '
        'LabelC8
        '
        Me.LabelC8.AutoSize = True
        Me.LabelC8.Location = New System.Drawing.Point(0, 259)
        Me.LabelC8.Name = "LabelC8"
        Me.LabelC8.Size = New System.Drawing.Size(94, 17)
        Me.LabelC8.TabIndex = 7
        Me.LabelC8.Text = "Waiting....."
        '
        'LabelC7
        '
        Me.LabelC7.AutoSize = True
        Me.LabelC7.Location = New System.Drawing.Point(0, 230)
        Me.LabelC7.Name = "LabelC7"
        Me.LabelC7.Size = New System.Drawing.Size(94, 17)
        Me.LabelC7.TabIndex = 6
        Me.LabelC7.Text = "Waiting....."
        '
        'LabelC6
        '
        Me.LabelC6.AutoSize = True
        Me.LabelC6.Location = New System.Drawing.Point(0, 195)
        Me.LabelC6.Name = "LabelC6"
        Me.LabelC6.Size = New System.Drawing.Size(94, 17)
        Me.LabelC6.TabIndex = 5
        Me.LabelC6.Text = "Waiting....."
        '
        'LabelC5
        '
        Me.LabelC5.AutoSize = True
        Me.LabelC5.Location = New System.Drawing.Point(0, 164)
        Me.LabelC5.Name = "LabelC5"
        Me.LabelC5.Size = New System.Drawing.Size(94, 17)
        Me.LabelC5.TabIndex = 4
        Me.LabelC5.Text = "Waiting....."
        '
        'LabelC4
        '
        Me.LabelC4.AutoSize = True
        Me.LabelC4.Location = New System.Drawing.Point(0, 131)
        Me.LabelC4.Name = "LabelC4"
        Me.LabelC4.Size = New System.Drawing.Size(94, 17)
        Me.LabelC4.TabIndex = 3
        Me.LabelC4.Text = "Waiting....."
        '
        'LabelLDR2
        '
        Me.LabelLDR2.AutoSize = True
        Me.LabelLDR2.Location = New System.Drawing.Point(-3, 70)
        Me.LabelLDR2.Name = "LabelLDR2"
        Me.LabelLDR2.Size = New System.Drawing.Size(94, 17)
        Me.LabelLDR2.TabIndex = 1
        Me.LabelLDR2.Text = "Waiting....."
        '
        'LabelLDR1
        '
        Me.LabelLDR1.AutoEllipsis = True
        Me.LabelLDR1.AutoSize = True
        Me.LabelLDR1.Location = New System.Drawing.Point(-3, 41)
        Me.LabelLDR1.Name = "LabelLDR1"
        Me.LabelLDR1.Size = New System.Drawing.Size(90, 17)
        Me.LabelLDR1.TabIndex = 0
        Me.LabelLDR1.Text = "Waiting...."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxRecordInd)
        Me.GroupBox3.Controls.Add(Me.Recording)
        Me.GroupBox3.Controls.Add(Me.ButtonClear)
        Me.GroupBox3.Controls.Add(Me.ButtonStopRecording)
        Me.GroupBox3.Controls.Add(Me.ButtonStartRecording)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 149)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Image = CType(resources.GetObject("PictureBoxRecordInd.Image"), System.Drawing.Image)
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(296, 8)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(14, 12)
        Me.PictureBoxRecordInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxRecordInd.TabIndex = 6
        Me.PictureBoxRecordInd.TabStop = False
        '
        'Recording
        '
        Me.Recording.AutoSize = True
        Me.Recording.Location = New System.Drawing.Point(208, 9)
        Me.Recording.Name = "Recording"
        Me.Recording.Size = New System.Drawing.Size(82, 20)
        Me.Recording.TabIndex = 5
        Me.Recording.Text = "Recording"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(18, 100)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(316, 43)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear Data Grid View and Graph"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.Location = New System.Drawing.Point(198, 45)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(147, 34)
        Me.ButtonStopRecording.TabIndex = 5
        Me.ButtonStopRecording.Text = "Stop Recording"
        Me.ButtonStopRecording.UseVisualStyleBackColor = True
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.Location = New System.Drawing.Point(9, 45)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(140, 34)
        Me.ButtonStartRecording.TabIndex = 5
        Me.ButtonStartRecording.Text = "Start Recording"
        Me.ButtonStartRecording.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.ProgressBarProcess)
        Me.GroupBox5.Controls.Add(Me.ButtonSaveToExcel)
        Me.GroupBox5.Location = New System.Drawing.Point(403, 190)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(139, 142)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Export"
        '
        'ProgressBarProcess
        '
        Me.ProgressBarProcess.Location = New System.Drawing.Point(8, 92)
        Me.ProgressBarProcess.Maximum = 10
        Me.ProgressBarProcess.Name = "ProgressBarProcess"
        Me.ProgressBarProcess.Size = New System.Drawing.Size(123, 23)
        Me.ProgressBarProcess.TabIndex = 7
        '
        'ButtonSaveToExcel
        '
        Me.ButtonSaveToExcel.Location = New System.Drawing.Point(8, 38)
        Me.ButtonSaveToExcel.Name = "ButtonSaveToExcel"
        Me.ButtonSaveToExcel.Size = New System.Drawing.Size(123, 77)
        Me.ButtonSaveToExcel.TabIndex = 0
        Me.ButtonSaveToExcel.Text = "Save To Excel"
        Me.ButtonSaveToExcel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(647, 143)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Grid View (Real-Time/Seconds)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.AU5, Me.AU6, Me.AU7, Me.AU8, Me.AU1, Me.AU2, Me.AU3, Me.AU4, Me.TIME, Me.DATE_})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(9, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(632, 162)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.FillWeight = 68.18182!
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 8
        Me.No.Name = "No"
        '
        'AU5
        '
        Me.AU5.HeaderText = "AU5"
        Me.AU5.MinimumWidth = 8
        Me.AU5.Name = "AU5"
        '
        'AU6
        '
        Me.AU6.HeaderText = "AU6"
        Me.AU6.MinimumWidth = 8
        Me.AU6.Name = "AU6"
        '
        'AU7
        '
        Me.AU7.HeaderText = "AU7"
        Me.AU7.MinimumWidth = 8
        Me.AU7.Name = "AU7"
        '
        'AU8
        '
        Me.AU8.HeaderText = "Column1"
        Me.AU8.MinimumWidth = 8
        Me.AU8.Name = "AU8"
        '
        'AU1
        '
        Me.AU1.FillWeight = 106.3636!
        Me.AU1.HeaderText = "AU1"
        Me.AU1.MinimumWidth = 8
        Me.AU1.Name = "AU1"
        '
        'AU2
        '
        Me.AU2.FillWeight = 106.3636!
        Me.AU2.HeaderText = "AU2"
        Me.AU2.MinimumWidth = 8
        Me.AU2.Name = "AU2"
        '
        'AU3
        '
        Me.AU3.FillWeight = 106.3636!
        Me.AU3.HeaderText = "AU3"
        Me.AU3.MinimumWidth = 8
        Me.AU3.Name = "AU3"
        '
        'AU4
        '
        Me.AU4.HeaderText = "AU4"
        Me.AU4.MinimumWidth = 8
        Me.AU4.Name = "AU4"
        '
        'TIME
        '
        Me.TIME.FillWeight = 106.3636!
        Me.TIME.HeaderText = "TIME"
        Me.TIME.MinimumWidth = 8
        Me.TIME.Name = "TIME"
        '
        'DATE_
        '
        Me.DATE_.FillWeight = 106.3636!
        Me.DATE_.HeaderText = "DATE"
        Me.DATE_.MinimumWidth = 8
        Me.DATE_.Name = "DATE_"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Chart1)
        Me.GroupBox6.Controls.Add(Me.Labelrtu)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox6.Location = New System.Drawing.Point(665, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox6.Size = New System.Drawing.Size(919, 673)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TECAN IN  LINE UV METER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Live Interval"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.MinorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX2.MajorGrid.Interval = 0R
        ChartArea1.AxisX2.MajorGrid.IntervalOffset = 0R
        ChartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.Interval = 0R
        ChartArea1.AxisX2.MajorTickMark.IntervalOffset = 0R
        ChartArea1.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.Title = "ABSORBANCE (mAU)"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 22)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Me.Chart1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.CustomProperties = "IsXAxisQuantitative=False"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series1.Legend = "Legend1"
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond
        Series1.Name = "AU 1"
        DataPoint1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataPoint1.IsValueShownAsLabel = True
        DataPoint1.Label = "#AVG{D}"
        Series1.Points.Add(DataPoint1)
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No
        Series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "AU 2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "AU 3"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Legend = "Legend1"
        Series4.Name = "AU 4"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series5.Legend = "Legend1"
        Series5.Name = "AU 5"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.Legend = "Legend1"
        Series6.Name = "AU 6"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Legend = "Legend1"
        Series7.Name = "AU 7"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series8.Legend = "Legend1"
        Series8.Name = "AU 8"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(635, 604)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Me.Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault
        '
        'Labelrtu
        '
        Me.Labelrtu.AutoSize = True
        Me.Labelrtu.Location = New System.Drawing.Point(647, 282)
        Me.Labelrtu.Name = "Labelrtu"
        Me.Labelrtu.Size = New System.Drawing.Size(214, 20)
        Me.Labelrtu.TabIndex = 8
        Me.Labelrtu.Text = "REAL-TIME (RT) UPDATES:"
        Me.Labelrtu.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CheckBox8)
        Me.GroupBox7.Controls.Add(Me.CheckBox7)
        Me.GroupBox7.Controls.Add(Me.CheckBox6)
        Me.GroupBox7.Controls.Add(Me.CheckBox5)
        Me.GroupBox7.Controls.Add(Me.CheckBox4)
        Me.GroupBox7.Controls.Add(Me.CheckBox3)
        Me.GroupBox7.Controls.Add(Me.CheckBox2)
        Me.GroupBox7.Controls.Add(Me.CheckBox1)
        Me.GroupBox7.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(318, 504)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(202, 273)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Chanel select"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(26, 245)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(104, 21)
        Me.CheckBox8.TabIndex = 19
        Me.CheckBox8.Text = "AU Ch.8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(26, 214)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(104, 21)
        Me.CheckBox7.TabIndex = 18
        Me.CheckBox7.Text = "AU Ch.7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(26, 183)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(104, 21)
        Me.CheckBox6.TabIndex = 17
        Me.CheckBox6.Text = "AU Ch.6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(26, 152)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(104, 21)
        Me.CheckBox5.TabIndex = 16
        Me.CheckBox5.Text = "AU Ch.5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(26, 121)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(106, 21)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "AU CH.4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(26, 90)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(106, 21)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "AU CH.3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(26, 55)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(106, 21)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "AU CH.2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(26, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 21)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "AU CH.1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 1000
        '
        'TimerDataLogRecord
        '
        Me.TimerDataLogRecord.Interval = 1000
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1596, 695)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Arduino Data Logger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxConnectionInd As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelLDR2 As Label
    Friend WithEvents LabelLDR1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents Recording As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonStopRecording As Button
    Friend WithEvents ButtonStartRecording As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ProgressBarProcess As ProgressBar
    Friend WithEvents ButtonSaveToExcel As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TimerDataLogRecord As Timer
    Friend WithEvents LabelPOT As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Labelrtu As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LabelC4 As Label
    Friend WithEvents LabelC8 As Label
    Friend WithEvents LabelC7 As Label
    Friend WithEvents LabelC6 As Label
    Friend WithEvents LabelC5 As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents AU5 As DataGridViewTextBoxColumn
    Friend WithEvents AU6 As DataGridViewTextBoxColumn
    Friend WithEvents AU7 As DataGridViewTextBoxColumn
    Friend WithEvents AU8 As DataGridViewTextBoxColumn
    Friend WithEvents AU1 As DataGridViewTextBoxColumn
    Friend WithEvents AU2 As DataGridViewTextBoxColumn
    Friend WithEvents AU3 As DataGridViewTextBoxColumn
    Friend WithEvents AU4 As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
