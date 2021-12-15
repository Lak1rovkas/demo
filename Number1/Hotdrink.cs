using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    abstract class Hotdrink
    {
        private int sugar = 3;        
        public int Sugar
        {
            get { return sugar; }
            set
            {

                if (value < 0)
                    throw new Exception("Отрицательное число сахар ");
                else
                    sugar = value;
            }
        }
        
        private int milk = 3;
        public int Milk
        {
            get { return milk; }
            set
            {
                if (value < 0)
                    throw new Exception("Отрицательное число молоко");
                else
                    milk = value;
            }
        }
    public string Drink()
        {
            return "Пьём...";
        }

    public string AddMilk()
        {
            if (Milk > 0)
            {
                return "Молоко добавлено!";
            }
            else
            {
                return null;
            }
        }

        public string AddSugar()
        {
            if (Sugar > 0)
            {
                return "Сахар добавлен!";
            }
            else
            {
                return null;
            }
        }
    }
}
