namespace Emu12864
{
    class Game
    {
        private Core.Base.FPSCounter FPSer;

        public Game()
        {
            FPSer = new Core.Base.FPSCounter();
        }

        public void Work()
        {
            Core.DxCS.DxFlip();
            MainRender();
            FPSer.Update();
            FPSer.WaitTime();
            Core.Draw.EMU_P6x8Str(0, 0, FPSer.GetFPS().ToString("f2"));
        }

        private void MainRender()
        {
            for (int i = 64; i < 128; i++)
                for (int j = 32; j < 64; j++)
                    Core.DxCS.DrawPixel(i, j, 0xFFFFFF);
        }
    }
}
