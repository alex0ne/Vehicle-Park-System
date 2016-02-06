namespace VehicleParkSystem.Vehicles
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public abstract class Vehicle : IVehicle
    {
        private string licensePlate;
        private string owner;
        private decimal regularRate;
        private decimal overtimeRate;
        private int reservedHours;

        public Vehicle(string licensePlate, string owner, int reservedHours, decimal regularRate, decimal overtimeRate)
        {
            this.LicensePlate = licensePlate;
            this.Owner = owner;
            this.ReservedHours = reservedHours;
            this.RegularRate = regularRate;
            this.OvertimeRate = overtimeRate;
        }

        public string LicensePlate
        {
            get { return licensePlate; }

            set
            {
                if (!Regex.IsMatch(value, @"^[A-Z]{1}\d{3}[A-Z]{2,}$"))
                {
                    throw new ArgumentException("The license plate number is invalid.");
                }

                licensePlate = value;
            }
        }

        public string Owner
        {
            get { return owner; }

            set
            {
                if (value == null && value == "")
                {
                    throw new InvalidCastException("The owner is required.");
                }
                owner = value;
            }
        }

        public decimal RegularRate
        {
            get { return regularRate; }

            set
            {
                if (value < 0)
                {
                    throw new InvalidTimeZoneException(string.Format("The regular rate must be non-negative."));
                }

                regularRate = value;
            }
        }

        public decimal OvertimeRate
        {
            get { return overtimeRate; }

            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("The overtime rate must be non-negative."));
                }

                overtimeRate = value;
            }
        }

        public int ReservedHours
        {
            get { return reservedHours; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The reserved hours must be positive.");
                }

                reservedHours = value;
            }
        }

        public override string ToString()
        {
            var vehicle = new StringBuilder();

            vehicle.AppendFormat("{0} [{2}], owned by {1}", GetType().Name, LicensePlate, Owner);

            return vehicle.ToString();
        }
    }
}
