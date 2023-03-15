using System;

namespace se_kalkulator
{
    public class Calculator
    {

        public int Add(string input)
        {
            if (input == "") return 0;
            string[] element = input.Split(",");
            if (element.Length == 1) return int.Parse(element[0]);
            else return int.Parse(element[0]) + int.Parse(element[1]);
        }

        static void Main(string[] args)
        {
          
        }


    }
}
