using Dm;
using System;
using System.Threading;
using System.Windows.Forms;
namespace Main
{
    class Program
    {
        static dmsoft  DM = new dmsoft();
        static void Main(string[] args)
        {
            DM.SetPath(Environment.CurrentDirectory + @"\Image");
            var hwnd = DM.GetMousePointWindow();
            DM.BindWindow(hwnd, "normal", "normal", "dx", 0);


            while (true) {
                int keyState = DM.GetKeyState(162);
                //ctrl :162 1:49 2:50 3:51
                if (DM.GetKeyState(162) == 1)
                {
                    //Red Card
                    if (DM.GetKeyState(49) == 1)
                    {
                        string IsRed;
                        Thread.Sleep(500);
                        DM.KeyPress((int)Keys.W);
                        for (int i = 0; i < 30; i++)
                        {
                            IsRed = DM.FindPicE(792, 939, 861, 1025, "Card_R.bmp|Card_Y.bmp|Card_B.bmp", "000000", 0.5, 0).Split('|')[0];
                            if (IsRed == "0")
                            {
                                DM.KeyPress((int)Keys.W);
                                break;
                            }
                            Thread.Sleep(100);
                        }
                        continue;
                    }
                    //Yellow Card
                    else if (DM.GetKeyState(50) == 1)
                    {
                        string IsYow;
                        Thread.Sleep(500);
                        DM.KeyPress((int)Keys.W);
                        for (int i = 0; i < 30; i++)
                        {
                            IsYow = DM.FindPicE(792, 939, 861, 1025, "Card_R.bmp|Card_Y.bmp|Card_B.bmp", "000000", 0.5, 0).Split('|')[0];
                            if (IsYow == "1")
                            {
                                DM.KeyPress((int)Keys.W);
                                break;
                            }
                            Thread.Sleep(100);
                        }
                        continue;
                    }
                    //Blue Card
                    else if (DM.GetKeyState(51) == 1)
                    {
                        string IsBlue;
                        Thread.Sleep(500);
                        DM.KeyPress((int)Keys.W);
                        for (int i = 0; i < 30; i++)
                        {
                            IsBlue = DM.FindPicE(792, 939, 861, 1025, "Card_R.bmp|Card_Y.bmp|Card_B.bmp", "000000", 0.5, 0).Split('|')[0];
                            if (IsBlue == "2")
                            {
                                DM.KeyPress((int)Keys.W);
                                break;
                            }
                            Thread.Sleep(100);
                        }
                        continue;
                    }
                }
            }
        }


    }
}
