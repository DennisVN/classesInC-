using System;
using System.Xml;
using Newtonsoft.Json.Linq;
// STATIC
// PUBLIC 
// PRIVATE
// VOID 

namespace ClassesExercise {
    class Program {
        static void Main(string[] args){
            #region Track
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
            
            #region Car
            Car car1 = new Car("Lambo", "Bright Orange");
            Car car2 = new Car("Golfke", "Matte Black");
            Car car3 = new Car("Supra", "Pearlescent Salmon Pink");
            Console.WriteLine("A " + car1.color + " " + car1.model + " has joined.");
            Console.WriteLine("A " + car2.color + " " + car2.model + " has joined.");
            Console.WriteLine("A " + car3.color + " " + car3.model + " has joined.");
            #endregion 
            
            #region Animals
            // printAnimal(new Snake("boopsnoot"));
            // printAnimal(new Dog("doggo"));
            // printAnimal(new Goose("mad bird"));
            #endregion
            Console.ReadLine(); 
        }

        
        public static void printAnimal(IAnimal animal)
        {
            Console.WriteLine(animal.name + " has " + animal.numberOfPaws.ToString() + " paws .");
        }

    }
}
