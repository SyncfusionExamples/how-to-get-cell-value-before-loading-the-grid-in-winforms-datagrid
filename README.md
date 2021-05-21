# How to get cell value before loading the grid in WinForms DataGrid (SfDataGrid)?

## About the sample

This example illustrates how to get cell value before loading the grid in WinForms DataGrid.

[WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid) allows you to retrieve the cell values before the DataGrid is loaded by using SfDataGrid.View.Records collection. 

```C#

public Form1()
{
    InitializeComponent();
    sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;

    if (this.sfDataGrid1.RowCount > 0)
        sfDataGrid1.MoveToCurrentCell(new RowColumnIndex(2, 0));

    var record = this.sfDataGrid1.View.Records[this.sfDataGrid1.TableControl.ResolveToRecordIndex(this.sfDataGrid1.CurrentCell.RowIndex)];
    var currentCellValue = this.sfDataGrid1.View.GetPropertyAccessProvider().GetValue((record as RecordEntry).Data, "OrderID");

    MessageBox.Show("CurrentCell value = " + currentCellValue.ToString());
}


```

## Requirements to run the demo 

Visual Studio 2015 and above versions.