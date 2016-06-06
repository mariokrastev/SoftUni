using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Power
{
    static double PowerNumbers(double number, double power)
    {

        return Math.Pow(number, power);

    }
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());
        double result = PowerNumbers(number, power);
        Console.WriteLine(result);



    }
}
