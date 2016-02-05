namespace VehicleParkSystem.VehiclePark
{
    using System;

    class Layout
    {
        public int sectors;
        public int places_sec;

        public Layout(int numberOfSectors, int placesPerSector)
        {
            if (numberOfSectors <= 0)
            {
                throw new DivideByZeroException("The number of sectors must be positive.");
            }

            sectors = numberOfSectors;

            if (placesPerSector <= 0)
            {
                throw new DivideByZeroException("The number of places per sector must be positive.");
            }

            places_sec = placesPerSector;
        }
    }
}