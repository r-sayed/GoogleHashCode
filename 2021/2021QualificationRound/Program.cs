using System.Collections.Generic;
using System.IO;
using System.Linq;
using trafficlightProblem.Models;

namespace trafficlightProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = File.ReadAllLines("./qualification_round_2021.in/a.txt").ToList();
            TrafficLightDTO trafficLightDTO = GetBasicInfo(lines);
            GetStreetInfo(lines, trafficLightDTO);
            GetCarInfo(lines, trafficLightDTO);
        }
        private static void GetCarInfo(List<string> lines, TrafficLightDTO trafficLightDTO)
        {
            for (int index = 0; index < trafficLightDTO.CarsCount; index++)
            {
                Car car = new Car();
                List<string> carInfo = lines[0].Split().ToList();
                car.RountCount = int.Parse(carInfo[0]);
                carInfo.RemoveAt(0);
                car.CarRoute = carInfo.ToList();
                trafficLightDTO.Cars.Add(car);
                lines.RemoveAt(0);
            }
        }

        private static void GetStreetInfo(List<string> lines, TrafficLightDTO trafficLightDTO)
        {
            for (int index = 0; index < trafficLightDTO.StreetsCount; index++)
            {
                Street street = new Street();
                List<string> streetInfo = lines[0].Split().ToList();
                street.StartIntersection = int.Parse(streetInfo[0]);
                street.EndIntersection = int.Parse(streetInfo[1]);
                street.StreetName = streetInfo[2];
                street.TimeToTravel = int.Parse(streetInfo[3]);
                lines.RemoveAt(0);
                trafficLightDTO.Streets.Add(street);
            }
        }

        private static TrafficLightDTO GetBasicInfo(List<string> lines)
        {
            List<string> basicInfo = lines[0].Split().ToList();
            TrafficLightDTO trafficLightDTO = new TrafficLightDTO();
            trafficLightDTO.SimulationTime = int.Parse(basicInfo[0]);
            trafficLightDTO.IntersectionsCount = int.Parse(basicInfo[1]);
            trafficLightDTO.StreetsCount = int.Parse(basicInfo[2]);
            trafficLightDTO.CarsCount = int.Parse(basicInfo[3]);
            trafficLightDTO.ScoresPoints = int.Parse(basicInfo[4]);
            lines.RemoveAt(0);
            return trafficLightDTO;
        }
    }
}
