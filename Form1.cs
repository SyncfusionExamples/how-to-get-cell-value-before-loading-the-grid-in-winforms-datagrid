using SfDataGrid_Demo;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using Syncfusion.Data.Extensions;
using Syncfusion.Data;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
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

        #endregion
    }
}
