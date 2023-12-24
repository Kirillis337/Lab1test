namespace Lab1test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { -4, 3, 2, -1, 4, 5, 1 };
            var str = string.Join(" ", mass);
            Console.WriteLine($"1. Массив на вход: {str}");
            Methods.Sort(mass);
            str = string.Join(" ", mass);
            Console.WriteLine($"Массив на выходе: {str}");
            string polistr = "Шалаш";
            Console.WriteLine($"2. на входе: {polistr}");
            Console.WriteLine($"На выходе: {Methods.Poli(polistr)}");
            Console.WriteLine($"3. На входе: 5");
            Console.WriteLine($"На выходе: {Methods.Factorial(5)}");
            Console.WriteLine($"4. На входе: 7");
            Console.WriteLine($"На выходе: {Methods.Fib(7)}");
            Console.WriteLine($"5. На входе: 4.3 в степени 2.2");
            Console.WriteLine($"На выходе:{Methods.Pow(4.3, 2.2)}");
            Console.WriteLine($"6. На входе:17");
            Console.WriteLine($"На выходе: {Methods.Simple(17)}");
            Console.ReadLine();
        }
    }
    public class Methods {
        static public int[] Sort(int[] mass)
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = 0; j < mass.Length - i - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int swap = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = swap;
                    }
                }
            }
            return mass;
        }
        static public bool Poli(string str)
        {
            str = str.Replace(" ", "");
            str = str.ToLower();
            char[] rvrs = str.ToCharArray();
            Array.Reverse(rvrs);
            string newstr = new string(rvrs);

            if (str.Equals(newstr))
            {
                return true;
            }
            else
                return false;
        }
        static public uint Factorial(uint n)
        {

            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }


        }

        static public uint Fib(uint n)
        {

            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    {
                        uint a = 0, b = 1, fib = 0;
                        for (int i = 2; i <= n; i++)
                        {
                            fib = a + b;
                            a = b;
                            b = fib;
                        }
                        return fib;
                    }
            }

        }
        static public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static public bool Simple(uint n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


    }
}