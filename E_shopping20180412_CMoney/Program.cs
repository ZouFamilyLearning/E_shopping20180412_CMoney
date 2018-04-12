using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shopping20180412_CMoney
{
    enum SHOP
    {
        Shopping = 1,
        Checkout,
    }

    struct Keyboard
    {
        public string name;
        int Num;
        int keyboardPrice;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ITEM item = new ITEM();
            BaseShop shopping = new Shopping();
            BaseShop checkout = new Checkout();
            //SHOP myShop = SHOP.Shopping;
            int myShop;
            Keyboard keyboard = new Keyboard();


            do
            {
                Console.Write("收銀系統的選單為 1) 購買商品 2)  結帳 -1) 結束 ");
                myShop = int.Parse(Console.ReadLine());
                BaseShop shop;

                switch ((SHOP)myShop)
                {
                    case SHOP.Shopping:
                        shop = new Shopping();
                        shopping.DoWork();
                        break;

                    case SHOP.Checkout:
                        shop = new Checkout();
                        checkout.DoWork();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\n======================================================");

            } while (myShop != -1);

            if (myShop == -1)
            {
                Console.WriteLine("謝謝再次光臨。");

            }
            Console.ReadLine();
        }
    }

}
