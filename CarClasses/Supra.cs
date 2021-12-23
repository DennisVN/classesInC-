namespace ClassesExercise {
    public class Supra :ICar
    {
        public Supra(string pName, string pColor){
            this.name = pName;
            this.color = pColor;
        }

        public int maxSpeed{ get {
            return 250;
        }}

        public int doors{get{
            return 2;
        }}

        public string name { get; set; }
        public string color { get; set; }
    }
}