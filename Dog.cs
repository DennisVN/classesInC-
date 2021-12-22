namespace ClassesExercise{
    public class Dog: IAnimal{
        public Dog(string pName){
            name = pName;
        }
        public int numberOfPaws{get{
            return 4;
        }}
        
        public string name {get; set;}

    }
}