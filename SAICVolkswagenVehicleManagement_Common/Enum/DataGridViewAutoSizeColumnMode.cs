using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAICVolkswagenVehicleManagement_Common.Enum
{
    // 摘要:
    //     定义用于指定如何调整列宽的值。
    public enum DataGridViewAutoSizeColumnMode
    {
        // 摘要:
        //     列的大小调整行为从 System.Windows.Forms.DataGridView.AutoSizeColumnsMode 属性继承。
        NotSet = 0,
        //
        // 摘要:
        //     列宽不会自动调整。
        None = 1,
        //
        // 摘要:
        //     调整列宽，以适合列标题单元格的内容。
        ColumnHeader = 2,
        //
        // 摘要:
        //     调整列宽，以适合该列中的所有单元格的内容，不包括标题单元格。
        AllCellsExceptHeader = 4,
        //
        // 摘要:
        //     调整列宽，以适合该列中的所有单元格的内容，包括标题单元格。
        AllCells = 6,
        //
        // 摘要:
        //     调整列宽，以适合当前屏幕上显示的行的列中的所有单元格的内容，不包括标题单元格。
        DisplayedCellsExceptHeader = 8,
        //
        // 摘要:
        //     调整列宽，以适合当前屏幕上显示的行的列中的所有单元格的内容，包括标题单元格。
        DisplayedCells = 10,
        //
        // 摘要:
        //     调整列宽，使所有列的宽度正好填充控件的显示区域，只需要水平滚动保证列宽在 System.Windows.Forms.DataGridViewColumn.MinimumWidth
        //     属性值以上。 相对列宽由相对 System.Windows.Forms.DataGridViewColumn.FillWeight 属性值决定。
        Fill = 16,
    }
}
