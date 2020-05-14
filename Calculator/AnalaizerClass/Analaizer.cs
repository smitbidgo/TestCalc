using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public class Analaizer
    {

        private static int erposition = 0;

        public static string expression = "";

        public static bool ShowMessage = true;

        public static bool CheckCurrency(string str)
        {
            erposition = 0;
            int a = 0;int b = 0;
            foreach (var item in str)
            {
                if (("(".IndexOf(item) != -1)) a++;
                if ((")".IndexOf(item) != -1)) b++;
                erposition++;
            }
            if (a != b)
            {
                return false;
                throw new Exception($"Error in {erposition}");
            }
            
             else   return true;
        }
        public static string Format(string input)
        {
            string output = string.Empty;

            return output;
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
            CheckCurrency(str);
            expression=Format(str);
            expression=(CreateStack(expression)).ToString();
            return RunEstimate(expression);
            
        }
    }
}