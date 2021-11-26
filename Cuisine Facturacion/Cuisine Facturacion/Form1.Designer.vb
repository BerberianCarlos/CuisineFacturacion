<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecibo
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
        Me.CBFdp = New System.Windows.Forms.ComboBox()
        Me.CBprovedor = New System.Windows.Forms.ComboBox()
        Me.ListPedidos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtbTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBFdp
        '
        Me.CBFdp.FormattingEnabled = True
        Me.CBFdp.Location = New System.Drawing.Point(322, 25)
        Me.CBFdp.Name = "CBFdp"
        Me.CBFdp.Size = New System.Drawing.Size(168, 21)
        Me.CBFdp.TabIndex = 0
        '
        'CBprovedor
        '
        Me.CBprovedor.FormattingEnabled = True
        Me.CBprovedor.Location = New System.Drawing.Point(26, 156)
        Me.CBprovedor.Name = "CBprovedor"
        Me.CBprovedor.Size = New System.Drawing.Size(234, 21)
        Me.CBprovedor.TabIndex = 2
        '
        'ListPedidos
        '
        Me.ListPedidos.FormattingEnabled = True
        Me.ListPedidos.Location = New System.Drawing.Point(26, 25)
        Me.ListPedidos.Name = "ListPedidos"
        Me.ListPedidos.Size = New System.Drawing.Size(234, 95)
        Me.ListPedidos.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total"
        '
        'TxtbTotal
        '
        Me.TxtbTotal.Location = New System.Drawing.Point(366, 111)
        Me.TxtbTotal.Name = "TxtbTotal"
        Me.TxtbTotal.ReadOnly = True
        Me.TxtbTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtbTotal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pedidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Forma de pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Provedor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Generar Recibo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 219)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtbTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListPedidos)
        Me.Controls.Add(Me.CBprovedor)
        Me.Controls.Add(Me.CBFdp)
        Me.Name = "FormRecibo"
        Me.Text = "Generar Recibo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBFdp As System.Windows.Forms.ComboBox
    Friend WithEvents CBprovedor As System.Windows.Forms.ComboBox
    Friend WithEvents ListPedidos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
