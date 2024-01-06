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
    public partial class SectionBaseDialog : Form
    {
        public SectionBaseDialog()
        {
            InitializeComponent();
        }

        private void sectionsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (sectionsTreeView.SelectedNode.Name)
            {
                case "rectangulaire":
                case "enT":
                case "circulaire":
                case "semellesRectangulaires":
                case "semailesTrapezoidales":
                case "ouverturesRectangulaires":
                case "ouverturesArbitraires":
                case "escaliersDroit":
                case "autresSections":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(emptyPanel, 1, 0);
                    break;
                case "r2020":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(r2020Panel, 1, 0);
                    break;
                case "ep10":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(ep10Panel, 1, 0);
                    break;
                case "sr5050":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(sr5050Panel, 1, 0);
                    break;
                case "st7070":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(st7070Panel, 1, 0);
                    break;
                case "f100115":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(f100115Panel, 1, 0);
                    break;
                case "od100100":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(od100100Panel, 1, 0);
                    break;
                case "es10":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(es10Panel, 1, 0);
                    break;
                case "t2040":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(t2040Panel, 1, 0);
                    break;
                case "c20":
                    if (sectionBaseTable.Controls.Count == 2)
                    {
                        sectionBaseTable.Controls.RemoveAt(1);
                    }
                    sectionBaseTable.Controls.Add(c20Panel, 1, 0);
                    break;
                default:
                    break;
            }
        }

    }
}
