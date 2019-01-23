using System;
using Standard_Vessel;
using speedInterface;

namespace Standard_Vessel
{
    public class Submarine : Vessel
    {
        private int MAX_DEPTH;

        public Submarine(string name, string year, string type, Speed maxSpeed, int maxDepth): base (name, year, type, maxSpeed)
        {
            this.MAX_DEPTH = maxDepth;
        }
        
        public int GetMaxDepth
        {
            get { return this.MAX_DEPTH; }
        } 

        public override string GetVesselInfo()
        {
            return base.GetVesselInfo() + "\nMax depth: " + this.GetMaxDepth + " meters";
        }
    }
}
