namespace ClassesExercise{
    public class Snake: IAnimal{
        public Snake(string pName){
            name = pName;
        }
        public int numberOfPaws{get{
            return 0;
        }}

        public string name {get; set;}
    }
}