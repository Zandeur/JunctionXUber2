namespace JunctionXUber2.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.optimalchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelOptimalSuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWeatherSuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.chartWeather = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chartCity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCitySuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelDistanceSuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxUserId = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabSelectorMain = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optimalchart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCity)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.materialTabControl1, 3);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(35, 134);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(838, 374);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Optimal suggestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.optimalchart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelOptimalSuggestion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(824, 337);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // optimalchart
            // 
            chartArea21.Name = "ChartAreaOptimal";
            this.optimalchart.ChartAreas.Add(chartArea21);
            this.optimalchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend21.Name = "LegendOptimal";
            this.optimalchart.Legends.Add(legend21);
            this.optimalchart.Location = new System.Drawing.Point(3, 22);
            this.optimalchart.Name = "optimalchart";
            series21.ChartArea = "ChartAreaOptimal";
            series21.Legend = "LegendOptimal";
            series21.Name = "SeriesOptimal";
            this.optimalchart.Series.Add(series21);
            this.optimalchart.Size = new System.Drawing.Size(818, 312);
            this.optimalchart.TabIndex = 2;
            this.optimalchart.Text = "chartOptimal";
            // 
            // labelOptimalSuggestion
            // 
            this.labelOptimalSuggestion.AutoSize = true;
            this.labelOptimalSuggestion.Depth = 0;
            this.labelOptimalSuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOptimalSuggestion.Location = new System.Drawing.Point(3, 0);
            this.labelOptimalSuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOptimalSuggestion.Name = "labelOptimalSuggestion";
            this.labelOptimalSuggestion.Size = new System.Drawing.Size(818, 19);
            this.labelOptimalSuggestion.TabIndex = 0;
            this.labelOptimalSuggestion.Text = "You have earned on average the most money (€[money]/h) when it was [weather] in [" +
    "city], making [distance]km long trips";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Weather";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelWeatherSuggestion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chartWeather, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(824, 337);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelWeatherSuggestion
            // 
            this.labelWeatherSuggestion.AutoSize = true;
            this.labelWeatherSuggestion.Depth = 0;
            this.labelWeatherSuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelWeatherSuggestion.Location = new System.Drawing.Point(3, 0);
            this.labelWeatherSuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelWeatherSuggestion.Name = "labelWeatherSuggestion";
            this.labelWeatherSuggestion.Size = new System.Drawing.Size(571, 19);
            this.labelWeatherSuggestion.TabIndex = 0;
            this.labelWeatherSuggestion.Text = "You have earned on average the most money (€[money]/h) when it was [weather]";
            // 
            // chartWeather
            // 
            chartArea22.Name = "ChartAreaWeather";
            this.chartWeather.ChartAreas.Add(chartArea22);
            this.chartWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            legend22.Name = "LegendWeather";
            this.chartWeather.Legends.Add(legend22);
            this.chartWeather.Location = new System.Drawing.Point(3, 22);
            this.chartWeather.Name = "chartWeather";
            series22.ChartArea = "ChartAreaWeather";
            series22.Legend = "LegendWeather";
            series22.Name = "SeriesWeather";
            this.chartWeather.Series.Add(series22);
            this.chartWeather.Size = new System.Drawing.Size(818, 312);
            this.chartWeather.TabIndex = 1;
            this.chartWeather.Text = "chartWeather";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(830, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "City";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chartCity, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelCitySuggestion, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(830, 343);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // chartCity
            // 
            chartArea23.Name = "ChartAreaCity";
            this.chartCity.ChartAreas.Add(chartArea23);
            this.chartCity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend23.Name = "LegendCity";
            this.chartCity.Legends.Add(legend23);
            this.chartCity.Location = new System.Drawing.Point(3, 22);
            this.chartCity.Name = "chartCity";
            series23.ChartArea = "ChartAreaCity";
            series23.Legend = "LegendCity";
            series23.Name = "SeriesCity";
            this.chartCity.Series.Add(series23);
            this.chartCity.Size = new System.Drawing.Size(824, 318);
            this.chartCity.TabIndex = 2;
            this.chartCity.Text = "chartCity";
            // 
            // labelCitySuggestion
            // 
            this.labelCitySuggestion.AutoSize = true;
            this.labelCitySuggestion.Depth = 0;
            this.labelCitySuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCitySuggestion.Location = new System.Drawing.Point(3, 0);
            this.labelCitySuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCitySuggestion.Name = "labelCitySuggestion";
            this.labelCitySuggestion.Size = new System.Drawing.Size(540, 19);
            this.labelCitySuggestion.TabIndex = 0;
            this.labelCitySuggestion.Text = "You have earned on average the most money (€[money]/h) when it was [city]";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(830, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Distance";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartDistance, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDistanceSuggestion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 343);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // chartDistance
            // 
            chartArea24.Name = "ChartAreaDistance";
            this.chartDistance.ChartAreas.Add(chartArea24);
            this.chartDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            legend24.Name = "LegendDistance";
            this.chartDistance.Legends.Add(legend24);
            this.chartDistance.Location = new System.Drawing.Point(3, 22);
            this.chartDistance.Name = "chartDistance";
            series24.ChartArea = "ChartAreaDistance";
            series24.Legend = "LegendDistance";
            series24.Name = "SeriesDistance";
            this.chartDistance.Series.Add(series24);
            this.chartDistance.Size = new System.Drawing.Size(824, 318);
            this.chartDistance.TabIndex = 3;
            this.chartDistance.Text = "chartDistance";
            // 
            // labelDistanceSuggestion
            // 
            this.labelDistanceSuggestion.AutoSize = true;
            this.labelDistanceSuggestion.Depth = 0;
            this.labelDistanceSuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDistanceSuggestion.Location = new System.Drawing.Point(3, 0);
            this.labelDistanceSuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDistanceSuggestion.Name = "labelDistanceSuggestion";
            this.labelDistanceSuggestion.Size = new System.Drawing.Size(582, 19);
            this.labelDistanceSuggestion.TabIndex = 0;
            this.labelDistanceSuggestion.Text = "You have earned on average the most money (€[money]/h) with [distance] km trips";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.materialTabControl1, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxUserId, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.materialLabel1, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(908, 543);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.AnimateReadOnly = false;
            this.textBoxUserId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxUserId.Depth = 0;
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxUserId.HideSelection = true;
            this.textBoxUserId.LeadingIcon = null;
            this.textBoxUserId.LeaveOnEnterKey = true;
            this.textBoxUserId.Location = new System.Drawing.Point(115, 78);
            this.textBoxUserId.MaxLength = 32767;
            this.textBoxUserId.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.PasswordChar = '\0';
            this.textBoxUserId.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.textBoxUserId.PrefixSuffixText = "E";
            this.textBoxUserId.ReadOnly = false;
            this.textBoxUserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUserId.SelectedText = "";
            this.textBoxUserId.SelectionLength = 0;
            this.textBoxUserId.SelectionStart = 0;
            this.textBoxUserId.ShortcutsEnabled = true;
            this.textBoxUserId.Size = new System.Drawing.Size(250, 48);
            this.textBoxUserId.TabIndex = 3;
            this.textBoxUserId.TabStop = false;
            this.textBoxUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxUserId.TrailingIcon = null;
            this.textBoxUserId.UseSystemPasswordChar = false;
            this.textBoxUserId.TextChanged += new System.EventHandler(this.textBoxUserId_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 49);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "User id:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSelectorMain
            // 
            this.tabSelectorMain.BaseTabControl = this.materialTabControl1;
            this.tabSelectorMain.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorMain.Depth = 0;
            this.tabSelectorMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorMain.Location = new System.Drawing.Point(0, 64);
            this.tabSelectorMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabSelectorMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMain.Name = "tabSelectorMain";
            this.tabSelectorMain.Size = new System.Drawing.Size(914, 49);
            this.tabSelectorMain.TabIndex = 1;
            this.tabSelectorMain.Text = "materialTabSelector1";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 610);
            this.Controls.Add(this.tabSelectorMain);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Uber Insights";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optimalchart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCity)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel labelOptimalSuggestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel labelWeatherSuggestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel labelCitySuggestion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeather;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMain;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxUserId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel labelDistanceSuggestion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistance;
        private System.Windows.Forms.DataVisualization.Charting.Chart optimalchart;
    }
}