namespace Task_04_10
{
    internal class Program
    {/*Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов
        отдельно для 1-ой и 2-ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
        использовать нельзя. 
        Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
        Результат: [4,0,-10,2,5,-7,9,2,7,-6]*/
        static void Main(string[] args)
        {
            int[] des = new int[10];
            int[] des2 = new int[10];
            Random random = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < des.Length; i++)
            {
                des[i] = random.Next(-10, 10);
                Console.Write(des[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("-------------------------\nРезультат реверса:");
            for (int i = 4; i >= 0; --i)
            {
                for (int j = 0; j < 5; j++)
                {
                    des2[j] = des[i];
                }
                Console.Write(des2[i] + " ");
            }
            for (int i = 9; i >= 5; --i)
            {
                for (int j = 5; j < 10; j++)
                {
                    des2[j] = des[i];
                }
                Console.Write(des2[i] + " ");
            }
            
        }
    }
}
