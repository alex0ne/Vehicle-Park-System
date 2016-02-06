namespace VehicleParkSystem.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(string licensePlate, string owner, int reservedHours)
            :base( licensePlate,  owner,  reservedHours, 4.75M, 6.2M)
        {
        }
    }
}