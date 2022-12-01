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
            this.weatherWWLable = new System.Windows.Forms.Label();
            this.ngsTab = new System.Windows.Forms.TabPage();
            this.weatherNGSLabel = new System.Windows.Forms.Label();
            this.ppTab = new System.Windows.Forms.TabPage();
            this.weatherPPLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.wwTab.SuspendLayout();
            this.ngsTab.SuspendLayout();
            this.ppTab.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.wwTab);
            this.tabControl1.Controls.Add(this.ngsTab);
            this.tabControl1.Controls.Add(this.ppTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // wwTab
            // 
            this.wwTab.Controls.Add(this.weatherWWLable);
            this.wwTab.Location = new System.Drawing.Point(4, 25);
            this.wwTab.Name = "wwTab";
            this.wwTab.Padding = new System.Windows.Forms.Padding(3);
            this.wwTab.Size = new System.Drawing.Size(503, 397);
            this.wwTab.TabIndex = 0;
            this.wwTab.Text = "World Weather";
            this.wwTab.UseVisualStyleBackColor = true;
            // 
            // weatherWWLable
            // 
            this.weatherWWLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherWWLable.Location = new System.Drawing.Point(3, 3);
            this.weatherWWLable.Name = "weatherWWLable";
            this.weatherWWLable.Size = new System.Drawing.Size(494, 391);
            this.weatherWWLable.TabIndex = 0;
            this.weatherWWLable.Text = "Погода от world-weather.ru\r\n";
            // 
            // ngsTab
            // 
            this.ngsTab.Controls.Add(this.weatherNGSLabel);
            this.ngsTab.Location = new System.Drawing.Point(4, 25);
            this.ngsTab.Name = "ngsTab";
            this.ngsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ngsTab.Size = new System.Drawing.Size(503, 397);
            this.ngsTab.TabIndex = 1;
            this.ngsTab.Text = "NGS";
            this.ngsTab.UseVisualStyleBackColor = true;
            // 
            // weatherNGSLabel
            // 
            this.weatherNGSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherNGSLabel.Location = new System.Drawing.Point(4, 3);
            this.weatherNGSLabel.Name = "weatherNGSLabel";
            this.weatherNGSLabel.Size = new System.Drawing.Size(494, 391);
            this.weatherNGSLabel.TabIndex = 1;
            this.weatherNGSLabel.Text = "Погода от NGS\r\n";
            // 
            // ppTab
            // 
            this.ppTab.Controls.Add(this.weatherPPLabel);
            this.ppTab.Location = new System.Drawing.Point(4, 25);
            this.ppTab.Name = "ppTab";
            this.ppTab.Size = new System.Drawing.Size(503, 397);
            this.ppTab.TabIndex = 2;
            this.ppTab.Text = "Примпогода";
            this.ppTab.UseVisualStyleBackColor = true;
            // 
            // weatherPPLabel
            // 
            this.weatherPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherPPLabel.Location = new System.Drawing.Point(4, 3);
            this.weatherPPLabel.Name = "weatherPPLabel";
            this.weatherPPLabel.Size = new System.Drawing.Size(494, 391);
            this.weatherPPLabel.TabIndex = 2;
            this.weatherPPLabel.Text = "Погода от примпогода";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Location = new System.Drawing.Point(529, 423);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(259, 15);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "имя";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeatherInformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addClothesButton);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.addUserButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherInformerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeatherInformerForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.wwTab.ResumeLayout(false);
            this.ngsTab.ResumeLayout(false);
            this.ppTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

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