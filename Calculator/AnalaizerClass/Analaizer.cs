using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcClas;
namespace AnalaizerClass
{
    public class Analaizer
    {
        /// позиція виразу, на якій знайдена синтаксична помилка 
        /// (у випадку відловлення на рівні виконання - не визначається)
        private static int erposition = 0;
        /// Вхідний вираз
        public static string expression = null;
        /// Показує, чи є необхідність у виведенні повідомлень про помилки. 
        /// У разі консольного запуску програми це значення - false.
        public static bool ShowMessage
        {
            get { return Calculator.ShowMessage; }
            set { Calculator.ShowMessage = value; }
        }
        public static bool CheckCurrency()
        {
            // у випадку, якщо в кінці виразу дужки виставлені правильно, а помилка вказує на останній символ,
            // то значить десь у виразі є дужка, яка була відкрита і не була закрита до кінця виразу
            int i = 0, par_depth = 0;
            for (; i < expression.Length; i++)
            {
                if (expression.Substring(i, 1) == "(")
                {
                    par_depth++;
                }
                else if (expression.Substring(i, 1) == ")")
                {
                    par_depth--;
                }
                // якщо глибина дужок більше 3, або закривається дужка без попереднього відкриття
                if (par_depth > 3 || par_depth < 0)
                {
                    erposition = i;
                    Calculator.writeError(ErrorCodes.WrongParenthesis, erposition);
                    return false;
                }
            }
            // якщо забрати цей додатковий if, то програма не видасть помилку, якщо не всі дужки були закриті
            if (par_depth != 0)
            {
                erposition = expression.Length - 1;
                Calculator.writeError(ErrorCodes.WrongParenthesis, erposition);
                return false;
            }
            return true;
        }
        /// Форматує вхідний вираз, виставляючи між операторами пропуски і видаляючи зайві,
        /// а також знаходить нерозпізнані оператори, стежить за кінцем рядка 
        /// а також знаходить помилки в кінці рядка
        /// <returns>кінцевий рядок або повідомлення про помилку, що починаються з спец. символу &</returns>
        public static string Format()
        {
            //провірка на дуже довгий вираз
            if (expression.Length > 65536)
            {
                Calculator.writeError(ErrorCodes.ExpressionCharLenError);
                return Calculator.lastError;
            }
            string formatted_expression = "";
            string single_char_operators = "()+-*/pm"; // m може бути початком mod, але mod провіряється раніше
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsNumber(expression, i))
                {
                  while (char.IsNumber(expression, i))
                    {
                        formatted_expression = formatted_expression + expression.Substring(i, 1);
                        i++;
                        if (i == expression.Length) break;
                       
                    }
                    i--;
                    formatted_expression = formatted_expression + " ";
                }
                else if (i < expression.Length - 2 && expression.Substring(i, 3) == "mod")
                {
                    formatted_expression = formatted_expression + "mod ";
                    i += 2; // перескакування через "mod" в операторі "mod"
                }
                else if (single_char_operators.Contains(expression.Substring(i, 1)))
                {
                    formatted_expression = formatted_expression + expression.Substring(i, 1) + " ";
                }
                else if (expression.Substring(i, 1) == " ")
                {
                    // пропуск всіх пробілів
                    while (expression.Substring(i, 1) == " ")
                    {
                        i++;
                    }
                    i--;
                }
                //перевірка коли Невідомий оператор
                else
                {
                    erposition = i;
                    Calculator.writeError(ErrorCodes.UnknownOperator, erposition);
                    return Calculator.lastError;
                }
            }
            // видалення пробілу в кінці виразу
            expression = formatted_expression.Substring(0, formatted_expression.Length - 1);
            //перевірка коли Максмальная довжина — 65536 символів.
            if (expression.Length > 65536)
            {
                Calculator.writeError(ErrorCodes.ExpressionCharLenError);
                return Calculator.lastError;
            }
            return expression;
        }
        /// Формує  масив, в якому розташовуються оператори і символи представлені в зворотному польському записі (без дужок)
        /// На цьому ж етапі відшукується решта всіх помилок (див. код). По суті - це компіляція.
        ///  <returns>массив зворотнього польського запису</returns>
        public static System.Collections.ArrayList CreateStack()
        {
            string[] expression_ar = expression.Split(' ');
            //перевірка коли Сумарна кількість чисел і операторів перевищує 30.
            if (expression_ar.Length > 30)
            {
                Calculator.writeError(ErrorCodes.TooManyElements);
                return null;
            }

            string item = "";
            System.Collections.ArrayList result = new System.Collections.ArrayList();
            Stack<string> stack = new Stack<string>();
            double _ = 0; // змінна просто потрібна для роботи double.TryParse
            for (int i = 0; i < expression_ar.Length; i++)
            {
                item = expression_ar[i];

                if (double.TryParse(item, out _))
                {
                    result.Add(item);
                }
                else if (item == "m" || item == "p")
                {
                    // якщо оператор знаходиться перед закриваючою дужкою
                    if (expression_ar[i + 1] == ")")
                    {
                        //перевірка коли Невірна синтаксична конструкція вхідного виразу
                        Calculator.writeError(ErrorCodes.SyntaxError);
                        return null;
                    }

                    // якщо два оператори підряд
                    if (expression_ar[i + 1] == "m" || expression_ar[i + 1] == "p")
                    {
                        erposition = i;
                        //перевірка коли Два підряд оператори
                        Calculator.writeError(ErrorCodes.DoubleOperator, erposition);
                        return null;
                    }

                    // якщо це кінець виразу
                    if (i == expression_ar.Length - 1)
                    {
                        //перевірка коли Незавершений вираз
                        Calculator.writeError(ErrorCodes.UnfinishedExpression);
                        return null;
                    }

                    stack.Push(item);
                }
                else if (item == "(")
                {
                    // якщо пусті дужки "()"
                    if (expression_ar[i + 1] == ")")
                    {
                        //перевірка коли Невірна синтаксична конструкція вхідного виразу
                        Calculator.writeError(ErrorCodes.SyntaxError);
                        return null;
                    }

                    // якщо бінарний оператор після відкриваючої дужки
                    if ("+-*/".Contains(expression_ar[i + 1]) || expression_ar[i + 1] == "mod")
                    {
                        //перевірка коли Невірна синтаксична конструкція вхідного виразу
                        Calculator.writeError(ErrorCodes.SyntaxError);
                        return null;
                    }

                    stack.Push(item);
                }
                else if (item == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        result.Add(stack.Pop());
                    }
                    
                    if (stack.Peek() == "(")
                    {
                        stack.Pop();
                    }
                }
                else if ("+-*/".Contains(item) || item == "mod")
                {
                    // якщо це кінець виразу
                    if (i == expression_ar.Length - 1)
                    {
                        //перевірка коли Незавершений вираз
                        Calculator.writeError(ErrorCodes.UnfinishedExpression);
                        return null;
                    }

                    // якщо перед бінарним оператором немає числа, або закриваючої дужки
                    if (i == 0 ||(expression_ar[i - 1] != ")" && !double.TryParse(expression_ar[i - 1], out _)))
                    {
                        //перевірка коли Невірна синтаксична конструкція вхідного виразу
                        Calculator.writeError(ErrorCodes.SyntaxError);
                        return null;
                    }

                    // якщо два бінарних оператори підряд
                    if ("+-*/".Contains(expression_ar[i + 1]) || expression_ar[i + 1] == "mod")
                    {
                        erposition = i;
                        //перевірка коли Два підряд оператори
                        Calculator.writeError(ErrorCodes.DoubleOperator, erposition);
                        MessageBox.Show(CalcClas.Calculator.lastError);
                        return null;
                    }

                    // якщо оператор знаходиться перед закриваючою дужкою
                    if (expression_ar[i + 1] == ")")
                    {
                        //перевірка коли Невірна синтаксична конструкція вхідного виразу
                        Calculator.writeError(ErrorCodes.SyntaxError);
                        return null;
                    }

                    while (stack.Count > 0 &&(stack.Peek() == "m" || stack.Peek() == "p"))
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Push(item);
                }
            }
            return result;
        }

        public static string RunEstimate(ArrayList rev_polish_notation)
        {
            Stack<string> stack = new Stack<string>();
            double _ = 0; // змінна просто потрібна для роботи int.TryParse
            double a = 0, b = 0;

            foreach (string item in rev_polish_notation)
            {
                if (ShowMessage)
                {
                    return Calculator.lastError;
                }

                if (double.TryParse(item, out _))
                {
                    stack.Push(item);
                }
                else if (item == "m" || item == "p")
                {
                    if (!double.TryParse(stack.Pop(), out a))
                    {
                        // чисто на всякий пожежний, хоча по ідеї мало би все спрацювати, якщо попередні провірки на помилки пройшли вдало
                        erposition = -9990; /// просто щоб легше було знайти нестиковку в коді відразу
                        Calculator.writeError(ErrorCodes.UnknownOperator, erposition);
                        return Calculator.lastError;
                    }

                    switch (item)
                    {
                        case "p":
                            stack.Push(Calculator.ABS(a).ToString());
                            break;
                        case "m":
                            stack.Push(Calculator.IABS(a).ToString());
                            break;
                        default:
                            erposition = -9991; /// просто щоб легше було знайти нестиковку в коді відразу
                            Calculator.writeError(ErrorCodes.UnknownOperator, erposition);
                            return Calculator.lastError;
                    }
                }
                else
                {
                    if (!double.TryParse(stack.Pop(), out a) ||
                        !double.TryParse(stack.Pop(), out b))
                    {
                        // чисто на всякий пожежний, хоча по ідеї мало би все спрацювати, якщо попередні провірки на помилки пройшли вдало
                        erposition = -9992; /// просто щоб легше було знайти нестиковку в коді відразу
                        Calculator.writeError(ErrorCodes.UnknownOperator, erposition);
                        return Calculator.lastError;
                    }
                    switch (item)
                    {
                        case "+":
                            stack.Push(Calculator.Add(a, b).ToString());
                            break;
                        case "-":
                            stack.Push(Calculator.Sub(a, b).ToString());
                            break;
                        case "*":
                            stack.Push(Calculator.Mult(a, b).ToString());
                            break;
                        case "/":
                            stack.Push(Calculator.Div(a, b).ToString());
                            break;
                        case "mod":
                            stack.Push(Calculator.Mod(b,a).ToString());
                            break;
                        default:
                            erposition = -9993; /// просто щоб легше було знайти нестиковку в коді відразу
                            Calculator.writeError(ErrorCodes.UnknownOperator, erposition);
                            return Calculator.lastError;
                    }
                }
            }

            if (stack.Count != 1)
            {
                erposition = -9994; /// просто щоб легше було знайти нестиковку в коді відразу
                Calculator.writeError(ErrorCodes.UnknownOperator, erposition);
                return Calculator.lastError;
            }

            return stack.Pop();
        }

        //public static string Estimate(string str)
        //{
        //    //CheckCurrency();
        //    //expression=Format(str);
        //    //expression = (CreateStack(expression)).ToString();
        //    //return RunEstimate(expression);

        //}
    }
}