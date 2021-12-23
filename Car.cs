namespace ClassesExercise{
    class Car
    {
        string model;
        // Make static so class has acces and no 1 Object has ownership of it
        public static int numberOfCars;
        
        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
        // All cars need to start together right ? Static 
        public static void StartRace()
        {
            Console.WriteLine("The race has begun ! ! ! ");
        }
    }
}