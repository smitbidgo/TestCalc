﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcClas;
namespace AnalaizerClass
{
    public class Analaizer
    {
        /// позиція виразу, на якій знайдена синтаксична помилка 
        /// (у випадку відловлення на рівні виконання - не визначається)
        private static int erposition = 0;
        /// Вхідний вираз
        public static string expression = "";
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
                return "& " + Calculator.lastError;
            }
            return expression;
        }
        public static System.Collections.ArrayList CreateStack(string input)
        {
            ArrayList output = null;
            return output;
        }

        public static string RunEstimate(string input)
        {
            return input;
        }

        public static string Estimate(string str)
        {
            CheckCurrency();
            //expression=Format(str);
            expression = (CreateStack(expression)).ToString();
            return RunEstimate(expression);

        }
    }
}