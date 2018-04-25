<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AllPricesDataSet = New Lab10_KayakRentalPrices.AllPricesDataSet()
        Me.RentalPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalPricesTableAdapter = New Lab10_KayakRentalPrices.AllPricesDataSetTableAdapters.RentalPricesTableAdapter()
        Me.TableAdapterManager = New Lab10_KayakRentalPrices.AllPricesDataSetTableAdapters.TableAdapterManager()
        Me.RentalPricesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AllPricesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalPricesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllPricesDataSet
        '
        Me.AllPricesDataSet.DataSetName = "AllPricesDataSet"
        Me.AllPricesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalPricesBindingSource
        '
        Me.RentalPricesBindingSource.DataMember = "RentalPrices"
        Me.RentalPricesBindingSource.DataSource = Me.AllPricesDataSet
        '
        'RentalPricesTableAdapter
        '
        Me.RentalPricesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Lab10_KayakRentalPrices.AllPricesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentalPricesDataGridView
        '
        Me.RentalPricesDataGridView.AllowUserToAddRows = False
        Me.RentalPricesDataGridView.AllowUserToDeleteRows = False
        Me.RentalPricesDataGridView.AutoGenerateColumns = False
        Me.RentalPricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalPricesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.RentalPricesDataGridView.DataSource = Me.RentalPricesBindingSource
        Me.RentalPricesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentalPricesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.RentalPricesDataGridView.Name = "RentalPricesDataGridView"
        Me.RentalPricesDataGridView.ReadOnly = True
        Me.RentalPricesDataGridView.Size = New System.Drawing.Size(461, 356)
        Me.RentalPricesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Hourly_Rate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hourly Rate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Daily_Rate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Daily Rate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Weekly_Rate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Weekly Rate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 356)
        Me.Controls.Add(Me.RentalPricesDataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AllPricesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalPricesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AllPricesDataSet As AllPricesDataSet
    Friend WithEvents RentalPricesBindingSource As BindingSource
    Friend WithEvents RentalPricesTableAdapter As AllPricesDataSetTableAdapters.RentalPricesTableAdapter
    Friend WithEvents TableAdapterManager As AllPricesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentalPricesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
