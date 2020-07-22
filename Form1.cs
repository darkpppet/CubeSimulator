using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSimulator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public double CalcP()
        {
            double p = 0;

            if (rbRedcube.Checked)
            {
                if (rbEpictoUnique.Checked)
                    p = Data.pRedEtoU;
                else if (rbUniquetoLegendary.Checked)
                    p = Data.pRedUtoL;
            }
            else if (rbBlackcube.Checked)
            {
                if (rbEpictoUnique.Checked)
                    p = Data.pBlackEtoU;
                else if (rbUniquetoLegendary.Checked)
                    p = Data.pBlackUtoL;
            }

            if (rbMiracleEnable.Checked)
                p *= 2;

            return p;
        }

        public void DrawChart()
        {
            mainChart.Series["mainSeries"].Points.Clear();
            double p = CalcP();

            for (int i = 1; i <= 500; i++)
                mainChart.Series["mainSeries"].Points.Add(Data.CalcCdf(p, i));
        }

        public void WriteProbability()
        {
            try
            {
                double p = 100 * Data.CalcCdf(CalcP(), int.Parse(tbCubeCount.Text));
                lbProbability.Text = p + "% 입니다.";
            }
            catch (Exception e)
            {
                lbProbability.Text = "0% 입니다.";
            }
        }

        public void WriteCost()
        {
            try
            {
                int count = int.Parse(tbCubeCount.Text);
                double costone = 0;

                if (rbCostInput.Checked)
                {
                    costone = double.Parse(tbCostInput.Text);
                }
                else if (rbRedcube.Checked)
                {
                    if (rbCostSingle.Checked)
                        costone = Data.cRedSingle;
                    else if (rbCostSix.Checked)
                        costone = Data.cRedSix;
                    else if (rbCostDoublesix.Checked)
                        costone = Data.cRedDoubleSix;
                }
                else if (rbBlackcube.Checked)
                {
                    if (rbCostSingle.Checked)
                        costone = Data.cBlackSingle;
                    else if (rbCostSix.Checked)
                        costone = Data.cBlackSix;
                    else if (rbCostDoublesix.Checked)
                        costone = Data.cBlackDoubleSix;
                }

                if (rbCostInput.Checked && cbWonandMeso.SelectedIndex == 1)
                    lbCost.Text = "비용: " + (count * costone) + "억 메소";
                else
                    lbCost.Text = "비용: " + (count * costone) + "원";
            }
            catch (Exception e)
            {
                if (rbCostInput.Checked && cbWonandMeso.SelectedIndex == 1)
                    lbCost.Text = "비용: ∞억 메소";
                else
                    lbCost.Text = "비용: ∞원";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void rbRedcube_Click(object sender, EventArgs e)
        {
            rbCostSingle.Text = "1개당 1200원";
            rbCostSix.Text = "6개당 6000원(1개당 1000원)";
            rbCostDoublesix.Text = "12개당 10800원(1개당 900원)";
            lbCubeName.Text = "레드큐브";
            pbCubeImage.Image = CubeSimulator.Properties.Resources.redcube;

            WriteProbability();
            WriteCost();
            DrawChart();
        }

        private void rbBlackcube_Click(object sender, EventArgs e)
        {
            rbCostSingle.Text = "1개당 2200원";
            rbCostSix.Text = "6개당 11000원(1개당 1833.33...원)";
            rbCostDoublesix.Text = "12개당 19800원(1개당 1650원)";
            lbCubeName.Text = "블랙큐브";
            pbCubeImage.Image = CubeSimulator.Properties.Resources.blackcube;

            WriteProbability();
            WriteCost();
            DrawChart();
        }
        private void rbEpictoUnique_Click(object sender, EventArgs e)
        {
            lbUp.Text = "개 안에 에픽에서 유니크로 등업할 확률은";

            WriteProbability();
            DrawChart();
        }

        private void rbUniquetoLegendary_Click(object sender, EventArgs e)
        {
            lbUp.Text = "개 안에 유니크에서 레전드리로 등업할 확률은";

            WriteProbability();
            DrawChart();
        }

        private void rbCostSingle_Click(object sender, EventArgs e)
        {
            tbCostInput.Enabled = false;
            cbWonandMeso.Enabled = false;

            WriteCost();
        }

        private void rbCostSix_Click(object sender, EventArgs e)
        {
            tbCostInput.Enabled = false;
            cbWonandMeso.Enabled = false;

            WriteCost();
        }

        private void rbCostDoublesix_Click(object sender, EventArgs e)
        {
            tbCostInput.Enabled = false;
            cbWonandMeso.Enabled = false;

            WriteCost();
        }

        private void rbCostInput_Click(object sender, EventArgs e)
        {
            tbCostInput.Enabled = true;
            cbWonandMeso.Enabled = true;

            WriteCost();
        }

        private void rbMiracleEnable_Click(object sender, EventArgs e)
        {
            WriteProbability();
            DrawChart();
        }

        private void rbMiracleDisable_Click(object sender, EventArgs e)
        {
            WriteProbability();
            DrawChart();
        }

        private void tbCubeCount_TextChanged(object sender, EventArgs e)
        {
            WriteProbability();
            WriteCost();
        }

        private void tbCostInput_TextChanged(object sender, EventArgs e)
        {
            WriteCost();
        }

        private void cbWonandMeso_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteCost();
        }
    }
}
