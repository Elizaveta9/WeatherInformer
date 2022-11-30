using System.ComponentModel;

namespace WeatherInformer
{
    partial class WeatherInformerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.addUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.addClothesButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.worldWeatherTab = new System.Windows.Forms.TabPage();
            this.weatherLable = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.worldWeatherTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(538, 12);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(250, 33);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.Location = new System.Drawing.Point(538, 51);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(250, 33);
            this.changeUserButton.TabIndex = 2;
            this.changeUserButton.Text = "Сменить пользователя";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // addClothesButton
            // 
            this.addClothesButton.Location = new System.Drawing.Point(538, 90);
            this.addClothesButton.Name = "addClothesButton";
            this.addClothesButton.Size = new System.Drawing.Size(250, 33);
            this.addClothesButton.TabIndex = 3;
            this.addClothesButton.Text = "Добавить одежду";
            this.addClothesButton.UseVisualStyleBackColor = true;
            this.addClothesButton.Click += new System.EventHandler(this.addClothesButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.worldWeatherTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // worldWeatherTab
            // 
            this.worldWeatherTab.Controls.Add(this.weatherLable);
            this.worldWeatherTab.Location = new System.Drawing.Point(4, 25);
            this.worldWeatherTab.Name = "worldWeatherTab";
            this.worldWeatherTab.Padding = new System.Windows.Forms.Padding(3);
            this.worldWeatherTab.Size = new System.Drawing.Size(503, 397);
            this.worldWeatherTab.TabIndex = 0;
            this.worldWeatherTab.Text = "world-weather.ru";
            this.worldWeatherTab.UseVisualStyleBackColor = true;
            // 
            // weatherLable
            // 
            this.weatherLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherLable.Location = new System.Drawing.Point(3, 3);
            this.weatherLable.Name = "weatherLable";
            this.weatherLable.Size = new System.Drawing.Size(494, 391);
            this.weatherLable.TabIndex = 0;
            this.weatherLable.Text = "Погода от world-weather.ru\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WeatherInformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addClothesButton);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "WeatherInformerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeatherInformerForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.worldWeatherTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label weatherLable;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage worldWeatherTab;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Button addClothesButton;

        private System.Windows.Forms.Button addUserButton;

        private System.Windows.Forms.Button changeUserButton;

        #endregion
    }
}