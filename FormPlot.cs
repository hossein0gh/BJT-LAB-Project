using ScottPlot;
using System.Windows.Forms;

namespace BJT_LAb_Project
{
    public partial class FormPlot : Form
    {
        public FormPlot(double icmax,double vcemax,double ic, double vce)
        {
            InitializeComponent();

            plot.Plot.Title("DC Load Line and Operating Point");
            plot.Plot.XLabel("Vce (V)");
            plot.Plot.YLabel("Ic (mA)");

            ScottPlot.Plottables.LinePlot Loadline = new ScottPlot.Plottables.LinePlot()
            {
                Start = new Coordinates(vcemax,0),
                End = new Coordinates(0.2,icmax),
            };
            Loadline.LineWidth = 4;
            Loadline.MarkerColor = ScottPlot.Color.FromColor(System.Drawing.Color.Gray);
            plot.Plot.Add.Plottable(Loadline);

            var pointColor= ScottPlot.Color.FromColor(System.Drawing.Color.Red);
            plot.Plot.Add.Marker(vce,ic,MarkerShape.FilledCircle,10,pointColor);

            plot.Plot.Add.Text(
                text: $"Operating Point\n({vce:0.##} V, {ic:0.##} mA)",
                x: vce,
                y: ic+icmax/6
            );

            plot.Refresh();
        }
    }
}
