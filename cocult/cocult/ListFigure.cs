using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// специализированный класс для работы с типом фигуры
    /// </summary>
    class ListFigure<T> : List<T> where T : Figure
    {
        /// <summary>
        /// метод расширения для класса лист ,который вычисляет сумму площадей определенного типа фигуры
        /// </summary>
        /// <param name="list">список с которым мы работаем</param>
        /// <returns>возращает сумму всех площадей</returns>
        public double PType<U>() where U : T
        {
            return this.OfType<U>().Sum(f => f.P());
        }

        /// <summary>
        /// метод расширения для класса лист ,который вычисляет сумму периметров определенного типа фигуры
        /// </summary>
        /// <param name="list">список с которым мы работаем</param>
        /// <returns>возращает сумму всех периметров</returns>
        public double SType<U>() where U : T
        {
            return this.OfType<U>().Sum(f => f.S());
        }

        /// <summary>
        /// метод расширения для класса лист ,который его переопределяет в строку
        /// </summary>
        /// <param name="list">список с которым мы работаем</param>
        /// <returns>возращает строку содержмого</returns>
        //public string ToString<U>() where U : T
        //{
        //    return this.Join("\n", this.OfType<U>().OrderBy(f => f.()));
        //}
    }
}
