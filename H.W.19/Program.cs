using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._19
{
    class Comp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Core { get; set; }
        public double Freq { get; set; }
        public int RAM { get; set; }
        public int SizeHD { get; set; }
        public int RAMvideo { get; set; }
        public int Cost { get; set; }
        public int Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Comp> listComputer = new List<Comp>()
            {
                new Comp(){Id = 1001001,Name = "Игровой 1",Core = "AMD Rizen 9 3900X", Freq = 3.8,RAM = 32,RAMvideo = 16,SizeHD = 2000,Cost = 196000, Amount = 12},
                new Comp(){Id = 1001002,Name = "Игровой 2",Core = "intel core i9 12900K", Freq = 5.2,RAM = 32,RAMvideo = 16,SizeHD = 1000,Cost = 225000, Amount = 8},
                new Comp(){Id = 1001003,Name = "Рабочий 1",Core = "intel core i5 12600K", Freq = 4.9,RAM = 8,RAMvideo = 6,SizeHD = 512,Cost = 67000, Amount = 45},
                new Comp(){Id = 1001004,Name = "Рабочий 2",Core = "intel core i7 12600K", Freq = 5.0,RAM = 8,RAMvideo = 6,SizeHD = 1000,Cost = 75000, Amount = 32},
                new Comp(){Id = 1001005,Name = "Графический 1",Core = "intel core i7 12600K", Freq = 5.0,RAM = 16,RAMvideo = 8,SizeHD = 1000,Cost = 87000, Amount = 25},
                new Comp(){Id = 1001006,Name = "Графический 2",Core = "AMD Rizen 9 3900X", Freq = 3.8,RAM = 16,RAMvideo = 8,SizeHD = 1000,Cost = 92000, Amount = 27},
            };
            Console.WriteLine("Сортировка по цене:\n");
            List<Comp> compCostSort = listComputer.OrderBy(c => c.Cost).ToList();
            foreach (Comp c in compCostSort)
            {
                Console.WriteLine($"{c.Name} уникальный код: {c.Id}. Характеристики: Процессор {c.Core}; Частота процессора {c.Freq}; Объем памяти видеокарты {c.RAMvideo}; Объем ОЗУ {c.RAM} Цена:{c.Cost} ");
            }
            Console.WriteLine("\nСортировка по Процесору:\n");
            List<Comp> compCoreSort = listComputer.OrderBy(c => c.Core).ToList();
            foreach (Comp c in compCoreSort)
            {
                Console.WriteLine($"{c.Name} уникальный код: {c.Id}. Характеристики: Процессор {c.Core}; Частота процессора {c.Freq}; Объем памяти видеокарты {c.RAMvideo}; Объем ОЗУ {c.RAM} Цена:{c.Cost} ");
            }
            Console.WriteLine("\nДоступные процессоры: AMD Rizen 9 3900X, intel core i9 12900K,intel core i5 12600K,intel core i7 12600K");
            Console.WriteLine("\nДоступный объем ОЗУ: 8 ГБ, 16 ГБ, 32 ГБ");
            Console.WriteLine("Введите процессор");
            string compCore = Console.ReadLine();
            IEnumerable<Comp> comp = listComputer.Where(c => c.Core == compCore);
            foreach (Comp c in comp)
            {
             Console.WriteLine($"{c.Name} уникальный код: {c.Id}. Характеристики: Частота процессора {c.Freq}; Объем памяти видеокарты {c.RAMvideo}; Объем ОЗУ {c.RAM}\nЦена:{c.Cost}");
            }
            Console.WriteLine("Введите объем ОЗУ");
            int compRAM = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Comp> compRam = listComputer.Where(c => c.RAM == compRAM);
            foreach (Comp c in compRam)
            {
             Console.WriteLine($"{c.Name} уникальный код: {c.Id}. Характеристики: Процессор {c.Core}; Частота процессора {c.Freq}; Объем памяти видеокарты {c.RAMvideo};\nЦена:{c.Cost}");
            }

            Console.ReadKey();
        }
    }
}
