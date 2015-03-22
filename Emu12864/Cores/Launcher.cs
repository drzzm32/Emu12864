using System;
using System.Windows.Forms;

namespace Emu12864
{
    public partial class Launcher : Form
    {
        private Game GameObj;
        public static readonly string GameTitle = "Emu12864";

        public Launcher()
        {
            InitializeComponent();
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            this.Hide();

            /* 显示一个‘加载中’的窗口
             */
            Loading Load_Obj = new Loading();
            Load_Obj.Show();

            /* 分辨率设置以及窗口加载
             */
            if (FullScreen.Checked)
            {
                if (DMode1.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, true, 1280, 720))
                        goto ExitFlag;
                if (DMode2.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, true, 1600, 900))
                        goto ExitFlag;
                if (DMode3.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, true, 1920, 1080))
                        goto ExitFlag;
                if (DMode4.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, true, 2560, 1440))
                        goto ExitFlag;
            }
            else
            {
                if (DMode1.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, false, 1280, 720))
                        goto ExitFlag;
                if (DMode2.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, false, 1600, 900))
                        goto ExitFlag;
                if (DMode3.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, false, 1920, 1080))
                        goto ExitFlag;
                if (DMode4.Checked) if (!Core.DxCS.DxInit(this.Icon.Handle, GameTitle, false, 2560, 1440))
                        goto ExitFlag;
            }

            /* 实例化游戏类
             */
            GameObj = new Game();

            /* 关闭Loading窗体
             */
            Load_Obj.Dispose();

            /* 主游戏循环
             */
            while (!((DxDLL.DX.ProcessMessage() == -1) | Core.Base.GetKey(Keys.KeyESCAPE)))
            {
                GameObj.Work();
            }

        ExitFlag:
            
            Core.DxCS.DxEnd();
            this.Dispose();
        }
    }
}
