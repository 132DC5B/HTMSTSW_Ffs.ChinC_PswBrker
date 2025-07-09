<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        Button1 = New ToolStripMenuItem()
        forceStopMenuItem1 = New ToolStripMenuItem()
        applicationMenuItem = New ToolStripMenuItem()
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        RichTextBox3 = New RichTextBox()
        RichTextBox6 = New RichTextBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        StatusStrip1 = New StatusStrip()
        ProgressBar1 = New ToolStripProgressBar()
        RichTextBox4 = New ToolStripStatusLabel()
        RichTextBox5 = New ToolStripStatusLabel()
        MenuStrip1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {Button1, forceStopMenuItem1, applicationMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(3, 1, 0, 1)
        MenuStrip1.Size = New Size(599, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Button1
        ' 
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 22)
        Button1.Text = "Start"
        ' 
        ' forceStopMenuItem1
        ' 
        forceStopMenuItem1.Enabled = False
        forceStopMenuItem1.ForeColor = Color.Red
        forceStopMenuItem1.Name = "forceStopMenuItem1"
        forceStopMenuItem1.Size = New Size(71, 22)
        forceStopMenuItem1.Text = "Terminate"
        ' 
        ' applicationMenuItem
        ' 
        applicationMenuItem.Alignment = ToolStripItemAlignment.Right
        applicationMenuItem.BackColor = SystemColors.Control
        applicationMenuItem.ForeColor = Color.Red
        applicationMenuItem.Name = "applicationMenuItem"
        applicationMenuItem.Size = New Size(70, 22)
        applicationMenuItem.Text = "Force Exit"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TextBox4, 0, 2)
        TableLayoutPanel1.Controls.Add(TextBox3, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel1.Controls.Add(RichTextBox6, 0, 3)
        TableLayoutPanel1.Location = New Point(6, 37)
        TableLayoutPanel1.Margin = New Padding(2, 1, 2, 1)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        TableLayoutPanel1.Size = New Size(302, 231)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Control
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(2, 115)
        TextBox4.Margin = New Padding(2, 1, 2, 1)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(206, 22)
        TextBox4.TabIndex = 3
        TextBox4.Text = "Debug"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Control
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(2, 1)
        TextBox3.Margin = New Padding(2, 1, 2, 1)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(206, 22)
        TextBox3.TabIndex = 2
        TextBox3.Text = "Account Address"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 31F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 164F))
        TableLayoutPanel2.Controls.Add(RichTextBox1, 0, 0)
        TableLayoutPanel2.Controls.Add(RichTextBox2, 1, 0)
        TableLayoutPanel2.Controls.Add(RichTextBox3, 2, 0)
        TableLayoutPanel2.Location = New Point(2, 29)
        TableLayoutPanel2.Margin = New Padding(2, 1, 2, 1)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 25F))
        TableLayoutPanel2.Size = New Size(298, 25)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Italic)
        RichTextBox1.Location = New Point(2, 1)
        RichTextBox1.Margin = New Padding(2, 1, 2, 1)
        RichTextBox1.Multiline = False
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(99, 23)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Italic)
        RichTextBox2.Location = New Point(105, 1)
        RichTextBox2.Margin = New Padding(2, 1, 2, 1)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox2.Size = New Size(27, 23)
        RichTextBox2.TabIndex = 1
        RichTextBox2.Text = "@"
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RichTextBox3.Location = New Point(136, 1)
        RichTextBox3.Margin = New Padding(2, 1, 2, 1)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.ReadOnly = True
        RichTextBox3.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox3.Size = New Size(160, 23)
        RichTextBox3.TabIndex = 2
        RichTextBox3.Text = "heungto.net"
        ' 
        ' RichTextBox6
        ' 
        RichTextBox6.BackColor = SystemColors.ControlText
        RichTextBox6.Font = New Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox6.ForeColor = Color.FromArgb(CByte(22), CByte(198), CByte(12))
        RichTextBox6.Location = New Point(2, 143)
        RichTextBox6.Margin = New Padding(2, 1, 2, 1)
        RichTextBox6.Name = "RichTextBox6"
        RichTextBox6.ReadOnly = True
        RichTextBox6.Size = New Size(298, 87)
        RichTextBox6.TabIndex = 4
        RichTextBox6.Text = ""
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(TextBox2, 0, 2)
        TableLayoutPanel3.Controls.Add(TextBox1, 0, 0)
        TableLayoutPanel3.Controls.Add(DateTimePicker1, 0, 1)
        TableLayoutPanel3.Controls.Add(DateTimePicker2, 0, 3)
        TableLayoutPanel3.Location = New Point(324, 37)
        TableLayoutPanel3.Margin = New Padding(2, 1, 2, 1)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 4
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        TableLayoutPanel3.Size = New Size(268, 232)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Control
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(2, 117)
        TextBox2.Margin = New Padding(2, 1, 2, 1)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(206, 22)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Until"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(2, 1)
        TextBox1.Margin = New Padding(2, 1, 2, 1)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(206, 22)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Start From"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(2, 30)
        DateTimePicker1.Margin = New Padding(2, 1, 2, 1)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(264, 29)
        DateTimePicker1.TabIndex = 1
        DateTimePicker1.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Location = New Point(2, 146)
        DateTimePicker2.Margin = New Padding(2, 1, 2, 1)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(264, 29)
        DateTimePicker2.TabIndex = 3
        DateTimePicker2.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(32, 32)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ProgressBar1, RichTextBox4, RichTextBox5})
        StatusStrip1.Location = New Point(0, 284)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 8, 0)
        StatusStrip1.Size = New Size(599, 22)
        StatusStrip1.SizingGrip = False
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Maximum = 365
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(404, 16)
        ProgressBar1.Step = 1
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.RightToLeft = RightToLeft.Yes
        RichTextBox4.Size = New Size(0, 17)
        ' 
        ' RichTextBox5
        ' 
        RichTextBox5.Name = "RichTextBox5"
        RichTextBox5.RightToLeft = RightToLeft.Yes
        RichTextBox5.Size = New Size(0, 17)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 306)
        Controls.Add(StatusStrip1)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2, 1, 2, 1)
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        Text = "Built--9 July 2025 (Visual Basic .NET)"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents applicationMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As ToolStripMenuItem
    Friend WithEvents forceStopMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents RichTextBox4 As ToolStripStatusLabel
    Friend WithEvents RichTextBox5 As ToolStripStatusLabel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RichTextBox6 As RichTextBox

End Class
