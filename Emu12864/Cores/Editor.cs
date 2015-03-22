using System;
using System.Drawing;
using System.Windows.Forms;

namespace Emu12864
{
    public partial class Editor : Form
    {

        private Point MousePos;
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point PosTmp = this.PointToScreen(e.Location);
                MousePos = new Point(PosTmp.X - this.Left, PosTmp.Y - this.Top);
            }
        }

        private void Editor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point PosTmp = this.PointToScreen(e.Location);
                this.Left = PosTmp.X - MousePos.X;
                this.Top = PosTmp.Y - MousePos.Y;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BthExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Title_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Emu12864 Editor.\nCopyright the WDJ 2005 - 2015", "About");
        }

        private void CmdRun_Click(object sender, EventArgs e)
        {
            Output.Text = Core.Editor.RunCMD(CmdLine.Text);
            CmdLine.Text = "";
        }

        private void CmdLine_MouseEnter(object sender, EventArgs e)
        {
            Tips.SetToolTip(CmdLine, "Input \"build\" to build, \"run\" to build and run.\n" + "You can also use some cmd sentences.");
        }

        private void ConvTrans_MouseEnter(object sender, EventArgs e)
        {
            Tips.SetToolTip(ConvTrans, "You will lose alpha if the value > 0.");
        }

        private void ConvTrans_Click(object sender, EventArgs e)
        {
        Head:
            OpenLog.FileName = "";
            OpenLog.Filter = "PNG|*.png";
            OpenLog.ShowDialog();
            if (!System.IO.File.Exists(OpenLog.FileName))
            {
                if (MessageBox.Show("You need to choose a file!", "Notice", MessageBoxButtons.RetryCancel) == System.Windows.Forms.DialogResult.Retry) goto Head;
            }
            else
            {
                Bitmap TmpBmp = new Bitmap(OpenLog.FileName);
                ProBar.Show();
                Output.Text = Core.Editor.LoadBMP(TmpBmp);
                ProBar.Hide();
            }
        }


    }
}
