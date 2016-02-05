using System;
using System.Globalization;
using System.Threading;
using VehicleParkSystem2;

namespace VehicleParkSystem
{
    static class vp
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var engine = new Mecanismo();
            engine.Runrunrunrunrun();
        }
    }
}