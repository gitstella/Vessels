using System;
using Standard_Vessel;
using speedInterface;

namespace Standard_Vessel
{
    public class Tugboat : Vessel
    {
        private int MAX_FORCE;

        public Tugboat(string name, string year, string type, Speed maxSpeed, int maxForce): base (name, year, type, maxSpeed)
        {
            this.MAX_FORCE = maxForce;
        }
        
        public int GetMaxForce
        {
            get { return this.MAX_FORCE; }
        }

        public override string GetVesselInfo()
        {
            return base.GetVesselInfo() + "\nMax force: " + this.GetMaxForce + " tonn";
        }            
    }
}
