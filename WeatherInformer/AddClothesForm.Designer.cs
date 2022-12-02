using System.ComponentModel;

namespace WeatherInformer
{
    partial class AddClothesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClothesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.minTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.maxTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минимальная температура ношения:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-46, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальная температура ношения:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(204, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // minTemperatureTextBox
            // 
            this.minTemperatureTextBox.Location = new System.Drawing.Point(204, 59);
            this.minTemperatureTextBox.Name = "minTemperatureTextBox";
            this.minTemperatureTextBox.Size = new System.Drawing.Size(174, 22);
            this.minTemperatureTextBox.TabIndex = 4;
            // 
            // maxTemperatureTextBox
            // 
            this.maxTemperatureTextBox.Location = new System.Drawing.Point(204, 102);
            this.maxTemperatureTextBox.Name = "maxTemperatureTextBox";
            this.maxTemperatureTextBox.Size = new System.Drawing.Size(174, 22);
            this.maxTemperatureTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Location = new System.Drawing.Point(263, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 26);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddClothesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 192);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.maxTemperatureTextBox);
            this.Controls.Add(this.minTemperatureTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClothesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить одежду";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox minTemperatureTextBox;
        private System.Windows.Forms.TextBox maxTemperatureTextBox;
        private System.Windows.Forms.Button addButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}