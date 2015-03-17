namespace Emu12864
{
    class Game : GameBase
    {
       public override void Start()
        {
            
        }

       public override void Loop()
        {
            for (int i = 0; i < 128; i++)
                for (int j = 0; j < 64; j++)
                    Engine.DrawPixel(i, j, 0xFFFFFF);
        }
    }
}
