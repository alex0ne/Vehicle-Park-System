using System;
using VehicleParkSystem.Vehicles;

// Don't touch - I like it centered!
//interface IUserInterface { string ReadLine(); void WriteLine(string format, params string[] args); }

// TODO: Documente esta contrato
interface IVehiclePark
{
    // TODO: Documentar esse método
    string InsertCar(Car car, int sector, int placeNumber, DateTime startTime);
    // TODO: Documentar esse método
    string InsertMotorbike(Motorbike motorbike, int sector, int placeNumber, DateTime startTime);
    // TODO: Documentar esse método
    string InsertTruck(Truck truck, int sector, int placeNumber, DateTime startTime);
    // TODO: Documentar esse método
    string ExitVehicle(string licensePlate, DateTime endTime, decimal amountPaid);
    // TODO: Documentar esse método
    string GetStatus();
    // TODO: Documentar esse método
    string FindVehicle(string licensePlate);
    // TODO: Documentar esse método
    string FindVehiclesByOwner(string owner);
}