using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            MyComplex A = new MyComplex(1, 1), B = new MyComplex(), C = new MyComplex(1), D = new MyComplex();
            C = A + B;
            C = A + 10.5;
            C = 10.5 + A;
            D = -C;
            C = A + B + C + D;
            C = A = B = C;
            // Введення А 
            D.InputFromTerminal();
            // Виведення комплексного числа в форматі 5+7 *Im або 5-7*Im 
            Console.WriteLine($"A = {A}, B = {B}, C = {C}, D = {D}");
            // Виведення комплексного числа в форматі 
            Console.WriteLine($"Re(A) = {A["realValue"]}, Im(A) = {A["imageValue"]}");
            Console.ReadLine();
        }
    }
}
