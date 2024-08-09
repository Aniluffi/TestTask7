using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с треугольником
    /// </summary>
    class Triangle :Figure
    {

        /// <summary>
        /// поле хранящее сторону 1 треуголника
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// поле хранящее сторону 2 треуголника
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// поле хранящее сторону 3 треуголника
        /// </summary>
        public double C { get; set; }


        /// <summary>
        /// поле хранящее точку 1 треуголника
        /// </summary>
        public Point? Q { get; set; }
        /// <summary>
        /// поле хранящее точку 2 треуголника
        /// </summary>
        public Point? R { get; set; }
        /// <summary>
        /// поле хранящее точку 3 треуголника
        /// </summary>
        public Point? V { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод точки 1 треуголника </param>
        /// <param name="b">ввод точки 2 треуголника</param>
        /// <param name="c">ввод точки 3 треуголника</param>
        public Triangle(Point a, Point b, Point c)
        {
            Q = a;
            R = b;
            V = c;

            ConvertPoint();
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод стороны 1 треуголника </param>
        /// <param name="b">ввод стороны 2 треуголника</param>
        /// <param name="c">ввод стороны 3 треуголника</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private void ConvertPoint()
        {
            A = MathGeometry.DistanceSquared(Q,R);
            B = MathGeometry.DistanceSquared(R,V);
            C = MathGeometry.DistanceSquared(V,Q);
        }

        /// <summary>
        /// метод для вычисления площади треугольника
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            double p = MathGeometry.p(P());

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// метод для вычисления периметра треугольника
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {           
            return MathGeometry.TringleP(A,B,C);
        }

        /// <summary>
        /// метод для вывода информации о треугольнике
        /// </summary>
        public override string ToString()
        {
            return $"Треугольник \nA = {A}; \nB = {B}; \nC = {C}";
        }
    }
}
