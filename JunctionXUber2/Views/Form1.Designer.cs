namespace JunctionXUber2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Weather = new System.Windows.Forms.TabPage();
            this.dataGridViewWeather = new System.Windows.Forms.DataGridView();
            this.Distance = new System.Windows.Forms.TabPage();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.buttonSelectUserId = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.Weather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.Weather);
            this.tabControl1.Controls.Add(this.Distance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(27, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // Weather
            // 
            this.Weather.Controls.Add(this.dataGridViewWeather);
            this.Weather.Location = new System.Drawing.Point(4, 22);
            this.Weather.Margin = new System.Windows.Forms.Padding(2);
            this.Weather.Name = "Weather";
            this.Weather.Padding = new System.Windows.Forms.Padding(2);
            this.Weather.Size = new System.Drawing.Size(920, 479);
            this.Weather.TabIndex = 0;
            this.Weather.Text = "Weather";
            this.Weather.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.Size = new System.Drawing.Size(910, 469);
            this.dataGridViewWeather.TabIndex = 0;
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(4, 22);
            this.Distance.Margin = new System.Windows.Forms.Padding(2);
            this.Distance.Name = "Distance";
            this.Distance.Padding = new System.Windows.Forms.Padding(2);
            this.Distance.Size = new System.Drawing.Size(920, 479);
            this.Distance.TabIndex = 1;
            this.Distance.Text = "Distance";
            this.Distance.UseVisualStyleBackColor = true;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserId.Location = new System.Drawing.Point(27, 27);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(146, 24);
            this.textBoxUserId.TabIndex = 1;
            // 
            // buttonSelectUserId
            // 
            this.buttonSelectUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectUserId.Location = new System.Drawing.Point(177, 27);
            this.buttonSelectUserId.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectUserId.Name = "buttonSelectUserId";
            this.buttonSelectUserId.Size = new System.Drawing.Size(154, 24);
            this.buttonSelectUserId.TabIndex = 2;
            this.buttonSelectUserId.Text = "Select UserId";
            this.buttonSelectUserId.UseVisualStyleBackColor = true;
            this.buttonSelectUserId.Click += new System.EventHandler(this.buttonSelectUserId_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUserId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectUserId, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 609);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Weather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage Distance;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Button buttonSelectUserId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
    }
}

