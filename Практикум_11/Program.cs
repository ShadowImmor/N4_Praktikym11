using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Point
    {
        private int x, y;

        /// <summary>
        /// Свойство для чтения и записи координаты абциссы точки
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        /// <summary>
        /// Свойство для чтения и записи координаты ординаты точки
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        /// <summary>
        /// Свойство, умножающее координаты точки на скаляр 
        /// </summary>
        public int scalar
        {
            set
            {
                x *= value;
                y *= value;
            }
        }

        /// <summary>
        /// Конструктор, создающий точку с нулевыми координатами
        /// </summary>
        public Point()
        {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// Конструктор, создающий точку с заданными координатами
        /// </summary>
        /// <param name="xnew"> координата абциссы </param>
        /// <param name="ynew"> координата ординаты </param>
        public Point(int xnew, int ynew)
        {
            x = xnew;
            y = ynew;
        }

        /// <summary>
        ///  Метод, выводящий координаты точки на экран
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Координаты точки :x = {0}, y = {1}", x, y);
        }

        /// <summary>
        /// Метод, возвращающий расстояние от начала координат до точки
        /// </summary>
        /// <returns> возвращает расстояние от начала координат до точки</returns>
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// Метод, перемещающий точку на вектор (а,b)
        /// </summary>
        /// <param name="a"> a вектора </param>
        /// <param name="b"> b вектора </param>
        public void Move(int a, int b)
        {
            x += a;
            y += b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point0 = new Point();
            point0.Show();
            int x, y, a, b, scalar;
            bool prov;
            do
            {
                Console.Write("Введите координату x:");
                prov = int.TryParse(Console.ReadLine(), out x);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите координату y:");
                prov = int.TryParse(Console.ReadLine(), out y);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            Point point = new Point(x, y);
            point.Show();
            Console.WriteLine("Расстояние от начала координат до точки: " + point.Distance());
            do
            {
                Console.Write("Введите координату вектора, а:");
                prov = int.TryParse(Console.ReadLine(), out a);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите координату вектора, b:");
                prov = int.TryParse(Console.ReadLine(), out b);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            point.Move(a, b);
            point.Show();
            do
            {
                Console.Write("Введите скаляр:");
                prov = int.TryParse(Console.ReadLine(), out scalar);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            point.scalar = scalar;
            point.Show();
            Console.ReadLine();
        }
    }
}
