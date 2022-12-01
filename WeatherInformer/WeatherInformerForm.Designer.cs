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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherInformerForm));
            this.addUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.addClothesButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wwTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.precipitationWWLabel = new System.Windows.Forms.Label();
            this.weatherWWLable = new System.Windows.Forms.Label();
            this.ngsTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.precipitationNgsLabel = new System.Windows.Forms.Label();
            this.weatherNGSLabel = new System.Windows.Forms.Label();
            this.ppTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.precipitationPPLabel = new System.Windows.Forms.Label();
            this.weatherPPLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.clothesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.avgTemperatureLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.wwTab.SuspendLayout();
            this.ngsTab.SuspendLayout();
            this.ppTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addUserButton.Location = new System.Drawing.Point(538, 12);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(250, 33);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.changeUserButton.Location = new System.Drawing.Point(538, 51);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(250, 33);
            this.changeUserButton.TabIndex = 2;
            this.changeUserButton.Text = "Сменить пользователя";
            this.changeUserButton.UseVisualStyleBackColor = false;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // addClothesButton
            // 
            this.addClothesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addClothesButton.Location = new System.Drawing.Point(538, 90);
            this.addClothesButton.Name = "addClothesButton";
            this.addClothesButton.Size = new System.Drawing.Size(250, 33);
            this.addClothesButton.TabIndex = 3;
            this.addClothesButton.Text = "Добавить одежду";
            this.addClothesButton.UseVisualStyleBackColor = false;
            this.addClothesButton.Click += new System.EventHandler(this.addClothesButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wwTab);
            this.tabControl1.Controls.Add(this.ngsTab);
            this.tabControl1.Controls.Add(this.ppTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 381);
            this.tabControl1.TabIndex = 4;
            // 
            // wwTab
            // 
            this.wwTab.Controls.Add(this.label3);
            this.wwTab.Controls.Add(this.precipitationWWLabel);
            this.wwTab.Controls.Add(this.weatherWWLable);
            this.wwTab.Location = new System.Drawing.Point(4, 25);
            this.wwTab.Name = "wwTab";
            this.wwTab.Padding = new System.Windows.Forms.Padding(3);
            this.wwTab.Size = new System.Drawing.Size(503, 352);
            this.wwTab.TabIndex = 0;
            this.wwTab.Text = "World Weather";
            this.wwTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Влажность:";
            // 
            // precipitationWWLabel
            // 
            this.precipitationWWLabel.AutoSize = true;
            this.precipitationWWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.precipitationWWLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.precipitationWWLabel.Location = new System.Drawing.Point(216, 94);
            this.precipitationWWLabel.MaximumSize = new System.Drawing.Size(503, 0);
            this.precipitationWWLabel.Name = "precipitationWWLabel";
            this.precipitationWWLabel.Size = new System.Drawing.Size(450, 36);
            this.precipitationWWLabel.TabIndex = 1;
            this.precipitationWWLabel.Text = "Влажность от world-weather.ru\r\n";
            // 
            // weatherWWLable
            // 
            this.weatherWWLable.AutoSize = true;
            this.weatherWWLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherWWLable.Location = new System.Drawing.Point(3, 3);
            this.weatherWWLable.Name = "weatherWWLable";
            this.weatherWWLable.Size = new System.Drawing.Size(1023, 91);
            this.weatherWWLable.TabIndex = 0;
            this.weatherWWLable.Text = "Погода от world-weather.ru\r\n";
            // 
            // ngsTab
            // 
            this.ngsTab.Controls.Add(this.label4);
            this.ngsTab.Controls.Add(this.precipitationNgsLabel);
            this.ngsTab.Controls.Add(this.weatherNGSLabel);
            this.ngsTab.Location = new System.Drawing.Point(4, 25);
            this.ngsTab.Name = "ngsTab";
            this.ngsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ngsTab.Size = new System.Drawing.Size(503, 352);
            this.ngsTab.TabIndex = 1;
            this.ngsTab.Text = "NGS";
            this.ngsTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Влажность:";
            // 
            // precipitationNgsLabel
            // 
            this.precipitationNgsLabel.AutoSize = true;
            this.precipitationNgsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.precipitationNgsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.precipitationNgsLabel.Location = new System.Drawing.Point(216, 94);
            this.precipitationNgsLabel.MaximumSize = new System.Drawing.Size(503, 0);
            this.precipitationNgsLabel.Name = "precipitationNgsLabel";
            this.precipitationNgsLabel.Size = new System.Drawing.Size(450, 36);
            this.precipitationNgsLabel.TabIndex = 3;
            this.precipitationNgsLabel.Text = "Влажность от world-weather.ru\r\n";
            // 
            // weatherNGSLabel
            // 
            this.weatherNGSLabel.AutoSize = true;
            this.weatherNGSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherNGSLabel.Location = new System.Drawing.Point(4, 3);
            this.weatherNGSLabel.Name = "weatherNGSLabel";
            this.weatherNGSLabel.Size = new System.Drawing.Size(603, 91);
            this.weatherNGSLabel.TabIndex = 1;
            this.weatherNGSLabel.Text = "Погода от NGS\r\n";
            // 
            // ppTab
            // 
            this.ppTab.Controls.Add(this.label5);
            this.ppTab.Controls.Add(this.precipitationPPLabel);
            this.ppTab.Controls.Add(this.weatherPPLabel);
            this.ppTab.Location = new System.Drawing.Point(4, 25);
            this.ppTab.Name = "ppTab";
            this.ppTab.Size = new System.Drawing.Size(503, 352);
            this.ppTab.TabIndex = 2;
            this.ppTab.Text = "Примпогода";
            this.ppTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 80);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вероятность осадков:";
            // 
            // precipitationPPLabel
            // 
            this.precipitationPPLabel.AutoSize = true;
            this.precipitationPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.precipitationPPLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.precipitationPPLabel.Location = new System.Drawing.Point(217, 108);
            this.precipitationPPLabel.MaximumSize = new System.Drawing.Size(503, 0);
            this.precipitationPPLabel.Name = "precipitationPPLabel";
            this.precipitationPPLabel.Size = new System.Drawing.Size(450, 36);
            this.precipitationPPLabel.TabIndex = 5;
            this.precipitationPPLabel.Text = "Влажность от world-weather.ru\r\n";
            // 
            // weatherPPLabel
            // 
            this.weatherPPLabel.AutoSize = true;
            this.weatherPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherPPLabel.Location = new System.Drawing.Point(4, 3);
            this.weatherPPLabel.Name = "weatherPPLabel";
            this.weatherPPLabel.Size = new System.Drawing.Size(874, 91);
            this.weatherPPLabel.TabIndex = 2;
            this.weatherPPLabel.Text = "Погода от примпогода";
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Location = new System.Drawing.Point(529, 423);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(259, 15);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "имя";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clothesListBox
            // 
            this.clothesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clothesListBox.FormattingEnabled = true;
            this.clothesListBox.ItemHeight = 16;
            this.clothesListBox.Location = new System.Drawing.Point(538, 181);
            this.clothesListBox.Name = "clothesListBox";
            this.clothesListBox.Size = new System.Drawing.Size(250, 212);
            this.clothesListBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(538, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Рекомендованная одежда\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Средняя температура:";
            // 
            // avgTemperatureLabel
            // 
            this.avgTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.avgTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgTemperatureLabel.Location = new System.Drawing.Point(173, 417);
            this.avgTemperatureLabel.Name = "avgTemperatureLabel";
            this.avgTemperatureLabel.Size = new System.Drawing.Size(54, 21);
            this.avgTemperatureLabel.TabIndex = 9;
            this.avgTemperatureLabel.Text = "темп";
            // 
            // WeatherInformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avgTemperatureLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clothesListBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addClothesButton);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.addUserButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherInformerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeatherInformerForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.wwTab.ResumeLayout(false);
            this.wwTab.PerformLayout();
            this.ngsTab.ResumeLayout(false);
            this.ngsTab.PerformLayout();
            this.ppTab.ResumeLayout(false);
            this.ppTab.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label precipitationPPLabel;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label precipitationNgsLabel;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label avgTemperatureLabel;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox clothesListBox;

        private System.Windows.Forms.Label precipitationWWLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label userNameLabel;

        private System.Windows.Forms.Label weatherPPLabel;

        private System.Windows.Forms.TabPage ppTab;

        private System.Windows.Forms.Label weatherNGSLabel;

        private System.Windows.Forms.Label weatherWWLable;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wwTab;
        private System.Windows.Forms.TabPage ngsTab;

        private System.Windows.Forms.Button addClothesButton;

        private System.Windows.Forms.Button addUserButton;

        private System.Windows.Forms.Button changeUserButton;

        #endregion
    }
}