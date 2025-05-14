using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJT_LAb_Project
{
    public partial class FormPlot : Form
    {
        public FormPlot(double icmax,double vcemax,double ic, double vce)
        {
            InitializeComponent();

            plotForm.Plot.Title("DC Load Line and Operating Point");
            plotForm.Plot.XLabel("Vce (V)");
            plotForm.Plot.YLabel("Ic (mA)");

            ScottPlot.Plottables.LinePlot Loadline = new ScottPlot.Plottables.LinePlot()
            {
                Start = new Coordinates(vcemax,0),
                End = new Coordinates(0,icmax),
            };
            Loadline.LineWidth = 4;
            Loadline.MarkerColor = ScottPlot.Color.FromColor(System.Drawing.Color.Gray);
            plotForm.Plot.Add.Plottable(Loadline);

            var pointColor= ScottPlot.Color.FromColor(System.Drawing.Color.Red);
            plotForm.Plot.Add.Marker(vce,ic,MarkerShape.FilledCircle,10,pointColor);

            plotForm.Plot.Add.Text(
                text: $"Operating Point\n({vce:0.##} V, {ic:0.##} mA)",
                x: vce,
                y: ic+icmax/6
            );

            plotForm.Refresh();
        }
    }
}
