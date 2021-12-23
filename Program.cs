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
            Track track1 = new Track();
            Console.WriteLine(track1.ToString());

            Track newTrack = new Track("Geen centen maar spullen", "Donnie ft. Frans Bauer");
            Console.WriteLine(newTrack.Title + " - " + newTrack.Artist);
            
            // Use parameters 
            Track newTrack2 = new Track();
            Console.WriteLine(newTrack2.Title + " - " + newTrack2.Artist);

            Track newTrack3 = new Track();
            newTrack3.Title = "Love is a battlefield";
            newTrack3.Artist = "Kate Bush";
            Console.WriteLine(newTrack3.Title + " - " + newTrack3.Artist);

            Track newTrack4 = new Track();
            newTrack4.Title = "Sigaretten";
            Console.WriteLine(newTrack4.Title + " - " + newTrack4.Artist);
            #endregion
            
            #region Car
            // Car car1 = new Car("Lambo", "Bright Orange", 2, 356);
            // Car car2 = new Car("Golfke", "Matte Black", 4, 250);
            // Car car3 = new Car("Supra", "Pearlescent Salmon Pink", 2, 250);
            // Console.WriteLine("A " + car1.doors + "-door " + car1.color + " " + car1.model + " has joined." +
            // "\n\r Top speed: " + car1.maxSpeed + " km/h .");
            // Console.WriteLine("A " + car2.doors + "-door " + car2.color + " " + car2.model + " has joined." +
            // "\n\r Top speed: " + car2.maxSpeed + " km/h .");
            // Console.WriteLine("A " + car3.doors + "-door " + car3.color + " " + car3.model + " has joined." +
            // "\n\r Top speed: " + car3.maxSpeed + " km/h .");
            
            // // Non Static way :
            // Supra newSupra = new Supra("Toyota GR Supra", "Pearlescent Salmon Pink");
            // newSupra.color = "Midnight Purple";
            // Console.WriteLine("A new " + newSupra.doors + "-door " + newSupra.name + " in " + newSupra.color + 
            // " has joined ." + "\n\r" + "Top Speed : " + newSupra.maxSpeed + " km/h");

            // Lambo newLambo = new Lambo("Lamborghini Veneno", "Lava Red");
            // newLambo.color = "Lime Green";
            // Console.WriteLine("A new " + newLambo.doors + "-door " + newLambo.name + " in " + newLambo.color + 
            // " has joined ." + "\n\r" + "Top Speed : " + newLambo.maxSpeed + " km/h");

            // Golf newGolf = new Golf("VW Golf GTI", "Matte Black");
            // Console.WriteLine("A new " + newGolf.doors + "-door " +  newGolf.name + " in " + newGolf.color + 
            // " has joined ." + "\n\r" + "Top Speed : " + newGolf.maxSpeed + " km/h");

            // Supra newSupra2 = new Supra("Toyota Supra MK4", "Race Blue");
            // Console.WriteLine("A new " + newSupra2.doors + "-door " + newSupra2.name + " in " + newSupra2.color + 
            // " has joined ." + "\n\r" + "Top Speed : " + newSupra2.maxSpeed + " km/h");
            
            // // Static way : 
            // printCar(new Supra("Toyota GR Supra", "Pearlescent Salmon Pink"));
            // printCar(new Lambo("Lamborghini Veneno", "Lava Red"));
            // printCar(new Golf("VW Golf GTI", "Matte Black"));
            // printCar(new Golf("VW GOLF MK1", "Metallic Sage Green"));

            #endregion 
            
            #region Animals
            // printAnimal(new Snake("boopsnoot"));
            // printAnimal(new Dog("doggo"));
            // printAnimal(new Goose("mad bird"));
            #endregion

            getSum(27, 105050);
            
            Console.ReadLine(); 
        }
        // Static Method with Interface Constructor (& getter and setters)
        public static void printAnimal(IAnimal animal)
        {
            Console.WriteLine(animal.name + " has " + animal.numberOfPaws.ToString() + " paws .");
        }

        public static void printCar(ICar car)
        {
            Console.WriteLine("A new " + car.doors + "-door " + car.name + " in " + car.color + 
            " has joined ." + "\n\r" + "Top Speed : " + car.maxSpeed + " km/h");
        }

        public static void getSum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of {0} + {1} = {2} .", a, b, sum);
        }
    }
}
