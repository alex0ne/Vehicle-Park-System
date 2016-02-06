namespace VehicleParkSystem.Vehicles
{
    public class Car : Vehicle
    {
        public Car(string licensePlate, string owner, int reservedHours)
            : base(licensePlate, owner, reservedHours, 2M, 3.5M)
        {
        }
    }
}