using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab2._1.Models
{
    public class CalcValues
    {
        /// <summary>
        /// Первое случайное значение
        /// </summary>
        public int FirstRandValue { get; set; }

        /// <summary>
        /// Второе случайное значение
        /// </summary>
        public int SecondRandValue { get; set; }

        /// <summary>
        /// Результат суммы случайных чисел
        /// </summary>
        public int Sum { get; set; }

        /// <summary>
        /// Результат разницы случайных чисел
        /// </summary>
        public int Difference { get; set; }

        /// <summary>
        /// Результат произведения случайных чисел
        /// </summary>
        public int Multiplication { get; set; }

        /// <summary>
        /// Результат частного случайных чисел
        /// </summary>
        public int? Division { get; set; }

    }
}
