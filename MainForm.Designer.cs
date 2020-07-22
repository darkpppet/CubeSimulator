namespace CubeSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbCube = new System.Windows.Forms.GroupBox();
            this.pbCubeImage = new System.Windows.Forms.PictureBox();
            this.rbBlackcube = new System.Windows.Forms.RadioButton();
            this.rbRedcube = new System.Windows.Forms.RadioButton();
            this.gbUp = new System.Windows.Forms.GroupBox();
            this.rbUniquetoLegendary = new System.Windows.Forms.RadioButton();
            this.rbEpictoUnique = new System.Windows.Forms.RadioButton();
            this.gbCost = new System.Windows.Forms.GroupBox();
            this.cbWonandMeso = new System.Windows.Forms.ComboBox();
            this.tbCostInput = new System.Windows.Forms.TextBox();
            this.rbCostInput = new System.Windows.Forms.RadioButton();
            this.rbCostDoublesix = new System.Windows.Forms.RadioButton();
            this.rbCostSix = new System.Windows.Forms.RadioButton();
            this.rbCostSingle = new System.Windows.Forms.RadioButton();
            this.gbMiracle = new System.Windows.Forms.GroupBox();
            this.rbMiracleDisable = new System.Windows.Forms.RadioButton();
            this.rbMiracleEnable = new System.Windows.Forms.RadioButton();
            this.tbCubeCount = new System.Windows.Forms.TextBox();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbCubeName = new System.Windows.Forms.Label();
            this.lbProbability = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.gbCube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCubeImage)).BeginInit();
            this.gbUp.SuspendLayout();
            this.gbCost.SuspendLayout();
            this.gbMiracle.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            this.mainChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Interval = 50D;
            chartArea1.AxisY.Interval = 0.1D;
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("나눔바른고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("나눔스퀘어 Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(15, 14);
            this.mainChart.Name = "mainChart";
            this.mainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.mainChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("나눔바른고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "mainSeries";
            series1.YValuesPerPoint = 2;
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(564, 340);
            this.mainChart.TabIndex = 0;
            title1.Font = new System.Drawing.Font("나눔스퀘어", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "cdf";
            this.mainChart.Titles.Add(title1);
            // 
            // gbCube
            // 
            this.gbCube.Controls.Add(this.pbCubeImage);
            this.gbCube.Controls.Add(this.rbBlackcube);
            this.gbCube.Controls.Add(this.rbRedcube);
            this.gbCube.Location = new System.Drawing.Point(584, 14);
            this.gbCube.Name = "gbCube";
            this.gbCube.Size = new System.Drawing.Size(303, 85);
            this.gbCube.TabIndex = 1;
            this.gbCube.TabStop = false;
            this.gbCube.Text = "큐브 종류";
            // 
            // pbCubeImage
            // 
            this.pbCubeImage.Image = global::CubeSimulator.Properties.Resources.redcube;
            this.pbCubeImage.Location = new System.Drawing.Point(132, 14);
            this.pbCubeImage.Name = "pbCubeImage";
            this.pbCubeImage.Size = new System.Drawing.Size(65, 63);
            this.pbCubeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCubeImage.TabIndex = 2;
            this.pbCubeImage.TabStop = false;
            // 
            // rbBlackcube
            // 
            this.rbBlackcube.AutoSize = true;
            this.rbBlackcube.Location = new System.Drawing.Point(7, 56);
            this.rbBlackcube.Name = "rbBlackcube";
            this.rbBlackcube.Size = new System.Drawing.Size(84, 21);
            this.rbBlackcube.TabIndex = 1;
            this.rbBlackcube.Text = "블랙 큐브";
            this.rbBlackcube.UseVisualStyleBackColor = true;
            this.rbBlackcube.Click += new System.EventHandler(this.rbBlackcube_Click);
            // 
            // rbRedcube
            // 
            this.rbRedcube.AutoSize = true;
            this.rbRedcube.Checked = true;
            this.rbRedcube.Location = new System.Drawing.Point(7, 27);
            this.rbRedcube.Name = "rbRedcube";
            this.rbRedcube.Size = new System.Drawing.Size(84, 21);
            this.rbRedcube.TabIndex = 0;
            this.rbRedcube.TabStop = true;
            this.rbRedcube.Text = "레드 큐브";
            this.rbRedcube.UseVisualStyleBackColor = true;
            this.rbRedcube.Click += new System.EventHandler(this.rbRedcube_Click);
            // 
            // gbUp
            // 
            this.gbUp.Controls.Add(this.rbUniquetoLegendary);
            this.gbUp.Controls.Add(this.rbEpictoUnique);
            this.gbUp.Location = new System.Drawing.Point(584, 105);
            this.gbUp.Name = "gbUp";
            this.gbUp.Size = new System.Drawing.Size(303, 86);
            this.gbUp.TabIndex = 2;
            this.gbUp.TabStop = false;
            this.gbUp.Text = "등업단계";
            // 
            // rbUniquetoLegendary
            // 
            this.rbUniquetoLegendary.AutoSize = true;
            this.rbUniquetoLegendary.Location = new System.Drawing.Point(7, 56);
            this.rbUniquetoLegendary.Name = "rbUniquetoLegendary";
            this.rbUniquetoLegendary.Size = new System.Drawing.Size(133, 21);
            this.rbUniquetoLegendary.TabIndex = 1;
            this.rbUniquetoLegendary.Text = "유니크 > 레전드리";
            this.rbUniquetoLegendary.UseVisualStyleBackColor = true;
            this.rbUniquetoLegendary.Click += new System.EventHandler(this.rbUniquetoLegendary_Click);
            // 
            // rbEpictoUnique
            // 
            this.rbEpictoUnique.AutoSize = true;
            this.rbEpictoUnique.Checked = true;
            this.rbEpictoUnique.Location = new System.Drawing.Point(7, 27);
            this.rbEpictoUnique.Name = "rbEpictoUnique";
            this.rbEpictoUnique.Size = new System.Drawing.Size(107, 21);
            this.rbEpictoUnique.TabIndex = 0;
            this.rbEpictoUnique.TabStop = true;
            this.rbEpictoUnique.Text = "에픽 > 유니크";
            this.rbEpictoUnique.UseVisualStyleBackColor = true;
            this.rbEpictoUnique.Click += new System.EventHandler(this.rbEpictoUnique_Click);
            // 
            // gbCost
            // 
            this.gbCost.Controls.Add(this.cbWonandMeso);
            this.gbCost.Controls.Add(this.tbCostInput);
            this.gbCost.Controls.Add(this.rbCostInput);
            this.gbCost.Controls.Add(this.rbCostDoublesix);
            this.gbCost.Controls.Add(this.rbCostSix);
            this.gbCost.Controls.Add(this.rbCostSingle);
            this.gbCost.Location = new System.Drawing.Point(584, 198);
            this.gbCost.Name = "gbCost";
            this.gbCost.Size = new System.Drawing.Size(303, 155);
            this.gbCost.TabIndex = 3;
            this.gbCost.TabStop = false;
            this.gbCost.Text = "가격";
            // 
            // cbWonandMeso
            // 
            this.cbWonandMeso.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbWonandMeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWonandMeso.Enabled = false;
            this.cbWonandMeso.FormattingEnabled = true;
            this.cbWonandMeso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbWonandMeso.Items.AddRange(new object[] {
            "원",
            "억 메소"});
            this.cbWonandMeso.Location = new System.Drawing.Point(236, 111);
            this.cbWonandMeso.Name = "cbWonandMeso";
            this.cbWonandMeso.Size = new System.Drawing.Size(61, 25);
            this.cbWonandMeso.TabIndex = 1;
            this.cbWonandMeso.SelectedIndexChanged += new System.EventHandler(this.cbWonandMeso_SelectedIndexChanged);
            // 
            // tbCostInput
            // 
            this.tbCostInput.Enabled = false;
            this.tbCostInput.Location = new System.Drawing.Point(97, 111);
            this.tbCostInput.Name = "tbCostInput";
            this.tbCostInput.Size = new System.Drawing.Size(133, 25);
            this.tbCostInput.TabIndex = 4;
            this.tbCostInput.TextChanged += new System.EventHandler(this.tbCostInput_TextChanged);
            // 
            // rbCostInput
            // 
            this.rbCostInput.AutoSize = true;
            this.rbCostInput.Location = new System.Drawing.Point(7, 112);
            this.rbCostInput.Name = "rbCostInput";
            this.rbCostInput.Size = new System.Drawing.Size(84, 21);
            this.rbCostInput.TabIndex = 3;
            this.rbCostInput.Text = "직접 입력";
            this.rbCostInput.UseVisualStyleBackColor = true;
            this.rbCostInput.Click += new System.EventHandler(this.rbCostInput_Click);
            // 
            // rbCostDoublesix
            // 
            this.rbCostDoublesix.AutoSize = true;
            this.rbCostDoublesix.Location = new System.Drawing.Point(7, 84);
            this.rbCostDoublesix.Name = "rbCostDoublesix";
            this.rbCostDoublesix.Size = new System.Drawing.Size(226, 21);
            this.rbCostDoublesix.TabIndex = 2;
            this.rbCostDoublesix.Text = "12개당 10800원(1개당 900원)";
            this.rbCostDoublesix.UseVisualStyleBackColor = true;
            this.rbCostDoublesix.Click += new System.EventHandler(this.rbCostDoublesix_Click);
            // 
            // rbCostSix
            // 
            this.rbCostSix.AutoSize = true;
            this.rbCostSix.Location = new System.Drawing.Point(7, 56);
            this.rbCostSix.Name = "rbCostSix";
            this.rbCostSix.Size = new System.Drawing.Size(217, 21);
            this.rbCostSix.TabIndex = 1;
            this.rbCostSix.Text = "6개당 6000원(1개당 1000원)";
            this.rbCostSix.UseVisualStyleBackColor = true;
            this.rbCostSix.Click += new System.EventHandler(this.rbCostSix_Click);
            // 
            // rbCostSingle
            // 
            this.rbCostSingle.AutoSize = true;
            this.rbCostSingle.Checked = true;
            this.rbCostSingle.Location = new System.Drawing.Point(7, 27);
            this.rbCostSingle.Name = "rbCostSingle";
            this.rbCostSingle.Size = new System.Drawing.Size(116, 21);
            this.rbCostSingle.TabIndex = 0;
            this.rbCostSingle.TabStop = true;
            this.rbCostSingle.Text = "1개당 1200원";
            this.rbCostSingle.UseVisualStyleBackColor = true;
            this.rbCostSingle.Click += new System.EventHandler(this.rbCostSingle_Click);
            // 
            // gbMiracle
            // 
            this.gbMiracle.Controls.Add(this.rbMiracleDisable);
            this.gbMiracle.Controls.Add(this.rbMiracleEnable);
            this.gbMiracle.Location = new System.Drawing.Point(584, 360);
            this.gbMiracle.Name = "gbMiracle";
            this.gbMiracle.Size = new System.Drawing.Size(303, 83);
            this.gbMiracle.TabIndex = 4;
            this.gbMiracle.TabStop = false;
            this.gbMiracle.Text = "미라클타임";
            // 
            // rbMiracleDisable
            // 
            this.rbMiracleDisable.AutoSize = true;
            this.rbMiracleDisable.Checked = true;
            this.rbMiracleDisable.Location = new System.Drawing.Point(7, 56);
            this.rbMiracleDisable.Name = "rbMiracleDisable";
            this.rbMiracleDisable.Size = new System.Drawing.Size(55, 21);
            this.rbMiracleDisable.TabIndex = 1;
            this.rbMiracleDisable.TabStop = true;
            this.rbMiracleDisable.Text = "안함";
            this.rbMiracleDisable.UseVisualStyleBackColor = true;
            this.rbMiracleDisable.Click += new System.EventHandler(this.rbMiracleDisable_Click);
            // 
            // rbMiracleEnable
            // 
            this.rbMiracleEnable.AutoSize = true;
            this.rbMiracleEnable.Location = new System.Drawing.Point(7, 27);
            this.rbMiracleEnable.Name = "rbMiracleEnable";
            this.rbMiracleEnable.Size = new System.Drawing.Size(42, 21);
            this.rbMiracleEnable.TabIndex = 0;
            this.rbMiracleEnable.Text = "함";
            this.rbMiracleEnable.UseVisualStyleBackColor = true;
            this.rbMiracleEnable.Click += new System.EventHandler(this.rbMiracleEnable_Click);
            // 
            // tbCubeCount
            // 
            this.tbCubeCount.Font = new System.Drawing.Font("나눔바른고딕", 11F);
            this.tbCubeCount.Location = new System.Drawing.Point(110, 379);
            this.tbCubeCount.Name = "tbCubeCount";
            this.tbCubeCount.Size = new System.Drawing.Size(58, 29);
            this.tbCubeCount.TabIndex = 5;
            this.tbCubeCount.Text = "∞";
            this.tbCubeCount.TextChanged += new System.EventHandler(this.tbCubeCount_TextChanged);
            // 
            // lbUp
            // 
            this.lbUp.AutoSize = true;
            this.lbUp.Font = new System.Drawing.Font("나눔바른고딕", 13F);
            this.lbUp.Location = new System.Drawing.Point(174, 382);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(377, 26);
            this.lbUp.TabIndex = 7;
            this.lbUp.Text = "개 안에 에픽에서 유니크로 등업할 확률은";
            // 
            // lbCubeName
            // 
            this.lbCubeName.AutoSize = true;
            this.lbCubeName.Font = new System.Drawing.Font("나눔바른고딕", 13F);
            this.lbCubeName.Location = new System.Drawing.Point(12, 382);
            this.lbCubeName.Name = "lbCubeName";
            this.lbCubeName.Size = new System.Drawing.Size(92, 26);
            this.lbCubeName.TabIndex = 8;
            this.lbCubeName.Text = "레드큐브";
            // 
            // lbProbability
            // 
            this.lbProbability.AutoSize = true;
            this.lbProbability.Font = new System.Drawing.Font("나눔바른고딕", 13F);
            this.lbProbability.Location = new System.Drawing.Point(10, 412);
            this.lbProbability.Name = "lbProbability";
            this.lbProbability.Size = new System.Drawing.Size(143, 26);
            this.lbProbability.TabIndex = 9;
            this.lbProbability.Text = "100% 입니다.";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("나눔바른고딕", 13F);
            this.lbCost.Location = new System.Drawing.Point(12, 456);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(104, 26);
            this.lbCost.TabIndex = 10;
            this.lbCost.Text = "비용: ∞원";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbProbability);
            this.Controls.Add(this.lbCubeName);
            this.Controls.Add(this.lbUp);
            this.Controls.Add(this.tbCubeCount);
            this.Controls.Add(this.gbMiracle);
            this.Controls.Add(this.gbCost);
            this.Controls.Add(this.gbUp);
            this.Controls.Add(this.gbCube);
            this.Controls.Add(this.mainChart);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "큐브 확률 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.gbCube.ResumeLayout(false);
            this.gbCube.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCubeImage)).EndInit();
            this.gbUp.ResumeLayout(false);
            this.gbUp.PerformLayout();
            this.gbCost.ResumeLayout(false);
            this.gbCost.PerformLayout();
            this.gbMiracle.ResumeLayout(false);
            this.gbMiracle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.GroupBox gbCube;
        private System.Windows.Forms.RadioButton rbBlackcube;
        private System.Windows.Forms.RadioButton rbRedcube;
        private System.Windows.Forms.GroupBox gbUp;
        private System.Windows.Forms.RadioButton rbUniquetoLegendary;
        private System.Windows.Forms.RadioButton rbEpictoUnique;
        private System.Windows.Forms.GroupBox gbCost;
        private System.Windows.Forms.RadioButton rbCostSix;
        private System.Windows.Forms.RadioButton rbCostSingle;
        private System.Windows.Forms.GroupBox gbMiracle;
        private System.Windows.Forms.RadioButton rbMiracleDisable;
        private System.Windows.Forms.RadioButton rbMiracleEnable;
        private System.Windows.Forms.TextBox tbCostInput;
        private System.Windows.Forms.RadioButton rbCostInput;
        private System.Windows.Forms.RadioButton rbCostDoublesix;
        private System.Windows.Forms.ComboBox cbWonandMeso;
        private System.Windows.Forms.PictureBox pbCubeImage;
        private System.Windows.Forms.TextBox tbCubeCount;
        private System.Windows.Forms.Label lbUp;
        private System.Windows.Forms.Label lbCubeName;
        private System.Windows.Forms.Label lbProbability;
        private System.Windows.Forms.Label lbCost;
    }
}

