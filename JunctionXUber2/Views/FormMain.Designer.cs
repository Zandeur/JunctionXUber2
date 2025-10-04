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
            this.textBoxUserId = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonSetUserId = new MaterialSkin.Controls.MaterialButton();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOptimalSuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWeatherSuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.chartWeather = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCitySuggestion = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxUserId = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.AnimateReadOnly = false;
            this.textBoxUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserId.Depth = 0;
            this.textBoxUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.textBoxUserId.LeadingIcon = null;
            this.textBoxUserId.LeaveOnEnterKey = true;
            this.textBoxUserId.Location = new System.Drawing.Point(46, 35);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
            this.textBoxUserId.MaxLength = 50;
            this.textBoxUserId.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxUserId.Multiline = false;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(183, 50);
            this.textBoxUserId.TabIndex = 0;
            this.textBoxUserId.Text = "E";
            this.textBoxUserId.TrailingIcon = null;
            this.textBoxUserId.TextChanged += new System.EventHandler(this.textBoxUserId_TextChanged);
            // 
            // buttonSetUserId
            // 
            this.buttonSetUserId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSetUserId.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSetUserId.Depth = 0;
            this.buttonSetUserId.HighEmphasis = true;
            this.buttonSetUserId.Icon = null;
            this.buttonSetUserId.Location = new System.Drawing.Point(238, 41);
            this.buttonSetUserId.Margin = new System.Windows.Forms.Padding(5, 10, 5, 7);
            this.buttonSetUserId.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSetUserId.Name = "buttonSetUserId";
            this.buttonSetUserId.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSetUserId.Size = new System.Drawing.Size(101, 36);
            this.buttonSetUserId.TabIndex = 1;
            this.buttonSetUserId.Text = "Set UserId";
            this.buttonSetUserId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSetUserId.UseAccentColor = false;
            this.buttonSetUserId.UseVisualStyleBackColor = true;
            this.buttonSetUserId.Click += new System.EventHandler(this.buttonSelectUserId_Click);
            // 
            // materialTabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.materialTabControl1, 3);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(46, 112);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1119, 444);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1111, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Optimal suggestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelOptimalSuggestion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 399);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelOptimalSuggestion
            // 
            this.labelOptimalSuggestion.AutoSize = true;
            this.labelOptimalSuggestion.Depth = 0;
            this.labelOptimalSuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOptimalSuggestion.Location = new System.Drawing.Point(4, 0);
            this.labelOptimalSuggestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOptimalSuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOptimalSuggestion.Name = "labelOptimalSuggestion";
            this.labelOptimalSuggestion.Size = new System.Drawing.Size(849, 19);
            this.labelOptimalSuggestion.TabIndex = 0;
            this.labelOptimalSuggestion.Text = "You have earned on average the most money ($[money]/h) when it was [weather] in [" +
    "city], making [distance]km long trips";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1109, 407);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1101, 399);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelWeatherSuggestion
            // 
            this.labelWeatherSuggestion.AutoSize = true;
            this.labelWeatherSuggestion.Depth = 0;
            this.labelWeatherSuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelWeatherSuggestion.Location = new System.Drawing.Point(4, 0);
            this.labelWeatherSuggestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeatherSuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelWeatherSuggestion.Name = "labelWeatherSuggestion";
            this.labelWeatherSuggestion.Size = new System.Drawing.Size(571, 19);
            this.labelWeatherSuggestion.TabIndex = 0;
            this.labelWeatherSuggestion.Text = "You have earned on average the most money ($[money]/h) when it was [weather]";
            // 
            // chartWeather
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeather.ChartAreas.Add(chartArea1);
            this.chartWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartWeather.Legends.Add(legend1);
            this.chartWeather.Location = new System.Drawing.Point(4, 23);
            this.chartWeather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartWeather.Name = "chartWeather";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWeather.Series.Add(series1);
            this.chartWeather.Size = new System.Drawing.Size(1093, 372);
            this.chartWeather.TabIndex = 1;
            this.chartWeather.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1111, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "City";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelCitySuggestion, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1111, 407);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // labelCitySuggestion
            // 
            this.labelCitySuggestion.AutoSize = true;
            this.labelCitySuggestion.Depth = 0;
            this.labelCitySuggestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCitySuggestion.Location = new System.Drawing.Point(4, 0);
            this.labelCitySuggestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCitySuggestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCitySuggestion.Name = "labelCitySuggestion";
            this.labelCitySuggestion.Size = new System.Drawing.Size(540, 19);
            this.labelCitySuggestion.TabIndex = 0;
            this.labelCitySuggestion.Text = "You have earned on average the most money ($[money]/h) when it was [city]";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.materialTabControl1, 1, 2);
          
            this.tableLayoutPanel1.Controls.Add(this.textBoxUserId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSetUserId, 2, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 599);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.textBoxUserId.Location = new System.Drawing.Point(115, 28);
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
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 79);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(914, 49);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 56);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "User id:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Uber-Insights";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel labelOptimalSuggestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel labelWeatherSuggestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel labelCitySuggestion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeather;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxUserId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}