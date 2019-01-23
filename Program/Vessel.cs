using System;
using System.Globalization;
using speedInterface;

namespace Standard_Vessel
{
    public class Vessel
    {
        private string Name;
        private string YearBuilt;
        public string Type {get; set; }
        public Speed MaxSpeed {get; set; }

        public Vessel(string name, string year, string type, Speed maxSpeed)
        {
            try
            {
                SetName(name);
                SetYearBuilt(year);
            }
            catch(OldShipException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            
            this.Type = type;
            this.MaxSpeed = maxSpeed;
        }
        public string SetName(string name)
        {             
            if(name == null)
                throw new NullReferenceException("Vessels name can't be null");
            else
                return this.Name = name;
        }

        public string SetYearBuilt(string year)
        {
            int Year;
            Int32.TryParse(year, out Year);

            if (Year < 1999)
                throw new OldShipException ($"{this.Name} over 20 years old.");
            else
                return this.YearBuilt = year;
        }

        public string GetName() 
        {
            return Name;
        }

        public string GetYearBuilt()
        {
            return this.YearBuilt;
        }

        public override string ToString() 
        {
            return $"Vessel: {Name}";
        }

        public virtual string GetVesselInfo()
        {
            return $"\nVessel info:\nName: {this.GetName()}\nType: {this.Type}\nYear build: {this.GetYearBuilt()}\nMax speed: {this.MaxSpeed.ToString("MS")}";
        }        

        public class OldShipException : Exception
        {         
            public OldShipException():base(){
            }   
            public OldShipException (string message): base(message){
            }
        }
    }
}
