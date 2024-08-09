using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для работы с многоугольником
    /// </summary>
    class Polygon : Figure
    {
      
        /// <summary>
        /// лист для хранения всех вершин
        /// </summary>
        private List<Point> _polygonVertex;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="n">колличество вершин</param>
        public Polygon()
        {
            _polygonVertex = new List<Point>();
        }

       
        /// <summary>
        /// метод для ввода вершин
        /// </summary>
        public void Input(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ввод данных вершины ");
                Console.WriteLine($"Ввод X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ввод Y");
                int y = Convert.ToInt32(Console.ReadLine());

                _polygonVertex.Add(new Point(x,y));
            }

            _polygonVertex.Add(_polygonVertex[0]);
        }

        /// <summary>
        /// метод вычисления периметра многоугольника
        /// </summary>
        /// <returns>возращает периметр многоугольника</returns>
        public override double P()
        {
            double p = 0;

            for(int i = 0; i < _polygonVertex.Count-1; i++)
            {
             p += MathGeometry.DistanceSquared(_polygonVertex[i],_polygonVertex[i+1]);
            }
            return p;
        }

        /// <summary>
        /// метод вычисления площадь многоугольника
        /// </summary>
        /// <returns>возращает площадь многоугольника</returns>
        public override double S()
        {
            double s = 0;
            int front = 1;

            for (int i = 1; i < _polygonVertex.Count - 2; i++)
            {  
                for(int z = 1; z < _polygonVertex.Count; z++)
                {
                    if(front == i)
                    {
                        front++; 
                        Triangle triangle = new Triangle(_polygonVertex[0],_polygonVertex[i],_polygonVertex[i + 1]);
                      s += triangle.S();
                        break;
                    }      
                }          
            }
            return s;
        }

        /// <summary>
        /// метод для преобразование в строку
        /// </summary>
        /// <returns>строку</returns>
        public override string ToString()
        {
            string str = "Многоугольник \n";

            foreach (var el in _polygonVertex)
            {
               str += el.ToString() + "\n";
            }
            return str;
        }
    }
}
