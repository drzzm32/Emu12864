using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            MessageBox.Show("Emu12864 Editor.\nCopyright the WDJ 2005 - 2015","About");
        }
    }
}
