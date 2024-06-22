namespace WeatherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button GetWeatherButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox TempTextBox;
        private System.Windows.Forms.TextBox WindTextBox;
        private System.Windows.Forms.TextBox HumidityTextBox;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.GetWeatherButton = new System.Windows.Forms.Button();
            this.TempTextBox = new System.Windows.Forms.TextBox();
            this.WindTextBox = new System.Windows.Forms.TextBox();
            this.HumidityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.CityTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.CityTextBox.Location = new System.Drawing.Point(31, 41);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(234, 29);
            this.CityTextBox.TabIndex = 0;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);

            this.GetWeatherButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GetWeatherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GetWeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GetWeatherButton.Font = new System.Drawing.Font("Arial", 15.75F);
            this.GetWeatherButton.Location = new System.Drawing.Point(324, 40);
            this.GetWeatherButton.Name = "GetWeatherButton";
            this.GetWeatherButton.Size = new System.Drawing.Size(180, 32);
            this.GetWeatherButton.TabIndex = 1;
            this.GetWeatherButton.Text = "Sprawdź pogodę";
            this.GetWeatherButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GetWeatherButton.UseVisualStyleBackColor = false;
            this.GetWeatherButton.Click += new System.EventHandler(this.GetWeatherButton_Click);

            this.TempTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TempTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.TempTextBox.Location = new System.Drawing.Point(14, 107);
            this.TempTextBox.Name = "TempTextBox";
            this.TempTextBox.ReadOnly = true;
            this.TempTextBox.Size = new System.Drawing.Size(544, 29);
            this.TempTextBox.TabIndex = 3;
 
            this.WindTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.WindTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.WindTextBox.Location = new System.Drawing.Point(14, 159);
            this.WindTextBox.Name = "WindTextBox";
            this.WindTextBox.ReadOnly = true;
            this.WindTextBox.Size = new System.Drawing.Size(544, 29);
            this.WindTextBox.TabIndex = 4;
            this.WindTextBox.TextChanged += new System.EventHandler(this.WindTextBox_TextChanged);
 
            this.HumidityTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.HumidityTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HumidityTextBox.Location = new System.Drawing.Point(14, 214);
            this.HumidityTextBox.Name = "HumidityTextBox";
            this.HumidityTextBox.ReadOnly = true;
            this.HumidityTextBox.Size = new System.Drawing.Size(544, 29);
            this.HumidityTextBox.TabIndex = 5;
            this.HumidityTextBox.TextChanged += new System.EventHandler(this.HumidityTextBox_TextChanged);

            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(569, 303);
            this.Controls.Add(this.HumidityTextBox);
            this.Controls.Add(this.WindTextBox);
            this.Controls.Add(this.TempTextBox);
            this.Controls.Add(this.GetWeatherButton);
            this.Controls.Add(this.CityTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

