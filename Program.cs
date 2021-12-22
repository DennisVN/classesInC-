using System;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace ClassesExercise {
    class Program {
        static void Main(string[] args){
            #region 
            // Create New Track Object (Instance of class) 
            // Track track1 = new Track();
            // Console.WriteLine(track1);

            // Track newTrack = new Track("Geen centen maar spullen", "Donnie ft. Frans Bauer");
            // Console.WriteLine(newTrack.Title + " - " + newTrack.Artist);
            
            // // Use parameters 
            // Track newTrack2 = new Track();
            // Console.WriteLine(newTrack2.Title + " - " + newTrack2.Artist);

            // Track newTrack3 = new Track();
            // newTrack3.Title = "Love is a battlefield";
            // newTrack3.Artist = "Kate Bush";
            // Console.WriteLine(newTrack3.Title + " - " + newTrack3.Artist);

            // Track newTrack4 = new Track();
            // newTrack4.Title = "Sigaretten";
            // Console.WriteLine(newTrack4.Title + " - " + newTrack4.Artist);
            #endregion

            Car car1 = new Car("Lambo");
            Car car2 = new Car("Golfke");
            Car car3 = new Car("Supra");
            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

            Console.ReadLine(); 
        }

    }

}
