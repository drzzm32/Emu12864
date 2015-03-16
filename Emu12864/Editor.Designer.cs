namespace Emu12864
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.Title = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BthExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.Title.Location = new System.Drawing.Point(258, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(123, 21);
            this.Title.TabIndex = 0;
            this.Title.Text = "Emu12864 Editor";
            this.Title.DoubleClick += new System.EventHandler(this.Title_DoubleClick);
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseMove);
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.BtnMin.Location = new System.Drawing.Point(560, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(40, 40);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.Text = "­";
            this.BtnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BthExit
            // 
            this.BthExit.FlatAppearance.BorderSize = 0;
            this.BthExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BthExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.BthExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BthExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.BthExit.Location = new System.Drawing.Point(600, 0);
            this.BthExit.Name = "BthExit";
            this.BthExit.Size = new System.Drawing.Size(40, 40);
            this.BthExit.TabIndex = 2;
            this.BthExit.Text = "×";
            this.BthExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BthExit.UseVisualStyleBackColor = true;
            this.BthExit.Click += new System.EventHandler(this.BthExit_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.BthExit);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BthExit;
    }
}