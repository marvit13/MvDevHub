using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvPyramid
{
    class UserInterface
    {
        public void Run()
        {
            Console.WriteLine("Pyramid calculator");
            Console.WriteLine();

            var pCalculator = new PyramidCalculator();
            Console.WriteLine("Input data:");
            DisplayValues(pCalculator.GetInputDataSet());
            Console.WriteLine();

            pCalculator.CalculateEvenOddValues();
            Console.WriteLine("Result values (valid paths):");
            DisplayValues(pCalculator.ResultList, true);
            Console.WriteLine();

            Console.WriteLine("Best path for Max Sum (the answer):");
            DisplayValues(new List<List<int>> { pCalculator.GetMaxSumResult()}, true);
            Console.WriteLine();

            Console.WriteLine("Press Enter to exit..");
            Console.ReadLine();
        }

        private void DisplayValues(List<List<int>> values, bool sumValues = false)
        {
            Console.WriteLine();
            values.ForEach(group => {
                group.ForEach(val => { Console.Write($"{val} "); });
                if (sumValues) Console.Write($"  Sum: {group.Sum()}");
                Console.WriteLine();
            });
        }
    }
}
