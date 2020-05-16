using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClas
{
    public enum ErrorCodes : int
    {
        WrongParenthesis = 1,
        UnknownOperator,
        SyntaxError,
        DoubleOperator,
        UnfinishedExpression,
        MinMaxError,
        ExpressionCharLenError,
        TooManyElements,
        ZeroDevisionError
    };

    public static class Calculator
    {
        /// Останнє повідомлення про помилку.

        private static string _lastError = "";
        ///  Поле і властивість для нього
        public static string lastError
        {
            get { return _lastError; }
            set { _lastError = value; }
        }

        public static bool ShowMessage = false;

        public static void writeError(ErrorCodes error_code, int i = 0)
        {
            ShowMessage = true;
            switch (error_code)
            {
                case ErrorCodes.WrongParenthesis:
                    lastError = $"Error 01 at {i} — Неправильна структура в дужках, помилка на  {i} символі.\n";
                    
                    break;
                case ErrorCodes.UnknownOperator:
                    lastError = $"Error 02 at {i} — Невідомий оператор на {i} символі.\n";
                    break;
                case ErrorCodes.SyntaxError:
                    lastError = "Error 03 — Невірна синтаксична конструкція вхідного виразу.\n";
                    break;
                case ErrorCodes.DoubleOperator:
                    lastError = $"Error 04 at {i} — Два підряд оператори на {i} символі.\n";
                    break;
                case ErrorCodes.UnfinishedExpression:
                    lastError = "Error 05 — Незавершений вираз.\n";
                    break;
                case ErrorCodes.MinMaxError:
                    lastError = "Error 06 — Дуже мале, або дуже велике значення числа для double. " +
                        "Числа мають бути в дiапазонi -1.7976931348623157E+308 до 1.7976931348623157E+308;.\n";
                    break;
                case ErrorCodes.ExpressionCharLenError:
                    lastError = "Error 07 — Дуже довгий вираз. Максмальная довжина — 65536 символів.\n";
                    break;
                case ErrorCodes.TooManyElements:
                    lastError = "Error 08 — Сумарна кількість чисел і операторів перевищує 30.\n";
                    break;
                case ErrorCodes.ZeroDevisionError:
                    lastError = "Error 09 – Помилка ділення на 0.\n";
                    break;
                default:
                    ShowMessage = false;
                    break;
            }
        }
        private static bool WithinMinMaxRange(params double[] arguments)
        {
            // повертає true, якщо всі числа в межах, або дорівнюють double.MinValue і double.MaxValue
            // крім false ще записує текст помилки
            foreach (double num in arguments)
            {
                if (num < double.MinValue || num > double.MaxValue)
                {
                    writeError(ErrorCodes.MinMaxError);
                    return false;
                }
            }
            return true;
        }
        public static double Add(double a, double b)
        {
            double result = a + b;
            if (!WithinMinMaxRange(a, b, result))
            {
                return -1;
            }
            return (double)result;
            
        }


        public static double Sub(double a, double b)
        {
            double result = a - b;
            if (!WithinMinMaxRange(a, b, result))
            {
                return -1;
            }
            return (double)result;
            
        }

        public static double Mult(double a, double b)
        {
            double result = a * b;
            if (!WithinMinMaxRange(a, b, result))
            {
                return -1;
            }
            return (double)result;
           
        }

        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                writeError(ErrorCodes.ZeroDevisionError);
                return -1;
            }
            double result = a / b;
            if (!WithinMinMaxRange(a, b, result))
            {
                return -1;
            }
            return (double)result;
        }
        public static double Mod(double a, double b)
        {
            // провірка ділення на нуль
            if (b == 0)
            {
                writeError(ErrorCodes.ZeroDevisionError);
                return -1;
            }
            // помилка 3 - спроба цілочисельного ділення на число менше 0
            if (a < 0 || b < 0)
            {
                writeError(ErrorCodes.SyntaxError);
                return -1;
            }
            double result = a % b;
            if (!WithinMinMaxRange(a, b, result))
            {
                return -1;
            }
            return (double)result;
        }
        // унарний плюс (символ «p»)
        public static double ABS(double a)
        {
            double result = a + 1;
            if (!WithinMinMaxRange(a, result))
            {
                return -1;
            }
            return (double)result;
        }

        // унарный минус (символ «m»)
        public static double IABS(double a)
        {
            double result = a - 1;
            if (!WithinMinMaxRange(a, result))
            {
                return -1;
            }
            return (double)result;
        }

    }
}
