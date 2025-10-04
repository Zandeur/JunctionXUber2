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
            this.Distance = new System.Windows.Forms.TabPage();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Weather);
            this.tabControl1.Controls.Add(this.Distance);
            this.tabControl1.Location = new System.Drawing.Point(25, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // Weather
            // 
            this.Weather.Location = new System.Drawing.Point(4, 29);
            this.Weather.Name = "Weather";
            this.Weather.Padding = new System.Windows.Forms.Padding(3);
            this.Weather.Size = new System.Drawing.Size(1143, 548);
            this.Weather.TabIndex = 0;
            this.Weather.Text = "Weather";
            this.Weather.UseVisualStyleBackColor = true;
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(4, 29);
            this.Distance.Name = "Distance";
            this.Distance.Padding = new System.Windows.Forms.Padding(3);
            this.Distance.Size = new System.Drawing.Size(1143, 548);
            this.Distance.TabIndex = 1;
            this.Distance.Text = "Distance";
            this.Distance.UseVisualStyleBackColor = true;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(25, 52);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(1006, 26);
            this.textBoxUserId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1053, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage Distance;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Button button1;
    }
}

