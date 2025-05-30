using ScottPlot.Colormaps;
using ScottPlot;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BJT_LAb_Project
{
    public partial class Form1 : Form
    {
        double Vcc;
        double Rb1;
        double Rb2;
        double Re;
        double Rc;
        double Beta;

        double Ic;
        double Ie;
        double Ib;
        double Vce;
        Mode mode;

        double IcMax;
        double VceMax;

        FormPlot formPlot;

        enum Mode
        {
            CutOff,
            Saturation,
            Active
        }


        public Form1()
        {
            InitializeComponent();
        }

        void InitValues()
        {
            Vcc= VccTxtbox.Text == "" ? 0 : double.Parse(VccTxtbox.Text);
            Rb1 = Rb1Txtbox.Text == "" ? 0 : double.Parse(Rb1Txtbox.Text);
            Rb2 = Rb2Txtbox.Text == "" ? 0 : double.Parse(Rb2Txtbox.Text);
            Re = ReTxtbox.Text == "" ? 0 : double.Parse(ReTxtbox.Text);
            Rc = RcTxtbox.Text == "" ? 0 : double.Parse(RcTxtbox.Text);
            Beta = BetaTxtbox.Text == "" ? 0 : double.Parse(BetaTxtbox.Text);

        }

        void CalculateBaseParameters()
        {
            // Calculate base voltage (Vbe = 0.7V)
            double vth = Vcc * Rb2 / (Rb1 + Rb2);
            double rth = Rb1 * Rb2 / (Rb1 + Rb2);

            Ib = (vth - 0.7) / (rth + (Beta + 1) * Re);
        }

        void CalculateCollectorParameters()
        {
            Ic = Beta * Ib;
        }

        void CalculateEmitterParameters()
        {
            Ie = Ic + Ib;
        }
        
        void CalculateVce()
        {
            Vce = Vcc - Ic * Rc - Ie * Re;
        }

        void CalculateMode()
        {
            if (Ib <= 0)
            {
                mode = Mode.CutOff;
                Ic = 0;
                Vce = Vcc;
                ModeLbl.ForeColor = System.Drawing.Color.Red;
            }
            else if (Vce <= 0.2)
            {
                mode = Mode.Saturation;
                Vce = 0.2;
                Ic = (Vcc - Vce) / (Re + Rc);
                ModeLbl.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                mode = Mode.Active;
                ModeLbl.ForeColor = System.Drawing.Color.Green;
            }

            IcTxtbox.Text = ((float)Ic).ToString();
            VceTxtbox.Text = ((float)Vce).ToString();

            ModeLbl.Text = $"{mode.ToString()} Mode.";
        }

        void DrawPlot()
        {
            VceMax = Vcc;
            IcMax = (Vcc-0.2)/(Rc+Re);

            formPlot = new FormPlot(IcMax,VceMax,Ic,Vce);
            formPlot.Show();
        }

        private void AnalyzeBtn_Click(object sender, EventArgs e)
        {
            InitValues();
            CalculateBaseParameters();
            CalculateCollectorParameters();
            CalculateEmitterParameters();
            CalculateVce();
            CalculateMode();

            DrawPlot();
        }
    }
}
