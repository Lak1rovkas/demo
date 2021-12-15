using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class CupOfCoffee : Hotdrink, ICup
    {
        private string BeanType = "Арабика";
        public string beanType
        {
            get
            {
                return BeanType;
            }
            set
            {
                if (value == "Арабика" || value == "Робуста")
                    BeanType = value;
                else
                    Console.WriteLine("Такого вида зерен не существует");
            }
        }
        private string type = "Капучино";
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if(value == "Капучино" || value == "Эспрессо" ||  value == "Латте" || value == "Раф" || value == "Американо" || value == "Гляссе")
                {
                    type = value;
                }    
                else
                {
                    Console.WriteLine("Такого вида кофе у нас нет.");
                }
            }
        }

        private double capacity = 0.2;
        public double Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value == 0.2 || value == 0.3)
                    capacity = value;
                else
                    throw new Exception("Ёмкость может быть только 0.2 или 0.3");
            }
        }
        bool filled = true;
        bool dirty = false;
        public string Refill()
        {
            if (!dirty && !filled)
            {
                filled = true;
                dirty = true;
            }
            else if (filled == true)
            {
                throw new Exception("Кружка полная.");
            }
            else
            {
                throw new Exception("Кружка грязная.");
            }
            return "Кружка заполнена!";
        }
        public string Wash()
        {
            filled = false;
            dirty = false;
            return "Кружка помыта!";
        }
    }
}
