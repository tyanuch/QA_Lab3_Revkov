using STP1_Lab2_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP1_Lab2_4
{
    /// \author Viktor Revkov
    /// <summary>
    /// \brief Исполняемый класс программы с методом Main. Производится ввод данных и выводится соотвествующая информация
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Atelie y = new Atelie();
            Console.Write("Изделие: ");
            y.Name(); // ввод названия ателье
            y.Init((float)200.2, 12, (float)443.5, 43, 312, 21, 22, 33, 11, 1815); // инициализация данных ателье
            y.Display(); // вывод инициализированных данных об ателье
            y.Read(); // ввод данных об ателье
            y.Display(); // вывод введённых значений
            Cloth p = y.Expensive(); // самая дорогая одежда
            Console.Write("\nИтоговая цена всего: " + y.CostWithDop() + "\nСамая дорогая одежда:\n");
            p.Display(); // вывод информации о самой дорогой одежде
        }
    }
}


