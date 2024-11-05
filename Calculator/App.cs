using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class App
    {
        public void Start()
        {
            var calculator = new Calculator<int>();

            while (true)
            {
                try
                {
                    Console.WriteLine("Make your calculation below: ");
                    Console.WriteLine(calculator.ParseAndCalculate(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
