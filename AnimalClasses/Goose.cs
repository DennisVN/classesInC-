namespace ClassesExercise{
    public class Goose: IAnimal{
        public Goose(string pName){
            name = pName;
        }
        public int numberOfPaws{get{
            return 2;
        }}

        public string name {get; set;}
    }
}