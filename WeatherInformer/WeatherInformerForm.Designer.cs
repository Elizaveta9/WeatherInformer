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
            this.label1 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.addClothesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(146, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 178);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПОГОДА";
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
            // WeatherInformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addClothesButton);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label1);
            this.Name = "WeatherInformerForm";
            this.Text = "WeatherInformerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeatherInformerForm_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addClothesButton;

        private System.Windows.Forms.Button addUserButton;

        private System.Windows.Forms.Button changeUserButton;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}