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
        Me.Rno = New System.Windows.Forms.Label()
        Me.TextBoxRno = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.GridViewReader = New System.Windows.Forms.DataGridView()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelMp = New System.Windows.Forms.Label()
        CType(Me.GridViewReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rno
        '
        Me.Rno.AutoSize = True
        Me.Rno.Location = New System.Drawing.Point(263, 74)
        Me.Rno.Name = "Rno"
        Me.Rno.Size = New System.Drawing.Size(148, 32)
        Me.Rno.TabIndex = 0
        Me.Rno.Text = "Roll Number"
        '
        'TextBoxRno
        '
        Me.TextBoxRno.Location = New System.Drawing.Point(442, 67)
        Me.TextBoxRno.Name = "TextBoxRno"
        Me.TextBoxRno.Size = New System.Drawing.Size(200, 39)
        Me.TextBoxRno.TabIndex = 1
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(442, 139)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(200, 39)
        Me.TextBoxName.TabIndex = 3
        '
        'TextName
        '
        Me.TextName.AutoSize = True
        Me.TextName.Location = New System.Drawing.Point(263, 146)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(78, 32)
        Me.TextName.TabIndex = 2
        Me.TextName.Text = "Name"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Image = Global.Demo1.My.Resources.Resources.refresh32
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(745, 266)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(139, 46)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Image = Global.Demo1.My.Resources.Resources.save32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ButtonSave.Location = New System.Drawing.Point(110, 266)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(107, 46)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Image = Global.Demo1.My.Resources.Resources.delete32
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(528, 266)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(132, 46)
        Me.ButtonDelete.TabIndex = 6
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Image = Global.Demo1.My.Resources.Resources.update32
        Me.ButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ButtonUpdate.Location = New System.Drawing.Point(323, 266)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(133, 46)
        Me.ButtonUpdate.TabIndex = 7
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'GridViewReader
        '
        Me.GridViewReader.AllowUserToAddRows = False
        Me.GridViewReader.AllowUserToDeleteRows = False
        Me.GridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewReader.Location = New System.Drawing.Point(328, 504)
        Me.GridViewReader.Name = "GridViewReader"
        Me.GridViewReader.ReadOnly = True
        Me.GridViewReader.RowHeadersWidth = 82
        Me.GridViewReader.RowTemplate.Height = 41
        Me.GridViewReader.Size = New System.Drawing.Size(1021, 490)
        Me.GridViewReader.TabIndex = 8
        '
        'ButtonClear
        '
        Me.ButtonClear.Image = Global.Demo1.My.Resources.Resources.clear32
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ButtonClear.Location = New System.Drawing.Point(745, 98)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(120, 46)
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(643, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Crud Operaion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rno)
        Me.GroupBox1.Controls.Add(Me.TextBoxRno)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.TextName)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1021, 366)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crud Operation"
        '
        'LabelMp
        '
        Me.LabelMp.AutoSize = True
        Me.LabelMp.Font = New System.Drawing.Font("Copperplate Gothic Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMp.Image = Global.Demo1.My.Resources.Resources.red_heart_48
        Me.LabelMp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelMp.Location = New System.Drawing.Point(494, 1089)
        Me.LabelMp.Name = "LabelMp"
        Me.LabelMp.Size = New System.Drawing.Size(650, 46)
        Me.LabelMp.TabIndex = 12
        Me.LabelMp.Text = "Created by Mpiyush3510     "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 1259)
        Me.Controls.Add(Me.LabelMp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridViewReader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridViewReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rno As Label
    Friend WithEvents TextBoxRno As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextName As Label
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents GridViewReader As DataGridView
    Friend WithEvents ButtonClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelMp As Label
End Class
