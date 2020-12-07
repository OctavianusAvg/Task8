using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class MyComplex
    {
        private double Re, Im;

        public MyComplex(double InitRe = 0, double InitIm = 0)
        {
            Re = InitRe;
            Im = InitIm;
        }

        public static MyComplex operator +(MyComplex a, double b)
        {
            MyComplex num = new MyComplex();
            num.Re = a.Re + b;
            num.Im = a.Im;
            return num;
        }

        public static MyComplex operator +(double a, MyComplex b)
        {
            return b + a;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            MyComplex num = new MyComplex();
            num.Re = a.Re + b.Re;
            num.Im = a.Im + b.Im;
            return num;
        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            MyComplex num = new MyComplex();
            num.Re = a.Re - b.Re;
            num.Im = a.Im - b.Im;
            return num;
        }

        public static MyComplex operator -(MyComplex a)
        {
            MyComplex num = new MyComplex();
            num.Re = -1 * a.Re;
            num.Im = a.Im;
            return num;
        }
        // Варіант 4 
        // Операція "*" (A+Bi)*(C+Di) = (A*C) + (B*D)i
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            MyComplex num = new MyComplex();
            num.Re = a.Re * b.Re;
            num.Im = a.Im * b.Im;
            return num;
        }
        public void InputFromTerminal()
        {
            string s;
            double real, imagine;
            do
            {
                try
                {
                    Console.WriteLine("Введіть реальну частину");
                    real = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введіть уявну частину");
                    imagine = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Не правильні данні введенно. Повторення.");
                    continue;
                }
                Re = real;
                Im = imagine;
                break;
            } while (true);
        }
        public double this[string type]
        {
            get
            {
                if (type == "imageValue")
                {
                    return Im;
                }
                else
                {
                    return Re;
                }
            }
        }
        public override string ToString()
        {
            return $" {Re} + {Im}*Im або {Re} - {Im}*Im";
        }

    }
}
