namespace VehicleParkSystem.Vehicles
{
    public class Motorbike : Vehicle
    {
        public Motorbike(string licensePlate, string owner, int reservedHours)
            : base(licensePlate, owner, reservedHours, 1.35M, 3M)
        {
        }
    }
}