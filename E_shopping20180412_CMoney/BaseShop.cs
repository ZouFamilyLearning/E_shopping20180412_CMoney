using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shopping20180412_CMoney
{

    public abstract class BaseShop
    {
        public abstract void DoWork();
    }

    public class Shopping : BaseShop
    {
        public override void DoWork()
        {
            bool haha = true;

            //int Keyboard, int mouse, int screen
            int KeyboardNum = 10;
            int mouseNum = 25;
            int screenNum = 5;

            int KeyboardPrice = 100;
            int mousePrice = 300;
            int screenPrice = 3000;

            string Keyboard = "鍵盤";
            string mouse = "滑鼠";
            string screen = "螢幕";
            do
            {
                Console.WriteLine("目前有以下商品，請輸入編號與購買數量，或按 -1 返回主選單 \n");

                Console.WriteLine($"1. 鍵盤, 單價 {KeyboardPrice}, 庫存數量{KeyboardNum}");
                Console.WriteLine($"2. 滑鼠, 單價 {mousePrice}, 庫存數量{mouseNum}");
                Console.WriteLine($"3. 螢幕, 單價{screenPrice}，庫存數量{screenNum} \n");


                Console.Write("請輸入: ");
                string inputShopping = Console.ReadLine();
                string[] amount = inputShopping.Split(',');
                switch (int.Parse(amount[0]))
                {
                    case 1:
                        if (int.Parse(amount[1]) <= KeyboardNum)
                        {
                            Console.WriteLine("購買成功。");
                            KeyboardNum -= (int.Parse(amount[1]));
                        }
                        else
                        {
                            Console.WriteLine("購買失敗，目前庫存不足");
                        }
                        break;
                    case 2:
                        if (int.Parse(amount[1]) <= mouseNum)
                        {
                            Console.WriteLine("購買成功。");
                            mouseNum -= (int.Parse(amount[1]));
                        }
                        else
                        {
                            Console.WriteLine("購買失敗，目前庫存不足");
                        }
                        break;
                    case 3:
                        if (int.Parse(amount[1]) <= screenNum)
                        {
                            Console.WriteLine("購買成功。");
                            screenNum -= (int.Parse(amount[1]));
                        }
                        else
                        {
                            Console.WriteLine("購買失敗，目前庫存不足");
                        }
                        break;

                    case -1:
                        Console.WriteLine("回到主選單。");
                        haha = false;
                        break;
                    default:
                        break;
                }

            } while (haha);
        }
    }
    public class Checkout : BaseShop
    {
        public override void DoWork()
        {
            bool hehe = true;

            //int Keyboard, int mouse, int screen
            int KeyboardNum = 10;
            int mouseNum = 25;
            int screenNum = 5;

            int KeyboardPrice = 100;
            int mousePrice = 300;
            int screenPrice = 3000;

            string Keyboard = "鍵盤";
            string mouse = "滑鼠";
            string screen = "螢幕";
            do
            {
                Console.WriteLine("選擇結帳方案 1) 一般計價 2) 打8折 3) 滿 1000 送 100   -1) 返回主選單 \n");

                Console.Write("請輸入: ");
                int inputCheckout = int.Parse(Console.ReadLine());

                switch (inputCheckout)
                {
                    case 1:
                        Console.WriteLine($"鍵盤, 單價 300, 購買數量 10，原價3000，共計3000元");
                        break;
                    case 2:
                        Console.WriteLine("鍵盤, 單價 300, 購買數量 10，原價3000，折扣後共計2400元");
                        break;
                    case 3:
                        Console.WriteLine("鍵盤, 單價 300, 購買數量 10，原價3000，折扣後共2700元");
                        break;

                    case -1:
                        Console.WriteLine("回到主選單。");
                        hehe = false;
                        break;
                    default:
                        break;
                }

            } while (hehe);
        }
    }
}
