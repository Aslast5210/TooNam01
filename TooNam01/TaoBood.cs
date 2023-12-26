using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooNam01
{
    internal class TaoBood
    {
        int water;
        int coffee;
        int choco;
        int milk;

        public TaoBood() 
        {
            water = 1000;
            coffee = 100;
            choco = 100;
            milk = 500;
        }
        public bool BlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                //ทำกาแฟดำ
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Mocha()
        {
            if (water >= 300 && coffee >= 20 && choco >= 10)
            {
                //ทำมอคค่า
                water = water - 300;
                coffee = coffee - 20;
                choco = choco - 10;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Latte()
        {
            if (water >= 300 && coffee >= 20 && milk >= 10)
            {
                //ทำลาเต้
                water = water - 300;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Chocolate()
        {
            if (water >= 300 && choco >= 20)
            {
                //ทำช๊อคโกแลต
                water = water - 300;
                choco = choco - 20;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ReStack()
        {
            water = 1000;
            coffee = 100;
            choco = 100;
            milk = 500;

            return 1000;

        }

        public int GetRS()
        {
            return ReStack();
        }
    }
}
