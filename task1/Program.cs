namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task1
            int number = int.Parse(Console.ReadLine());
            int countDigit = 0;
            while (number > 0) ;
            {
                number /= 10;
                countDigit++;
            }
            Console.WriteLine(countDigit);
            #endregion end of task1
            #region task2

            //int count = (int)Math.Log10(number) + 1;
            //int r;
            //int sum = 0;
            //while (number != 0)
            //{
            //    r = number % 10;
            //    number /= 10;
            //    sum += r * count;
            //    count--;
            //}
            //int a = int.Parse(Console.ReadLine());
            //int b = 7;
            //Math.Pow(a, b);
            //Console.WriteLine(sum);
            #endregion end of task2
            #region task3
            //int number = int.Parse(Console.ReadLine());
            int count = (int)Math.Log10(number) + 1;
            int r;
            int sum = 0;
            while (number != 0)
            {
                r = number % 10;
                number /= 10;
                sum += r * count;
                count--;
            }
            int a = int.Parse(Console.ReadLine());
            int b = 7;
            Math.Pow(a, b);
            Console.WriteLine(sum);
            int number = int.Parse(Console.ReadLine());
            int count = (int)Math.Log10(number) + 1;
            if (count == 5)
            {
                int result = (400000 + number) * 10 + 2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Eded 5 reqemli olmalidir");
            }
            #endregion end of task3
            #region task4


            //int number = int.Parse(Console.ReadLine());
            //int r1, r2;
            //int tmp;
            //bool isDifferenceDigit = true;
            //while (number != 0)
            //{
            //    r1 = number % 10;
            //    number /= 10;
            //    tmp = number;
            //    while (tmp != 0)
            //    {
            //        r2 = number % 10;
            //        tmp /= 10;

            //        if (r1 == r2)
            //        {
            //            Console.WriteLine("Muxtelif reqemli deyil");
            //            isDifferenceDigit = false;
            //            break;
            //        }
            //    }
            //    if (!isDifferenceDigit)
            //        break;




            //}
            //if (isDifferenceDigit)
            //    Console.WriteLine("muxtelif reqemlidir");
            #endregion end of task4
            #region task5
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    if (Math.Sqrt(i) == (int)Math.Sqrt(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion end of task5
        }

    }
}  
           