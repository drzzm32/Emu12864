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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.Title = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BthExit = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.FunBox = new System.Windows.Forms.FlowLayoutPanel();
            this.PicConv = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConvTrans = new System.Windows.Forms.Button();
            this.CncConv = new System.Windows.Forms.GroupBox();
            this.CncTrans = new System.Windows.Forms.CheckBox();
            this.CncPre = new System.Windows.Forms.Button();
            this.CncGen = new System.Windows.Forms.Button();
            this.CncFont = new System.Windows.Forms.Button();
            this.CncInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CncType = new System.Windows.Forms.Label();
            this.CncTypeLabel = new System.Windows.Forms.Label();
            this.CncHeight = new System.Windows.Forms.Label();
            this.CncHeightLabel = new System.Windows.Forms.Label();
            this.CncWidth = new System.Windows.Forms.Label();
            this.CncWidthLabel = new System.Windows.Forms.Label();
            this.CncPreView = new System.Windows.Forms.PictureBox();
            this.Cmd = new System.Windows.Forms.GroupBox();
            this.CmdRun = new System.Windows.Forms.Button();
            this.CmdLine = new System.Windows.Forms.TextBox();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.ProBar = new System.Windows.Forms.ProgressBar();
            this.OpenLog = new System.Windows.Forms.OpenFileDialog();
            this.FunBox.SuspendLayout();
            this.PicConv.SuspendLayout();
            this.CncConv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CncPreView)).BeginInit();
            this.Cmd.SuspendLayout();
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
            this.BtnMin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.BtnMin.Location = new System.Drawing.Point(560, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(40, 39);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BthExit
            // 
            this.BthExit.FlatAppearance.BorderSize = 0;
            this.BthExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BthExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.BthExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BthExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BthExit.Location = new System.Drawing.Point(600, 0);
            this.BthExit.Name = "BthExit";
            this.BthExit.Size = new System.Drawing.Size(40, 39);
            this.BthExit.TabIndex = 2;
            this.BthExit.Text = "×";
            this.BthExit.UseVisualStyleBackColor = true;
            this.BthExit.Click += new System.EventHandler(this.BthExit_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.Window;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Output.Location = new System.Drawing.Point(220, 39);
            this.Output.Margin = new System.Windows.Forms.Padding(1);
            this.Output.MaximumSize = new System.Drawing.Size(420, 321);
            this.Output.MaxLength = 102400;
            this.Output.MinimumSize = new System.Drawing.Size(420, 321);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(420, 321);
            this.Output.TabIndex = 3;
            // 
            // FunBox
            // 
            this.FunBox.Controls.Add(this.PicConv);
            this.FunBox.Controls.Add(this.CncConv);
            this.FunBox.Controls.Add(this.Cmd);
            this.FunBox.Location = new System.Drawing.Point(0, 39);
            this.FunBox.Margin = new System.Windows.Forms.Padding(1);
            this.FunBox.Name = "FunBox";
            this.FunBox.Size = new System.Drawing.Size(218, 321);
            this.FunBox.TabIndex = 4;
            // 
            // PicConv
            // 
            this.PicConv.Controls.Add(this.button1);
            this.PicConv.Controls.Add(this.ConvTrans);
            this.PicConv.Location = new System.Drawing.Point(1, 1);
            this.PicConv.Margin = new System.Windows.Forms.Padding(1);
            this.PicConv.Name = "PicConv";
            this.PicConv.Size = new System.Drawing.Size(217, 60);
            this.PicConv.TabIndex = 6;
            this.PicConv.TabStop = false;
            this.PicConv.Text = "Pic Convert";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.button1.Location = new System.Drawing.Point(118, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Etc, No Trans";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ConvTrans
            // 
            this.ConvTrans.BackColor = System.Drawing.SystemColors.Window;
            this.ConvTrans.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.ConvTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.ConvTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ConvTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvTrans.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.ConvTrans.Location = new System.Drawing.Point(6, 22);
            this.ConvTrans.Name = "ConvTrans";
            this.ConvTrans.Size = new System.Drawing.Size(106, 33);
            this.ConvTrans.TabIndex = 7;
            this.ConvTrans.Text = "PNG, With Trans";
            this.ConvTrans.UseVisualStyleBackColor = false;
            this.ConvTrans.Click += new System.EventHandler(this.ConvTrans_Click);
            this.ConvTrans.MouseEnter += new System.EventHandler(this.ConvTrans_MouseEnter);
            // 
            // CncConv
            // 
            this.CncConv.Controls.Add(this.CncTrans);
            this.CncConv.Controls.Add(this.CncPre);
            this.CncConv.Controls.Add(this.CncGen);
            this.CncConv.Controls.Add(this.CncFont);
            this.CncConv.Controls.Add(this.CncInput);
            this.CncConv.Controls.Add(this.groupBox1);
            this.CncConv.Location = new System.Drawing.Point(1, 63);
            this.CncConv.Margin = new System.Windows.Forms.Padding(1);
            this.CncConv.Name = "CncConv";
            this.CncConv.Size = new System.Drawing.Size(217, 195);
            this.CncConv.TabIndex = 7;
            this.CncConv.TabStop = false;
            this.CncConv.Text = "CN Char Convert";
            // 
            // CncTrans
            // 
            this.CncTrans.AutoSize = true;
            this.CncTrans.BackColor = System.Drawing.Color.Transparent;
            this.CncTrans.FlatAppearance.BorderSize = 0;
            this.CncTrans.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CncTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.CncTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CncTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CncTrans.Location = new System.Drawing.Point(151, 24);
            this.CncTrans.Name = "CncTrans";
            this.CncTrans.Size = new System.Drawing.Size(50, 19);
            this.CncTrans.TabIndex = 5;
            this.CncTrans.Text = "Trans";
            this.CncTrans.UseVisualStyleBackColor = false;
            // 
            // CncPre
            // 
            this.CncPre.BackColor = System.Drawing.SystemColors.Window;
            this.CncPre.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.CncPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.CncPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CncPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CncPre.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.CncPre.Location = new System.Drawing.Point(80, 51);
            this.CncPre.Name = "CncPre";
            this.CncPre.Size = new System.Drawing.Size(57, 33);
            this.CncPre.TabIndex = 13;
            this.CncPre.Text = "Preview";
            this.CncPre.UseVisualStyleBackColor = false;
            // 
            // CncGen
            // 
            this.CncGen.BackColor = System.Drawing.SystemColors.Window;
            this.CncGen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.CncGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.CncGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CncGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CncGen.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.CncGen.Location = new System.Drawing.Point(143, 51);
            this.CncGen.Name = "CncGen";
            this.CncGen.Size = new System.Drawing.Size(64, 33);
            this.CncGen.TabIndex = 12;
            this.CncGen.Text = "Generate";
            this.CncGen.UseVisualStyleBackColor = false;
            // 
            // CncFont
            // 
            this.CncFont.BackColor = System.Drawing.SystemColors.Window;
            this.CncFont.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.CncFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.CncFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CncFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CncFont.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.CncFont.Location = new System.Drawing.Point(11, 51);
            this.CncFont.Name = "CncFont";
            this.CncFont.Size = new System.Drawing.Size(63, 33);
            this.CncFont.TabIndex = 11;
            this.CncFont.Text = "Set Font";
            this.CncFont.UseVisualStyleBackColor = false;
            // 
            // CncInput
            // 
            this.CncInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CncInput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CncInput.Location = new System.Drawing.Point(11, 22);
            this.CncInput.Name = "CncInput";
            this.CncInput.Size = new System.Drawing.Size(126, 23);
            this.CncInput.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CncType);
            this.groupBox1.Controls.Add(this.CncTypeLabel);
            this.groupBox1.Controls.Add(this.CncHeight);
            this.groupBox1.Controls.Add(this.CncHeightLabel);
            this.groupBox1.Controls.Add(this.CncWidth);
            this.groupBox1.Controls.Add(this.CncWidthLabel);
            this.groupBox1.Controls.Add(this.CncPreView);
            this.groupBox1.Location = new System.Drawing.Point(0, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 107);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Char Preview";
            // 
            // CncType
            // 
            this.CncType.AutoSize = true;
            this.CncType.Location = new System.Drawing.Point(183, 82);
            this.CncType.Name = "CncType";
            this.CncType.Size = new System.Drawing.Size(0, 15);
            this.CncType.TabIndex = 10;
            // 
            // CncTypeLabel
            // 
            this.CncTypeLabel.AutoSize = true;
            this.CncTypeLabel.Location = new System.Drawing.Point(143, 82);
            this.CncTypeLabel.Name = "CncTypeLabel";
            this.CncTypeLabel.Size = new System.Drawing.Size(34, 15);
            this.CncTypeLabel.TabIndex = 9;
            this.CncTypeLabel.Text = "Type:";
            // 
            // CncHeight
            // 
            this.CncHeight.AutoSize = true;
            this.CncHeight.Location = new System.Drawing.Point(143, 67);
            this.CncHeight.Name = "CncHeight";
            this.CncHeight.Size = new System.Drawing.Size(0, 15);
            this.CncHeight.TabIndex = 8;
            this.CncHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CncHeightLabel
            // 
            this.CncHeightLabel.AutoSize = true;
            this.CncHeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CncHeightLabel.Location = new System.Drawing.Point(143, 52);
            this.CncHeightLabel.Name = "CncHeightLabel";
            this.CncHeightLabel.Size = new System.Drawing.Size(57, 15);
            this.CncHeightLabel.TabIndex = 7;
            this.CncHeightLabel.Text = "Px Height";
            // 
            // CncWidth
            // 
            this.CncWidth.AutoSize = true;
            this.CncWidth.Location = new System.Drawing.Point(143, 37);
            this.CncWidth.Name = "CncWidth";
            this.CncWidth.Size = new System.Drawing.Size(0, 15);
            this.CncWidth.TabIndex = 6;
            // 
            // CncWidthLabel
            // 
            this.CncWidthLabel.AutoSize = true;
            this.CncWidthLabel.Location = new System.Drawing.Point(143, 22);
            this.CncWidthLabel.Name = "CncWidthLabel";
            this.CncWidthLabel.Size = new System.Drawing.Size(54, 15);
            this.CncWidthLabel.TabIndex = 5;
            this.CncWidthLabel.Text = "Px Width";
            // 
            // CncPreView
            // 
            this.CncPreView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CncPreView.ErrorImage = null;
            this.CncPreView.Location = new System.Drawing.Point(11, 22);
            this.CncPreView.Name = "CncPreView";
            this.CncPreView.Size = new System.Drawing.Size(126, 79);
            this.CncPreView.TabIndex = 5;
            this.CncPreView.TabStop = false;
            // 
            // Cmd
            // 
            this.Cmd.Controls.Add(this.CmdRun);
            this.Cmd.Controls.Add(this.CmdLine);
            this.Cmd.Location = new System.Drawing.Point(1, 260);
            this.Cmd.Margin = new System.Windows.Forms.Padding(1);
            this.Cmd.Name = "Cmd";
            this.Cmd.Size = new System.Drawing.Size(217, 60);
            this.Cmd.TabIndex = 8;
            this.Cmd.TabStop = false;
            this.Cmd.Text = "Run Command";
            // 
            // CmdRun
            // 
            this.CmdRun.BackColor = System.Drawing.SystemColors.Window;
            this.CmdRun.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.CmdRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(234)))));
            this.CmdRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CmdRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRun.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.CmdRun.Location = new System.Drawing.Point(166, 18);
            this.CmdRun.Name = "CmdRun";
            this.CmdRun.Size = new System.Drawing.Size(41, 33);
            this.CmdRun.TabIndex = 9;
            this.CmdRun.Text = "RUN";
            this.CmdRun.UseVisualStyleBackColor = false;
            this.CmdRun.Click += new System.EventHandler(this.CmdRun_Click);
            // 
            // CmdLine
            // 
            this.CmdLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CmdLine.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CmdLine.Location = new System.Drawing.Point(6, 23);
            this.CmdLine.Name = "CmdLine";
            this.CmdLine.Size = new System.Drawing.Size(154, 23);
            this.CmdLine.TabIndex = 5;
            this.CmdLine.Tag = "";
            this.CmdLine.MouseEnter += new System.EventHandler(this.CmdLine_MouseEnter);
            // 
            // Tips
            // 
            this.Tips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            // 
            // ProBar
            // 
            this.ProBar.Location = new System.Drawing.Point(381, 170);
            this.ProBar.Margin = new System.Windows.Forms.Padding(1);
            this.ProBar.MarqueeAnimationSpeed = 16;
            this.ProBar.Name = "ProBar";
            this.ProBar.Size = new System.Drawing.Size(105, 21);
            this.ProBar.Step = 1;
            this.ProBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProBar.TabIndex = 5;
            this.Tips.SetToolTip(this.ProBar, "Progress.");
            this.ProBar.Visible = false;
            // 
            // OpenLog
            // 
            this.OpenLog.Title = "Select a file";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.ProBar);
            this.Controls.Add(this.FunBox);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.BthExit);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
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
            this.FunBox.ResumeLayout(false);
            this.PicConv.ResumeLayout(false);
            this.CncConv.ResumeLayout(false);
            this.CncConv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CncPreView)).EndInit();
            this.Cmd.ResumeLayout(false);
            this.Cmd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BthExit;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.FlowLayoutPanel FunBox;
        private System.Windows.Forms.GroupBox PicConv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConvTrans;
        private System.Windows.Forms.GroupBox CncConv;
        private System.Windows.Forms.GroupBox Cmd;
        private System.Windows.Forms.Button CmdRun;
        private System.Windows.Forms.TextBox CmdLine;
        private System.Windows.Forms.Button CncPre;
        private System.Windows.Forms.Button CncGen;
        private System.Windows.Forms.Button CncFont;
        private System.Windows.Forms.TextBox CncInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CncType;
        private System.Windows.Forms.Label CncTypeLabel;
        private System.Windows.Forms.Label CncHeight;
        private System.Windows.Forms.Label CncHeightLabel;
        private System.Windows.Forms.Label CncWidth;
        private System.Windows.Forms.Label CncWidthLabel;
        private System.Windows.Forms.PictureBox CncPreView;
        private System.Windows.Forms.CheckBox CncTrans;
        private System.Windows.Forms.ToolTip Tips;
        private System.Windows.Forms.OpenFileDialog OpenLog;
        private System.Windows.Forms.ProgressBar ProBar;
    }
}