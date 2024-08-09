using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class App
    {
        /// <summary>
        /// список для хранения данных о введенных фигурах 
        /// </summary>
        static ListFigure<Figure> listEnteredShapes = new ListFigure<Figure>();

        /// <summary>
        /// метод который запускает программу
        /// </summary>
        public void Run()
        {

            while (true)
            {
                Console.WriteLine("\n1 - квадрат, вводим сторону одну" +
                    "\n2 - прямоугольник, вводим два стороны" +
                    "\n3 - Круг, вводим радиус" +
                    "\n4 - треугольник, вводим три стороны" +
                    "\n5 - многоугольник" +
                    "\n6 - вывести сумму всех периметров" +
                    "\n7 - вывести сумму всех площадей" +
                    "\n8 - вывод списка всех фигур ранее введенных" +
                    "\n9 - вывод суммы площадей всех квадратов" +
                    "\n10 - вывод суммы площадей всех кругов" +
                    "\n11 - вывод суммы площадей всех прямоугольников" +
                    "\n12 - вывод суммы площадей всех треугольников" +
                    "\n13 - вывод суммы площадей всех многоугольников" +
                    "\n14 - вывод суммы периметров всех квадратов" +
                    "\n15 - вывод суммы периметров всех кругов" +
                    "\n16 - вывод суммы периметров всех прямоугольников" +
                    "\n17 - вывод суммы периметров всех треугольников" +
                    "\n18 - вывод суммы периметров всех многоугольников" +
                    "\n19 - выйти из программы\n");

                Console.WriteLine("Введите номер действия:");

                int numDeist = Convert.ToInt32(Console.ReadLine());

                switch (numDeist)
                {
                    case 1:

                        Console.Clear();

                        Console.WriteLine("Введите сторону квадрата:");

                        double side = Convert.ToDouble(Console.ReadLine());

                        Square sq = new Square(side);

                        listEnteredShapes.Add(sq);

                        Console.WriteLine("Вы желаете найти S(1) или P(2)");

                        int comand = Convert.ToInt32(Console.ReadLine());

                        if (comand == 1)
                        {
                            
                            Console.WriteLine($"S = {sq.S()}");
                        }
                        else if (comand == 2)
                        {
                            
                            Console.WriteLine($"P = {sq.P()}");
                        }

                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Введите сторону1 прямоугольника:");
                        double side1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите сторону2 прямоугольника:");
                        double side2 = Convert.ToDouble(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(side1, side2);

                        listEnteredShapes.Add(rectangle);

                        Console.WriteLine("Вы желаете найти S(1) или P(2)");

                        int comand1 = Convert.ToInt32(Console.ReadLine());

                        if (comand1 == 1)
                        {
                           
                            Console.WriteLine($"S = {rectangle.S()}");
                        }
                        else if (comand1 == 2)
                        {
                            
                            Console.WriteLine($"P = {rectangle.P()}");
                        }

                        break;
                    case 3:

                        Console.Clear();

                        Console.WriteLine("Введите радиус круга:");

                        double radius = Convert.ToDouble(Console.ReadLine());

                        Circle cir = new Circle(radius);

                        listEnteredShapes.Add(cir);

                        Console.WriteLine("Вы желаете найти S(1) или P(2)");

                        int comand2 = Convert.ToInt32(Console.ReadLine());

                        if (comand2 == 1)
                        {
                           
                            Console.WriteLine($"S = {cir.S()}");
                        }
                        else if (comand2 == 2)
                        {
                           
                            Console.WriteLine($"P = {cir.P()}");
                        }

                        break;
                    case 4:

                        Console.Clear();

                        Console.WriteLine("Введите сторону1 прямоугольника:");
                        double sideTring = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите сторону2 прямоугольника:");
                        double sideTring1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите сторону3 прямоугольника:");
                        double sideTring2 = Convert.ToDouble(Console.ReadLine());

                        Triangle tr = new Triangle(sideTring, sideTring1, sideTring2);

                        listEnteredShapes.Add(tr);

                        Console.WriteLine("Вы желаете найти S(1) или P(2)");

                        int comand3 = Convert.ToInt32(Console.ReadLine());

                        if (comand3 == 1)
                        {
                            
                            Console.WriteLine($"S = {tr.S()}");
                        }
                        else if (comand3 == 2)
                        {
                            
                            Console.WriteLine($"P = {tr.P()}");
                        }

                        break;
                    case 5:
                        Console.Clear();

                         

                        Polygon polygon = new Polygon();
                        
                        Console.Write("Введите колличество вершин: ");  
                        polygon.Input(Convert.ToInt32(Console.ReadLine()));

                        listEnteredShapes.Add(polygon);

                        Console.WriteLine("Вы желаете найти S(1) или P(2)");

                        int comand4 = Convert.ToInt32(Console.ReadLine());

                        if (comand4 == 1)
                        {

                            Console.WriteLine($"S = {polygon.S()}");
                        }
                        else if (comand4 == 2)
                        {

                            Console.WriteLine($"P = {polygon.P()}");
                        }

                        break;
                    case 6:
                        Console.Clear();

                        Console.WriteLine($"Сумма всех P = {PAll()}");
                        break;
                    case 7:

                        Console.Clear();

                        Console.WriteLine($"Сумма всех S = {SAll()}");
                        break;
                    case 8:
                        Console.Clear();

                        Console.WriteLine($"Список введенных фигур:\n");

                        foreach (Figure el in listEnteredShapes)
                        {
                            Console.WriteLine(el); 
                        }
                        break;

                    case 9:
                        Console.Clear();
                        Console.WriteLine($"Сумарная площадь квадратов - {listEnteredShapes.SType<Square>()}");
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine($"Сумарная площадь кругов - {listEnteredShapes.SType<Circle>()}");
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine($"Сумарная площадь прямоугольников - {listEnteredShapes.SType<Rectangle>()}");
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine($"Сумарная площадь треугольников - {listEnteredShapes.SType<Triangle>()}");
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine($"Сумарная площадь многоугольников - {listEnteredShapes.SType<Polygon>()}");
                        break;
                    case 14:
                        Console.Clear();
                        Console.WriteLine($"Сумарная периметров квадратов - {listEnteredShapes.PType<Square>()}");
                        break;
                    case 15:
                        Console.Clear();
                        Console.WriteLine($"Сумарная периметров кругов - {listEnteredShapes.PType<Circle>()}");
                        break;
                    case 16:
                        Console.Clear();
                        Console.WriteLine($"Сумарная периметров прямоугольников - {listEnteredShapes.PType<Rectangle>()}");
                        break;
                    case 17:
                        Console.Clear();
                        Console.WriteLine($"Сумарная периметров треугольников - {listEnteredShapes.PType<Triangle>()}");
                        break;
                    case 18:
                        Console.Clear();
                        Console.WriteLine($"Сумарная периметров многоугольников - {listEnteredShapes.PType<Polygon>()}");
                        break;
                    case 19:
                        Console.Clear();

                        Console.WriteLine($"Программа завершена!");
                        return;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка при вводе!\n"); break;

                }
            }
        }

        /// <summary>
        /// Мето для получения суммы всех площадей
        /// </summary>
        /// <returns>возращает сумму всех площадей</returns>
        public static double SAll()
        {
            double SAll = 0;

            foreach (Figure el in listEnteredShapes)
            {
              SAll += el.S();
            }

            return SAll;
        }

        /// <summary>
        /// метод для суммы всех периметров
        /// </summary>
        /// <returns>возращает сумму всех периметров</returns>
        public double PAll()
        {
            double PAll = 0;

            foreach (Figure el in listEnteredShapes)
            {
                PAll += el.P();
            }

            return PAll;
        }
    }
}
