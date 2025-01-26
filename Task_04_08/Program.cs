namespace Task_04_08
{
    internal class Program
    {/*Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
        которых равны.*/
        static void Main(string[] args)
        {
            int[] number = new int[50];
            Random rnd = new Random();
            int pary = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 11);
            }
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (number[i] == number[j])
                    {
                        pary++;
                    }
                }

            }
            Console.WriteLine($"Количество пар чисел - {pary}");
            
        }
    }
}
