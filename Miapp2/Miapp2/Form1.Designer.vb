<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.rsocial = New System.Windows.Forms.TextBox()
        Me.fax = New System.Windows.Forms.TextBox()
        Me.ruc = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.web = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.busqueda = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(207, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento a la tabla proveedor"
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt.Location = New System.Drawing.Point(41, 66)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(59, 20)
        Me.txt.TabIndex = 1
        Me.txt.Text = "Codigo"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label3.Location = New System.Drawing.Point(41, 97)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(103, 20)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Razon Social"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(45, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "RUC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(41, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(41, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(41, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(45, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fax"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(567, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nuevo Registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(567, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Guardar Registro "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(567, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modificar Registro"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 328)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(760, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(150, 66)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(197, 20)
        Me.codigo.TabIndex = 4
        '
        'rsocial
        '
        Me.rsocial.Location = New System.Drawing.Point(150, 97)
        Me.rsocial.Name = "rsocial"
        Me.rsocial.Size = New System.Drawing.Size(197, 20)
        Me.rsocial.TabIndex = 4
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(150, 251)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(197, 20)
        Me.fax.TabIndex = 4
        '
        'ruc
        '
        Me.ruc.Location = New System.Drawing.Point(150, 128)
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(197, 20)
        Me.ruc.TabIndex = 4
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(150, 225)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(197, 20)
        Me.telefono.TabIndex = 4
        '
        'web
        '
        Me.web.Location = New System.Drawing.Point(150, 285)
        Me.web.Name = "web"
        Me.web.Size = New System.Drawing.Size(197, 20)
        Me.web.TabIndex = 4
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(150, 162)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(197, 20)
        Me.direccion.TabIndex = 4
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(150, 194)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(197, 20)
        Me.email.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(41, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Web"
        '
        'busqueda
        '
        Me.busqueda.Location = New System.Drawing.Point(567, 194)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(157, 20)
        Me.busqueda.TabIndex = 5
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(608, 234)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 6
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 512)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.busqueda)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.web)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.fax)
        Me.Controls.Add(Me.rsocial)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents codigo As TextBox
    Friend WithEvents rsocial As TextBox
    Friend WithEvents fax As TextBox
    Friend WithEvents ruc As TextBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents web As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents busqueda As TextBox
    Friend WithEvents Buscar As Button
End Class
