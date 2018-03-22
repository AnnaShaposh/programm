using System;


namespace homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество цифр для расчета : ");
            Int32 arraySize= Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];

            int res = 0, sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите {0} число : ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("Введите значение К : ");
            int k = 0;
            k = Int32.Parse(Console.ReadLine());


        
            for (int j = 0; j < array.Length; j++)
            {

                if (array[j] < k)
                {
                    sum = sum + array[j];
                }


                if (array[j] > 0 && array[j] > k)
                {
                    sum = sum + array[j];
                    count++;
                }
            }
            

            if (k > 0)
            {
                array[0] = k;
            }
            else
            {
                array[0] = sum;
            }

            Console.WriteLine($"Первый элеммент массива после замены на К - {array[0]}");
            res = sum /count;


            Console.WriteLine("Cреднее арифметическое введеных чисел = " + res);
            Console.ReadKey();

            for (int i = 0; i < array.Length; i++)
            {
                
                Console.WriteLine($"Введите {i+1} элемент");
                
                try
                {
                    array[i] = Convert.ToInt32(Console.ReadLine()); 

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                
                Console.ReadLine();
                
            }


        }

        
    }
}
