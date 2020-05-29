using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        Point point = new Point();
        public Form1()
        {
            InitializeComponent();
            X.Maximum = int.MaxValue;
            X.Minimum = int.MinValue;
            Y.Maximum = int.MaxValue;
            Y.Minimum = int.MinValue;
            A.Maximum = int.MaxValue;
            A.Minimum = int.MinValue;
            B.Maximum = int.MaxValue;
            B.Minimum = int.MinValue;
            ShowCord.Text = point.Show();
        }

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
            /// Метод, возвращающий строку с координатами точки
            /// </summary>
            /// <returns> возвращает строку с координатами точки </returns>
            public string Show()
            {
               return "x = " + x + ", y = " + y;
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

        private void ZadCordbutton_Click(object sender, EventArgs e)
        {
            if (X.Value != (int)X.Value)
                X.Value = (int)X.Value;
            if (Y.Value != (int)Y.Value)
                Y.Value = (int)Y.Value;
            point.X = (int)X.Value;
            point.Y = (int)Y.Value;
            ShowCord.Text = point.Show();
        }

        private void PerVectorbutton_Click(object sender, EventArgs e)
        {
            if (A.Value != (int)A.Value)
                A.Value = (int)A.Value;
            if (B.Value != (int)B.Value)
                B.Value = (int)B.Value;
            point.Move((int)A.Value, (int)B.Value);
            ShowCord.Text = point.Show();
        }

        private void RasNachDoToch_Click(object sender, EventArgs e)
        {
            Ras.Text = point.Distance().ToString();
        }

        private void YmnScalar_Click(object sender, EventArgs e)
        {
            if (Scalar.Value != (int)Scalar.Value)
                Scalar.Value = (int)Scalar.Value;
            point.scalar = (int)Scalar.Value;
            ShowCord.Text = point.Show();
        }
    }
}
