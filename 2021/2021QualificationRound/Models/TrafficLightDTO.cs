using System;
using System.Collections.Generic;

namespace trafficlightProblem.Models
{
    public class TrafficLightDTO
    {
        public int SimulationTime { get; set; }
        public int IntersectionsCount { get; set; }
        public int StreetsCount { get; set; }
        public int CarsCount { get; set; }
        public int ScoresPoints { get; set; }
        public List<Street> Streets { get; set; } = new List<Street>();
        public List<Car> Cars { get; set; } = new List<Car>();
    }
    public class Street
    {
        public string StreetName { get; set; }
        public int StartIntersection { get; set; }
        public int EndIntersection { get; set; }
        public int TimeToTravel { get; set; }
    }

    public class Car
    {
        public List<string> CarRoute { get; set; }
        public int RountCount { get; set; }
    }
}