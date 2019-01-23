using System;
using System.Collections.Generic;
using Standard_Vessel;
using speedInterface;

namespace Dualog_Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            List<Vessel> vesselCollection = CreateVesselCollection();

            bool quitApplication = false;

            while (!quitApplication)
            {
                quitApplication = true;
                
                Console.WriteLine("\nPress 1 to print all vessel names");
                Console.WriteLine("Press 2 to print complete information about all vessels");
                Console.WriteLine("Press 'q' to exit");

                string userInput = Console.ReadLine();
                
                quitApplication = (string.Compare(userInput.ToLower(), "q") == 0) ? true : false;
                if (quitApplication)
                    break;

                if (userInput == "1")                
                    PrintAllVessels(vesselCollection);
                
                else if (userInput == "2")                
                    PrintAllInformation(vesselCollection);
                
                else
                    Console.WriteLine("Unknown command: {0}", userInput);            
            }
        }

        public static List<Vessel> CreateVesselCollection()
        {
            var vesselCollection = new List<Vessel>
            {              
                new Submarine("King Cod", "1960", "Submarine", new Speed(10), maxDepth: 110),
                new Submarine("McFishy", "2018", "Submarine", new Speed(25), maxDepth: 80),
                new Submarine("Turtle", "2004", "Submarine", new Speed(5),maxDepth: 150),
                
                new Tugboat("Mr. Strong", "2028", "Tugboat", new Speed(50), maxForce: 7000),
                new Tugboat("Viking", "2003", "Tugboat", new Speed(50), maxForce: 5000),
                new Tugboat("Falcken", "2011", "Tugboat", new Speed(50), maxForce: 11000),

                new Ferry("Kielferga", "2001", "Ferry", new Speed(100), passengers: 400),
                new Ferry("Lyngen ferga", "2000", "Ferry", new Speed(110), passengers: 150),
                new Ferry("Olderdalen ferge", "2001", "Ferry", new Speed(90), passengers: 40)
            };

            return vesselCollection;
        }

        public static void PrintAllVessels(List<Vessel> list)
        {
            foreach (Vessel boat in list)  
            {  
                Console.WriteLine(boat.ToString());
                boat.GetVesselInfo();
            } 
        }

        public static void PrintAllInformation(List<Vessel> list)
        {
            foreach (Vessel boat in list)            
            {
                Console.WriteLine(boat.GetVesselInfo());
            } 
        }     
    }
}
