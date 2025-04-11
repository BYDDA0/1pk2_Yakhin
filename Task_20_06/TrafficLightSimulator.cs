using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }

    class TrafficLightSimulator
    {
        private TrafficLightColor currentColor;
        private bool isRunning = true;
        private bool manualMode = false;
        private readonly object lockObj = new object();

        public void Run()
        {
            // Переключение светофора
            Console.WriteLine("Симулятор светофора запущен");
            Console.WriteLine("Автоматический режим (переключение каждые 3 секунды)");
            Console.WriteLine("Нажмите:");
            Console.WriteLine("  R - переключить на красный");
            Console.WriteLine("  Y - переключить на желтый");
            Console.WriteLine("  G - переключить на зеленый");
            Console.WriteLine("  A - вернуться в автоматический режим");
            Console.WriteLine("  Q - выход\n");

            currentColor = TrafficLightColor.Red;
            PrintCurrentColor();

            // Запускаем автоматическое переключение 
            var autoThread = new Thread(AutoSwitch);
            autoThread.Start();

            // подсоединение клавиш к цветам
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.R:
                            SetColorManually(TrafficLightColor.Red);
                            break;
                        case ConsoleKey.Y:
                            SetColorManually(TrafficLightColor.Yellow);
                            break;
                        case ConsoleKey.G:
                            SetColorManually(TrafficLightColor.Green);
                            break;
                        case ConsoleKey.A:
                            ReturnToAutoMode();
                            break;
                        case ConsoleKey.Q:
                            Stop();
                            break;
                    }
                }
            }

            autoThread.Join();
        }

        private void AutoSwitch()
        {
            while (isRunning)
            {
                lock (lockObj)
                {
                    if (!manualMode)
                    {
                        // Последовательность светофора
                        switch (currentColor)
                        {
                            case TrafficLightColor.Red:
                                currentColor = TrafficLightColor.Yellow;
                                break;
                            case TrafficLightColor.Yellow:
                                currentColor = TrafficLightColor.Green;
                                break;
                            case TrafficLightColor.Green:
                                currentColor = TrafficLightColor.Red;
                                break;
                        }
                        PrintCurrentColor();
                    }
                }
                Thread.Sleep(3000); // Задержка на  3 секунды
            }
        }
        // Ручное переключение
        private void SetColorManually(TrafficLightColor color)
        {
            lock (lockObj)
            {
                manualMode = true;
                currentColor = color;
                Console.WriteLine($"\nРучное переключение на {color}");
                PrintCurrentColor();
            }
        }

        private void ReturnToAutoMode()
        {
            lock (lockObj)
            {
                manualMode = false;
                Console.WriteLine("\nВозврат в автоматический режим");
            }
        }

        private void Stop()
        {
            isRunning = false;
            Console.WriteLine("\nСветофор выключен");
        }

        private void PrintCurrentColor()
        {
            // Текст цветной
            Console.ForegroundColor = currentColor switch
            {
                TrafficLightColor.Red => ConsoleColor.Red,
                TrafficLightColor.Yellow => ConsoleColor.Yellow,
                TrafficLightColor.Green => ConsoleColor.Green,
                _ => ConsoleColor.White
            };

            Console.WriteLine($"[{DateTime.Now:T}] Текущий цвет: {currentColor}");
            Console.ResetColor();
        }
    }
}