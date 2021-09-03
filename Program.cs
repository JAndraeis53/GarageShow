using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero {MainColor = "Midnight Blue"};
            Tesla modelS = new Tesla { MainColor = "Burgundy"};
            Cessna mx410 = new Cessna { MainColor = "White"};
            Ram model1500 = new Ram { MainColor = "Silver"};
            Zero txs = new Zero { MainColor = "Black"};

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("Left");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            model1500.Drive();
            model1500.Turn("right");
            model1500.Stop();

            txs.Drive();
            txs.Turn("right");
            txs.Stop();
        }
    }
}
