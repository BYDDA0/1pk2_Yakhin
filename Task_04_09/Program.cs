namespace Task_04_09
{
    internal class Program
    {/*В массиве найти элементы, которые в нем встречаются только один раз, 
         * и вывести их на экран. То есть найти и
        вывести уникальные элементы массива. (LINQ использовать нельзя)*/
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите количество чисел в массиве");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Ошибка ввода");
            Console.Clear();
            int[] q = new int[a];
            Random rnd = new Random();
            for (int i = 0; i < q.Length; i++)
            {
                q[i] = rnd.Next(1, 10);
                Console.Write(q[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________\nУникальные элементы массива:");
            for (int i = 0; i < q.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < a; ++j)   //просматриваем массив полностью,
                                              //чиселка повт может быть в конце массива
                {
                    if (i != j & q[i] == q[j]) //уникальность
                    {
                        b = false;
                        break;
                    }
                }
                if (b == true)
                {
                    Console.WriteLine(q[i]);
                }
            }
        }
    }
}
