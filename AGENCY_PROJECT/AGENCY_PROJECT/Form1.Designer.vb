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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtlogin = New Button()
        Label1 = New Label()
        txtteacherid = New TextBox()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtlogin)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtteacherid)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(txtusername)
        Panel1.Location = New Point(611, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(389, 515)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(44, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 7
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(44, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 28)
        Label3.TabIndex = 6
        Label3.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(44, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 5
        Label2.Text = "Teacher Id"
        ' 
        ' txtlogin
        ' 
        txtlogin.FlatStyle = FlatStyle.Flat
        txtlogin.Location = New Point(133, 443)
        txtlogin.Name = "txtlogin"
        txtlogin.Size = New Size(133, 48)
        txtlogin.TabIndex = 4
        txtlogin.Text = "Login"
        txtlogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(131, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 50)
        Label1.TabIndex = 3
        Label1.Text = "LOGIN"
        ' 
        ' txtteacherid
        ' 
        txtteacherid.BorderStyle = BorderStyle.FixedSingle
        txtteacherid.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtteacherid.Location = New Point(53, 173)
        txtteacherid.Name = "txtteacherid"
        txtteacherid.Size = New Size(288, 38)
        txtteacherid.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(53, 373)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(288, 38)
        txtpassword.TabIndex = 1
        ' 
        ' txtusername
        ' 
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(53, 273)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(288, 38)
        txtusername.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Gemini_Generated_Image_7c8ca57c8ca57c8c
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1114, 623)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(120, 113)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(350, 381)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonFace
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(166, 445)
        Label5.Name = "Label5"
        Label5.Size = New Size(257, 38)
        Label5.TabIndex = 8
        Label5.Text = "Welcome to Library"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 615)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtteacherid As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label

End Class
