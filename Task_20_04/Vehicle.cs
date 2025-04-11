using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }
    internal class Vehicle
    {
        private List<VehicleType> vehicles = new List<VehicleType>();
        
        // Добавление транспортного средства
        public void AddVehicle(VehicleType type)
        {
            vehicles.Add(type);
            Console.WriteLine($"Добавлено: {type}");
        }

        // Подсчет транспорта определенного типа
        public int CountVehicles(VehicleType type)
        {
            return vehicles.Count(v => v == type);
        }

        // Поиск транспорта по типу
        public List<VehicleType> FindVehicles(VehicleType type)
        {
            return vehicles.Where(v => v == type).ToList();
        }

        // Вывод всей статистики
        public void PrintStatistics()
        {
            Console.WriteLine("\nСтатистика транспорта:");
            foreach (VehicleType type in Enum.GetValues(typeof(VehicleType)))
            {
                Console.WriteLine($"{type}: {CountVehicles(type)} шт.");
            }
        }

    }
}
