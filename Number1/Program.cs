using System;

namespace Number1
{
    struct orders
    {

        public string itemname; //наименование

        public int unitCount; //число единиц

        public double unitCost; //стоимость одной единицы

        public orders(string itemname, int unitCount, double unitCost)
        {
            this.itemname = itemname;
            this.unitCost = unitCost;
            this.unitCount = unitCount;
        }

        public void Sum()
        {
            Console.WriteLine("Итоговая цена выбранного товара: " + unitCount * unitCost);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            orders order1 = new orders("Tea", 3, 300);
            Console.WriteLine();
            order1.Sum();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Выберите напиток: кофе <1> или чай <2>: ");
            int drink = int.Parse(Console.ReadLine());

            switch (drink)
            {
                case 1:
                    CupOfCoffee CupOfCoffee = new CupOfCoffee();
                    ProcessCup(CupOfCoffee);
                    break;
                
                case 2:
                    CupOfTea CupOfTea = new CupOfTea();
                    ProcessCup(CupOfTea);
                    break;
                
                default:
                    Console.WriteLine("Введите корректный номер");
                    break;
            }
            Console.ResetColor();
        }
        static void ProcessCup(object drink)
        {            
            if(drink.GetType() == typeof(CupOfCoffee))
            {
                CupOfCoffee CupOfCoffee = new CupOfCoffee();
                Console.WriteLine("Тип зерен: Арабика или Робуста <по умолч. арабика>");
                Console.WriteLine("Сахар: 0...5 <по умолч. 3>");
                Console.WriteLine("Молоко: 0...10 <по умолч. 3>");
                Console.WriteLine("Объём <мл>: 0,2 или 0,3 <по умолч. 0,3>");
                Console.WriteLine();
                Console.Write("Тип зерен: ");
                CupOfCoffee.beanType = Console.ReadLine();
                Console.Write("Сахар: ");
                CupOfCoffee.Sugar = int.Parse(Console.ReadLine());
                Console.WriteLine(CupOfCoffee.AddSugar());
                Console.Write("Молоко: ");
                CupOfCoffee.Milk = int.Parse(Console.ReadLine());
                Console.WriteLine(CupOfCoffee.AddMilk());
                Console.Write("Объём <мл>: ");
                CupOfCoffee.Capacity = double.Parse(Console.ReadLine());
                Console.WriteLine(CupOfCoffee.Drink());
                Console.WriteLine("Вымыть: " + CupOfCoffee.Wash());
                Console.WriteLine("Заполнить: " + CupOfCoffee.Refill());
                
            }
            else
            {
                CupOfTea CupOfTea = new CupOfTea();
                Console.WriteLine("Тип листьев чая: Цельнолистовой, Ломаный, Высевка, Чайная крошка <по умолч. Ломаный>");
                Console.WriteLine("Тип чая: Чёрный, Зелёный, Жёлтый, Красный, Белый  <по умолч. Чёрный>");
                Console.WriteLine("Сахар: 0...5 <по умолч. 3>");
                Console.WriteLine("Молоко: 0...10 <по умолч. 3>");
                Console.WriteLine("Объём <мл>: 0,2 или 0,3 <по умолч. 0,3>");
                Console.WriteLine();
                Console.Write("Тип листьев чая: ");
                CupOfTea.leafType = Console.ReadLine();
                Console.Write("Тип чая: ");
                CupOfTea.Type = Console.ReadLine();
                Console.Write("Сахар: ");
                CupOfTea.Sugar = int.Parse(Console.ReadLine());
                Console.WriteLine(CupOfTea.AddSugar());
                Console.Write("Молоко: ");
                CupOfTea.Milk = int.Parse(Console.ReadLine());
                Console.WriteLine(CupOfTea.AddMilk());
                Console.Write("Объём <мл>: ");
                CupOfTea.Capacity = double.Parse(Console.ReadLine());
                Console.WriteLine(CupOfTea.Drink());
                Console.WriteLine("Вымыть: " + CupOfTea.Wash());
                Console.WriteLine("Заполнить: " + CupOfTea.Refill());
            }
        }
    }
}
