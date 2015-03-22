namespace Emu12864
{
    class Game : GameBase
    {
        private string str;
        int x, y;
        private Images imgs;

        public override void Start()
        {
            str = "Hello Gensokyo!";
            x = y = 0;
            imgs = new Images();
        }

        public override void Loop()
        {
            //Engine.DrawString(x, y, str, 0xFFFFFF, true, true);
            imgs.BMP.Draw(x, y);

            if (Engine.GetKey(Keys.KeyRIGHT)) x++;
            if (Engine.GetKey(Keys.KeyLEFT)) x--;
            if (Engine.GetKey(Keys.KeyUP)) y--;
            if (Engine.GetKey(Keys.KeyDOWN)) y++;

            if (x > 128) x = 0;
            if (x < 0) x = 128;
            if (y > 64) y = 0;
            if (y < 0) y = 64;

            Engine.DrawString(0, 46, "x:" + x, 0xFF0000, false, true);
            Engine.DrawString(0, 54, "y:" + y, 0x00FF00, false, true);
        }
    }
}
