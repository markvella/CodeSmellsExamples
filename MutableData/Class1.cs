
using System;

namespace MutableData
{
    public class LocationDelta
    {
        public double XDelta { get; set; }
        public double YDelta { get; set; }

        internal double CalculateSpeed()
        {
            if (XDelta > YDelta)
                return XDelta / YDelta;
            else
                return YDelta / XDelta;
        }
    }
    public class Location
    {
        public double MaxX { get; set; }
        public double MaxY { get; set; }

        public double X { get; set; }
        public double Y { get; set; }
        public void Change(LocationDelta locationDelta)
        {
            if (MaxX < locationDelta.XDelta || locationDelta.XDelta<0)
            {
                locationDelta.XDelta = 0;
            }

            if (MaxY < locationDelta.YDelta || locationDelta.YDelta < 0)
            {
                locationDelta.YDelta = 0;
            }

            X += locationDelta.XDelta;
            Y += locationDelta.YDelta;
        }
    }

    public class MainClass
    {
        static Random rnd = new Random();
        Location location = new Location();
        public void NextLocation()
        {
            var xdelta = rnd.Next(-3, 3);
            var ydelta = rnd.Next(-3, 3);

            var locationDelta = new LocationDelta { XDelta=xdelta, YDelta=ydelta };
            location.Change(locationDelta);
            double speed = locationDelta.CalculateSpeed();

            Console.WriteLine($"Object moved to {location.X},{location.Y} at {speed}km/h");
        }
    }
}
