using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public class Analaizer
    {
        /// <summary>
        /// позиція виразу, на якій знайдена синтаксична помилка (у випадку відловлення на рівні виконання - не визначається)
        /// </summary>
        private static int erposition = 0;
        /// <summary> /// Вхідний вираз /// </summary>
        public static string expression = "";
    }
}
