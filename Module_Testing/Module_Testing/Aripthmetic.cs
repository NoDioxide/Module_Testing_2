using System;

namespace ArithmeticNS
{
    public class Arithmetic()
    {
        public double Summ(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Divide(double  a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль!");
            }
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            if (b != 0)
                return a * b;
            else
                throw new ArgumentException("Ошибка: умножение на ноль!");
        }

        public double Square(double a)
        {
            if (a != 0)
                return Math.Pow(a, 2);
            else
                throw new ArgumentException("Ошибка: возведение числа ноль!");
               
        }   
        
        class Program()
        {
            static void Main()
            {
                Arithmetic calc = new Arithmetic();

                double a, b;
                int choice;
                double res = 0;

                Console.WriteLine("             Арифметика");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Ошибка ввода! Пожалуйста, введите число.");
                    Console.Write("Введите первое число: ");
                }

                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Ошибка ввода! Пожалуйста, введите число.");
                    Console.Write("Введите второе число: ");
                }

                Console.WriteLine("\nВыберите одно действие:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Возведение в квадрат\n");
                Console.Write("И теперь введите номер операции: ");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Ошибка ввода! Пожалуйста, выберите число от 1 до 5.");
                    Console.Write("И теперь введите номер операции: ");
                }

                switch (choice)
                {
                    case 1:
                        res = calc.Summ(a, b);
                        break;
                    case 2:
                        res = calc.Minus(a, b);
                        break;
                    case 3:
                        res = calc.Multiply(a, b);
                        break;
                    case 4:
                        try
                        {
                            res = calc.Divide(a, b);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        break;
                    case 5:
                        res = calc.Square(a);
                        break;
                }
            }

            public void Debit(double a)
            {
                throw new NotImplementedException();
            }
        }
    }
}