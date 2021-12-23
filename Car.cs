namespace ClassesExercise{
    // Non Static Class -> can be instantiated
    public class Car
    {
        public string model;
        public string color; 
        public int doors;
        
        public Car(String model, String color, int doors)
        {
            this.model = model;
            this.color = color;
            this.doors = doors; 
        }
    }
}