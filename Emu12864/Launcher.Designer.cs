namespace Emu12864
{
    partial class Launcher
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
            this.DMPanel = new System.Windows.Forms.Panel();
            this.DMode4 = new System.Windows.Forms.RadioButton();
            this.DMode3 = new System.Windows.Forms.RadioButton();
            this.DMode2 = new System.Windows.Forms.RadioButton();
            this.DMode1 = new System.Windows.Forms.RadioButton();
            this.FullScreen = new System.Windows.Forms.CheckBox();
            this.Launch = new System.Windows.Forms.Button();
            this.DMPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DMPanel
            // 
            this.DMPanel.Controls.Add(this.DMode4);
            this.DMPanel.Controls.Add(this.DMode3);
            this.DMPanel.Controls.Add(this.DMode2);
            this.DMPanel.Controls.Add(this.DMode1);
            this.DMPanel.Location = new System.Drawing.Point(9, 6);
            this.DMPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.DMPanel.Name = "DMPanel";
            this.DMPanel.Size = new System.Drawing.Size(87, 76);
            this.DMPanel.TabIndex = 0;
            // 
            // DMode4
            // 
            this.DMode4.AutoSize = true;
            this.DMode4.Location = new System.Drawing.Point(3, 57);
            this.DMode4.Margin = new System.Windows.Forms.Padding(1);
            this.DMode4.Name = "DMode4";
            this.DMode4.Size = new System.Drawing.Size(83, 16);
            this.DMode4.TabIndex = 4;
            this.DMode4.Text = "2560×1440";
            this.DMode4.UseVisualStyleBackColor = true;
            // 
            // DMode3
            // 
            this.DMode3.AutoSize = true;
            this.DMode3.Location = new System.Drawing.Point(3, 39);
            this.DMode3.Margin = new System.Windows.Forms.Padding(1);
            this.DMode3.Name = "DMode3";
            this.DMode3.Size = new System.Drawing.Size(83, 16);
            this.DMode3.TabIndex = 3;
            this.DMode3.Text = "1920×1080";
            this.DMode3.UseVisualStyleBackColor = true;
            // 
            // DMode2
            // 
            this.DMode2.AutoSize = true;
            this.DMode2.Location = new System.Drawing.Point(3, 21);
            this.DMode2.Margin = new System.Windows.Forms.Padding(1);
            this.DMode2.Name = "DMode2";
            this.DMode2.Size = new System.Drawing.Size(77, 16);
            this.DMode2.TabIndex = 2;
            this.DMode2.Text = "1600×900";
            this.DMode2.UseVisualStyleBackColor = true;
            // 
            // DMode1
            // 
            this.DMode1.AutoSize = true;
            this.DMode1.Checked = true;
            this.DMode1.Location = new System.Drawing.Point(3, 3);
            this.DMode1.Margin = new System.Windows.Forms.Padding(1);
            this.DMode1.Name = "DMode1";
            this.DMode1.Size = new System.Drawing.Size(77, 16);
            this.DMode1.TabIndex = 1;
            this.DMode1.TabStop = true;
            this.DMode1.Text = "1280×720";
            this.DMode1.UseVisualStyleBackColor = true;
            // 
            // FullScreen
            // 
            this.FullScreen.AutoSize = true;
            this.FullScreen.Location = new System.Drawing.Point(12, 84);
            this.FullScreen.Margin = new System.Windows.Forms.Padding(1);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(84, 16);
            this.FullScreen.TabIndex = 1;
            this.FullScreen.Text = "FullScreen";
            this.FullScreen.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            this.Launch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Launch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Launch.Location = new System.Drawing.Point(9, 105);
            this.Launch.Margin = new System.Windows.Forms.Padding(1);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(87, 23);
            this.Launch.TabIndex = 2;
            this.Launch.Text = "Launch";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(105, 135);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.FullScreen);
            this.Controls.Add(this.DMPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emu12864";
            this.TopMost = true;
            this.DMPanel.ResumeLayout(false);
            this.DMPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DMPanel;
        private System.Windows.Forms.RadioButton DMode4;
        private System.Windows.Forms.RadioButton DMode3;
        private System.Windows.Forms.RadioButton DMode2;
        private System.Windows.Forms.RadioButton DMode1;
        private System.Windows.Forms.CheckBox FullScreen;
        private System.Windows.Forms.Button Launch;
    }
}