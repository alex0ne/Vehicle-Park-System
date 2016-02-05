using VehicleParkSystem.Core;

namespace VehicleParkSystem
{
    using System.Globalization;
    using System.Threading;

    static class VehicleParkSystemMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var engine = new Engine();
            engine.Run();
        }
    }
}