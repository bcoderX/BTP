using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTP
{
    public partial class GridDialog : Form
    {
        public GridDialog()
        {
            InitializeComponent();
        }

        private void gridTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (gridTreeView.SelectedNode.Name)
            {
                case "cartesianGrid":
                    if(gridTable.Controls.Count == 2)
                    {
                        gridTable.Controls.RemoveAt(1);
                    }
                    gridTable.Controls.Add(emptyCartesianGridPanel, 1, 0);
                    break;
                case "gcar":
                    if (gridTable.Controls.Count == 2)
                    {
                        gridTable.Controls.RemoveAt(1);
                    }
                    gridTable.Controls.Add(gcarPanel, 1, 0);
                    break;
                case "gcyl1":
                    if (gridTable.Controls.Count == 2)
                    {
                        gridTable.Controls.RemoveAt(1);
                    }
                    gridTable.Controls.Add(gcyl1Panel, 1, 0);
                    break;
                case "ga1":
                    if (gridTable.Controls.Count == 2)
                    {
                        gridTable.Controls.RemoveAt(1);
                    }
                    gridTable.Controls.Add(ga1Panel, 1, 0);
                    break;
                default:
                    break;
            }
        }
    }
}
