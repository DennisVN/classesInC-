namespace ClassesExercise {
    public class Lambo :ICar
    {
        public Lambo(string pName, string pColor){
            this.name = pName;
            this.color = pColor;
        }

        public int maxSpeed{ get {
            return 356;
        }}

        public string name { get; set; }
        public string color { get; set; }
    }
}