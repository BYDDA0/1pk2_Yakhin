namespace Task_04_06
{
    internal class Program
    {/*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
        модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
        двух равных по модулю. В полученном массиве найти наибольшее по модулю число.*/
        static void Main(string[] args)
        {
            int a, max = 0;

            Console.WriteLine("Введите количество чисел в массиве");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ошибка ввода");
            Console.Clear();
            Random rnd = new Random();
            int[] numbers = new int[a];
            for (int i = 0; i < a; ++i)
            {
                int mas;
                bool uni;
                do               //проверяем на уникальность
                {
                    mas = rnd.Next(-a, a + 1);
                    uni = true;
                    for (int j = 0; j < i; ++j)
                    {
                        if (Math.Abs(numbers[j]) == Math.Abs(mas) || numbers[j] == mas)
                        {
                            uni = false;
                            break;

                        }
                    }
                } while (!uni);
                numbers[i] = mas;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a; ++i) //макс по модулю
            {
                if (Math.Abs(max) < Math.Abs(numbers[i]))
                {
                    max = Math.Abs(numbers[i]);
                }
            }
            Console.WriteLine($"Максимальное по модулю число в массиве - {max}");
            
        }
    }
}
