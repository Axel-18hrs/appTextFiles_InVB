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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnOpen = New Button()
        btnDelete = New Button()
        Button2 = New Button()
        Label5 = New Label()
        cbDepartament = New ComboBox()
        txtAge = New TextBox()
        Label4 = New Label()
        txtSecondName = New TextBox()
        Label3 = New Label()
        dgvEmployeeTable = New DataGridView()
        btnSave = New Button()
        txtName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnUpdateSql = New Button()
        btnDeleteSql = New Button()
        btnInsert = New Button()
        txtEmailSql = New TextBox()
        Label7 = New Label()
        txtPhoneSql = New TextBox()
        Label8 = New Label()
        txtNameSql = New TextBox()
        Label9 = New Label()
        dgvContactos = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        NName = New DataGridViewTextBoxColumn()
        PPhone = New DataGridViewTextBoxColumn()
        EEmail = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        TabPage3 = New TabPage()
        Button5 = New Button()
        Button6 = New Button()
        Label14 = New Label()
        cbDepartamentDA = New ComboBox()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        txtNameDA = New TextBox()
        Label11 = New Label()
        txtID = New TextBox()
        Label12 = New Label()
        dgvEmpTabl = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Label13 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvEmployeeTable, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvContactos, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgvEmpTabl, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(-3, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(989, 447)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.DarkGray
        TabPage1.Controls.Add(btnOpen)
        TabPage1.Controls.Add(btnDelete)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(cbDepartament)
        TabPage1.Controls.Add(txtAge)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txtSecondName)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(dgvEmployeeTable)
        TabPage1.Controls.Add(btnSave)
        TabPage1.Controls.Add(txtName)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(981, 414)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Sequential Operations"
        ' 
        ' btnOpen
        ' 
        btnOpen.Location = New Point(35, 329)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(94, 29)
        btnOpen.TabIndex = 13
        btnOpen.Text = "Open"
        btnOpen.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(710, 353)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(710, 318)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(711, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 10
        Label5.Text = "Departament"
        ' 
        ' cbDepartament
        ' 
        cbDepartament.FormattingEnabled = True
        cbDepartament.Items.AddRange(New Object() {"Office", "Library", "Servers", "Administration"})
        cbDepartament.Location = New Point(711, 237)
        cbDepartament.Name = "cbDepartament"
        cbDepartament.Size = New Size(168, 28)
        cbDepartament.TabIndex = 9
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(710, 178)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(169, 27)
        txtAge.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(710, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 7
        Label4.Text = "Age"
        ' 
        ' txtSecondName
        ' 
        txtSecondName.Location = New Point(710, 118)
        txtSecondName.Name = "txtSecondName"
        txtSecondName.Size = New Size(169, 27)
        txtSecondName.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(710, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 20)
        Label3.TabIndex = 5
        Label3.Text = "Second Name"
        ' 
        ' dgvEmployeeTable
        ' 
        dgvEmployeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeTable.Location = New Point(35, 104)
        dgvEmployeeTable.Name = "dgvEmployeeTable"
        dgvEmployeeTable.RowHeadersWidth = 51
        dgvEmployeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployeeTable.Size = New Size(520, 204)
        dgvEmployeeTable.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(710, 283)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(710, 55)
        txtName.Name = "txtName"
        txtName.Size = New Size(169, 27)
        txtName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(710, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 50)
        Label1.TabIndex = 0
        Label1.Text = "Employee Regstration"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.DarkGray
        TabPage2.Controls.Add(btnUpdateSql)
        TabPage2.Controls.Add(btnDeleteSql)
        TabPage2.Controls.Add(btnInsert)
        TabPage2.Controls.Add(txtEmailSql)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(txtPhoneSql)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(txtNameSql)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(dgvContactos)
        TabPage2.Controls.Add(Label6)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(981, 414)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Sequential Indexed Operations"
        ' 
        ' btnUpdateSql
        ' 
        btnUpdateSql.Location = New Point(819, 306)
        btnUpdateSql.Name = "btnUpdateSql"
        btnUpdateSql.Size = New Size(94, 38)
        btnUpdateSql.TabIndex = 17
        btnUpdateSql.Text = "Update"
        btnUpdateSql.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteSql
        ' 
        btnDeleteSql.Location = New Point(700, 306)
        btnDeleteSql.Name = "btnDeleteSql"
        btnDeleteSql.Size = New Size(103, 38)
        btnDeleteSql.TabIndex = 16
        btnDeleteSql.Text = "Delete"
        btnDeleteSql.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(700, 256)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(213, 44)
        btnInsert.TabIndex = 15
        btnInsert.Text = "Add"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' txtEmailSql
        ' 
        txtEmailSql.Location = New Point(700, 213)
        txtEmailSql.Name = "txtEmailSql"
        txtEmailSql.Size = New Size(213, 27)
        txtEmailSql.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(700, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 13
        Label7.Text = "Email"
        ' 
        ' txtPhoneSql
        ' 
        txtPhoneSql.Location = New Point(700, 153)
        txtPhoneSql.Name = "txtPhoneSql"
        txtPhoneSql.Size = New Size(213, 27)
        txtPhoneSql.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(700, 130)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 20)
        Label8.TabIndex = 11
        Label8.Text = "Phone"
        ' 
        ' txtNameSql
        ' 
        txtNameSql.Location = New Point(700, 90)
        txtNameSql.Name = "txtNameSql"
        txtNameSql.Size = New Size(213, 27)
        txtNameSql.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(700, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 20)
        Label9.TabIndex = 9
        Label9.Text = "Name"
        ' 
        ' dgvContactos
        ' 
        dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvContactos.Columns.AddRange(New DataGridViewColumn() {ID, NName, PPhone, EEmail})
        dgvContactos.Location = New Point(39, 117)
        dgvContactos.Name = "dgvContactos"
        dgvContactos.RowHeadersWidth = 51
        dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvContactos.Size = New Size(553, 204)
        dgvContactos.TabIndex = 6
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.MinimumWidth = 6
        ID.Name = "ID"
        ID.Width = 125
        ' 
        ' NName
        ' 
        NName.HeaderText = "Name"
        NName.MinimumWidth = 6
        NName.Name = "NName"
        NName.Width = 125
        ' 
        ' PPhone
        ' 
        PPhone.HeaderText = "Phone"
        PPhone.MinimumWidth = 6
        PPhone.Name = "PPhone"
        PPhone.Width = 125
        ' 
        ' EEmail
        ' 
        EEmail.HeaderText = "Email"
        EEmail.MinimumWidth = 6
        EEmail.Name = "EEmail"
        EEmail.Width = 125
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(31, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 50)
        Label6.TabIndex = 5
        Label6.Text = "Contacts"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Gray
        TabPage3.Controls.Add(Button5)
        TabPage3.Controls.Add(Button6)
        TabPage3.Controls.Add(Label14)
        TabPage3.Controls.Add(cbDepartamentDA)
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(Button3)
        TabPage3.Controls.Add(Button4)
        TabPage3.Controls.Add(txtNameDA)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(txtID)
        TabPage3.Controls.Add(Label12)
        TabPage3.Controls.Add(dgvEmpTabl)
        TabPage3.Controls.Add(Label13)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(981, 414)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Direct Operations"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(175, 338)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 38)
        Button5.TabIndex = 32
        Button5.Text = "Update"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(56, 338)
        Button6.Name = "Button6"
        Button6.Size = New Size(103, 38)
        Button6.TabIndex = 31
        Button6.Text = "Open"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(718, 201)
        Label14.Name = "Label14"
        Label14.Size = New Size(97, 20)
        Label14.TabIndex = 30
        Label14.Text = "Departament"
        ' 
        ' cbDepartamentDA
        ' 
        cbDepartamentDA.FormattingEnabled = True
        cbDepartamentDA.Items.AddRange(New Object() {"Office", "Library", "Servers", "Administration"})
        cbDepartamentDA.Location = New Point(718, 224)
        cbDepartamentDA.Name = "cbDepartamentDA"
        cbDepartamentDA.Size = New Size(213, 28)
        cbDepartamentDA.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(837, 317)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 38)
        Button1.TabIndex = 28
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(718, 317)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 38)
        Button3.TabIndex = 27
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(718, 267)
        Button4.Name = "Button4"
        Button4.Size = New Size(213, 44)
        Button4.TabIndex = 26
        Button4.Text = "Save"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' txtNameDA
        ' 
        txtNameDA.Location = New Point(718, 164)
        txtNameDA.Name = "txtNameDA"
        txtNameDA.Size = New Size(213, 27)
        txtNameDA.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(718, 141)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 20)
        Label11.TabIndex = 22
        Label11.Text = "Name"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(718, 101)
        txtID.Name = "txtID"
        txtID.Size = New Size(213, 27)
        txtID.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(718, 78)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 20)
        Label12.TabIndex = 20
        Label12.Text = "ID"
        ' 
        ' dgvEmpTabl
        ' 
        dgvEmpTabl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmpTabl.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        dgvEmpTabl.Location = New Point(57, 128)
        dgvEmpTabl.Name = "dgvEmpTabl"
        dgvEmpTabl.RowHeadersWidth = 51
        dgvEmpTabl.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmpTabl.Size = New Size(432, 204)
        dgvEmpTabl.TabIndex = 19
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 125
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Name"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 125
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Departament"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.Width = 125
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(49, 59)
        Label13.Name = "Label13"
        Label13.Size = New Size(404, 50)
        Label13.TabIndex = 18
        Label13.Text = "Employee departament"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(985, 447)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvEmployeeTable, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvContactos, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgvEmpTabl, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvEmployeeTable As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvContactos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDepartament As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NName As DataGridViewTextBoxColumn
    Friend WithEvents PPhone As DataGridViewTextBoxColumn
    Friend WithEvents EEmail As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateSql As Button
    Friend WithEvents btnDeleteSql As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtEmailSql As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhoneSql As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNameSql As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtNameDA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvEmpTabl As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbDepartamentDA As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

End Class
