using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP1_Lab2_4
{
    /// \author Viktor Revkov
    /// <summary>
    /// \brief Основной класс Atelie содержит информацию об ателье и использует вспомогательный класс Cloth.
    /// </summary>
    /// \image html ADTGMuqgMFk.jpg
    /// \callergraph

    public class Atelie
    {
        private String name; // название ателье
        private Cloth i1 = new Cloth(); // 1 одежда
        private Cloth i2 = new Cloth(); // 2 одежда 
        private Cloth i3 = new Cloth(); // 3 одежда
        private int AmountI1, AmountI2, AmountI3, CostDopI; // количество изделий для первой, второй и третьей одежды и стоимость дополнительных аксессуаров
        /// <summary>
        /// Метод инициализации данных ателье с одеждой в количестве 3 штук
        /// </summary>
        /// <param name="P1">Цена ткани первой одежды</param>
        /// <param name="A1">Количество ткани первой одежды</param>
        /// <param name="P2">Цена ткани второй одежды</param>
        /// <param name="A2">Количество ткани первой одежды</param>
        /// <param name="P3">Цена ткани третьей одежды</param>
        /// <param name="A3">Количество ткани первой одежды</param>
        /// <param name="AI1">Количество изделий для первой одежды</param>
        /// <param name="AI2">Количество изделий для второй одежды</param>
        /// <param name="AI3">Количество изделий для третьей одежды</param>
        /// <param name="C">Стоимость дополнительных аксессуаров</param>
        public void Init(float P1, int A1, float P2, int A2, float P3, int A3, int AI1, int AI2, int AI3, int C)
        {
            i1.Init(P1, A1); // 1 одежда
            i2.Init(P2, A2); // 2 одежда
            i3.Init(P3, A3); // 3 одежда
            AmountI1 = AI1; // Количество изделий первой одежды
            AmountI2 = AI2; // Количество изделий второй одежды
            AmountI3 = AI3; // Количество изделий третьей одежды
            CostDopI = C; // Стоимость дополнительных аксессуаров
        }
        /// <summary>
        /// Метод чтения с консоли данных ателье с одеждой в количестве 3 штук
        /// </summary>
        public void Read() // чтение данных с консоли об одежде и количестве дополнительных аксессуаров
        {
            i1.Read();
            Console.Write("Введите количество изделий: ");
            AmountI1 = Convert.ToInt32(Console.ReadLine());
            i2.Read();
            Console.Write("Введите количество изделий: ");
            AmountI2 = Convert.ToInt32(Console.ReadLine());
            i3.Read();
            Console.Write("Введите количество изделий: ");
            AmountI3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену дополнительных аксессуаров: ");
            CostDopI = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Метод отображения в консоли данных об ателье с одеждой в количестве 3 штук
        /// </summary>
        public void Display() // вывод данных об ателье и стоимость дополнительных аксессуаров
        {
            Console.Write("Имя продукта: " + name + "\nИзделие 1: ");
            i1.Display();
            Console.Write("Цена первого изделия: " + i1.Cost() + "\n");
            Console.Write("Количество изделий: " + AmountI1);
            Console.Write("\n\nИзделие 2: ");
            i2.Display();
            Console.Write("Цена второго изделия: " + i2.Cost() + "\n");
            Console.Write("Количество изделий: " + AmountI2);
            Console.Write("\n\nИзделие 3: ");
            i3.Display();
            Console.Write("Цена третьего изделия: " + i3.Cost() + "\n");
            Console.Write("Количество изделий: " + AmountI3);
            Console.Write("\n\nСтоимость дополнительных аксессуаров: " + CostDopI + "\n");
        }
        /// <summary>
        /// Метод инициализации имени ателье путём чтения с консоли данных введённой информации
        /// </summary>
        public void Name()
        {
            name = Console.ReadLine();
        }
        /// <summary>
        /// Метод подсчёта стоимости всей одежды с учётом дополнительных аксессуаров
        /// </summary>
        /// <returns>
        /// Метод использует поля класса Cloth и его метод Cost(),
        /// вследствие чего возвращает стоимость всех изделий, что высчитывается по формуле:
        /// $$Total Cost = Cost_{1} * AmountI1 + Cost_{2} * AmountI1 + Cost_{3} * AmountI1 + CostDopI$$
        /// </returns>
        public double CostWithDop() // стоимость всех изделий с учётом дополнительных аксессуаров
        {
            return i1.Cost() * AmountI1 + i2.Cost() * AmountI2 + i3.Cost() * AmountI3 + CostDopI;
        }
        /// <summary>
        /// Метод нахождения самого дорого изделия
        /// </summary>
        /// <returns>
        /// Метод возвращает поле от вспомогательного класса, которое имеет наибольшую стоимость
        /// </returns>
        public Cloth Expensive() // самое дорогое изделие
        {
            double a = i1.Cost();
            double b = i2.Cost();
            double c = i3.Cost();
            if (a >= b && a >= c) { return i1; } // если первая одежда самая дорогая
            else if (b >= a && b >= c) { return i2; } // если вторая одежда самая дорогая
            else return i3; // иначе третья одежда самая дорогая
        }
    }
}
