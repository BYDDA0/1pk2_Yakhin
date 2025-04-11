namespace Task_20_04
{
    internal class Program
    { /* Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
           * Car
           * Bike
           * Bus
           * Truck
           * Motorcycle
           * Храните список транспортных средств (можно просто List<VehicleType>).
           * Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
           * Реализуйте поиск по типу и вывод информации.*/
        static void Main(string[] args)
        { 
            Vehicle tracker = new Vehicle();

            // Добавление транспорта
            tracker.AddVehicle(VehicleType.Car);
            tracker.AddVehicle(VehicleType.Car);
            tracker.AddVehicle(VehicleType.Car);
            tracker.AddVehicle(VehicleType.Car);
            tracker.AddVehicle(VehicleType.Car);
            tracker.AddVehicle(VehicleType.Truck);
            tracker.AddVehicle(VehicleType.Bike);
            tracker.AddVehicle(VehicleType.Bike);
            tracker.AddVehicle(VehicleType.Car);
            tracker.AddVehicle(VehicleType.Bus);
            tracker.AddVehicle(VehicleType.Bus);
            tracker.AddVehicle(VehicleType.Bus);
            tracker.AddVehicle(VehicleType.Truck);
            tracker.AddVehicle(VehicleType.Truck);

            // Поиск грузовиков
            var trucks = tracker.FindVehicles(VehicleType.Truck);
            Console.WriteLine("\nКоличество грузовиков:");
            foreach (var truck in trucks)
            {
                Console.WriteLine(truck);
            }

            // Подсчет автомобилей
            int carCount = tracker.CountVehicles(VehicleType.Car);
            Console.WriteLine($"\nВсего авто: {carCount}");

            // Вывод 
            tracker.PrintStatistics();
        }
    }
}
    

