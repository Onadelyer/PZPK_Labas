using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    public class Airplane
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public double MaxAltitude { get; set; }

        public Airplane(string brand, string model, double maxSpeed, double maxAltitude)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            MaxAltitude = maxAltitude;
        }

        public double Cost()
        {
            return MaxSpeed * 1000 + MaxAltitude * 100;
        }

        public string Info()
        {
            return $"Airplane: {Brand} {Model}, \nMax speed: {MaxSpeed} km/h, \nMax altitude: {MaxAltitude} m, \nCost: {Cost()}";
        }
    }

    public class Bomber : Airplane
    {
        public string PilotName { get; set; }

        public Bomber(string brand, string model, double maxSpeed, double maxAltitude, string pilotName)
            : base(brand, model, maxSpeed, maxAltitude)
        {
            PilotName = pilotName;
        }

        public new double Cost()
        {
            return base.Cost() * 2;
        }

        public new string Info()
        {
            return $"Bomber: {Brand} {Model}, \nMax speed: {MaxSpeed} km/h, \nMax altitude: {MaxAltitude} m, \nCost: {Cost()}, \nPilot: {PilotName}";
        }
    }

    public class Fighter : Airplane
    {
        public string MissionGroup { get; set; }

        public Fighter(string brand, string model, double maxSpeed, double maxAltitude, string missionGroup)
            : base(brand, model, maxSpeed, maxAltitude)
        {
            MissionGroup = missionGroup;
        }

        public new double Cost()
        {
            return base.Cost() * 3;
        }

        public new string Info()
        {
            return $"Fighter: {Brand} {Model}, \nMax speed: {MaxSpeed} km/h, \nMax altitude: {MaxAltitude} m, \nCost: {Cost()}, \nMission group: {MissionGroup}";
        }
    }
}
