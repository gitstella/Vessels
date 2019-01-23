using System;
using Standard_Vessel;
using speedInterface;

namespace Standard_Vessel
{
    public class Ferry : Vessel
    {
        public int Passengers {get; set;}

        public Ferry(string name, string year, string type, Speed maxSpeed, int passengers): base (name, year, type, maxSpeed)
        {            
            this.Passengers = passengers;
        }
        public override string GetVesselInfo()
        {
            return base.GetVesselInfo() + "\nPassengers: " + this.Passengers + " persons";
        }
    }
}
