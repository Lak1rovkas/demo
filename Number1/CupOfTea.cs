using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class CupOfTea : Hotdrink, ICup
    {
        private string LeafType = "Ломаный";
        public string leafType
        {
            get
            {
                return LeafType;
            }
            set
            {
                if(value == "Цельнолистовой" || value == "Ломаный" || value == "Высевка" || value == "Чайная крошка")
                {
                    LeafType = value;
                }
                else
                {
                    Console.WriteLine("Такого вида чайных листьев не существует");
                }
            }
        }

        private string type = "Чёрный";
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "Чёрный" || value == "Зелёный" || value == "Жёлтый" || value == "Белый" || value == "Красный")
                {
                    type = value;
                }
                else
                {
                    Console.WriteLine("Такого вида чая не существует");
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
