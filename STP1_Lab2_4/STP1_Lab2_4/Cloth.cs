using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP1_Lab2_4
{
    /// \author Viktor Revkov
    /// <summary>
    /// \brief Вспомогательный класс Cloth содержит информацию об одежде в ателье
    /// </summary>
    public class Cloth
    {
        private int Amount; // количество ткани
        private double Price; // цена ткани
        /// <summary>
        /// Метод инициализации данных об одежде
        /// </summary>
        /// <param name="P">Цена ткани</param>
        /// <param name="A">Количество ткани</param>
        /// \callergraph
        public void Init(float P, int A) // инициализация данных одежды
        {
            Price = P; // цена ткани
            Amount = A; // количество ткани
        }
        /// <summary>
        /// Метод чтения с консоли данных об одежде
        /// </summary>
        public void Read() // чтение данных об одежде с консоли
        {
            Console.Write("\nВведите цену и количество: ");
            string s = "";
            s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Price = Convert.ToDouble(s1[0]);
            Amount = Convert.ToInt32(s1[1]);
        }
        /// <summary>
        /// Метод отображения в консоли данных об одежде
        /// </summary>
        public void Display() // вывод данных об одежде
        {
            Console.Write("Цена ткани: " + Price + "\nКоличество ткани: " + Amount + "\n");
        }
        /// <summary>
        /// Метод подсчёта стоимости одежды
        /// </summary>
        /// <returns>
        /// Метод использует поля класса Amount и Price и высчитывает
        /// стоимость конкретной одежды по формуле
        /// $$Cost = Price * Amount$$
        /// </returns>
        public double Cost() // подсчёт стоимости одежды
        {
            return Price * Amount;
        }
    }
}
