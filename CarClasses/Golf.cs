namespace ClassesExercise {
    public class Golf :ICar
    {
        public Golf(string pName, string pColor){
            this.name = pName;
            this.color = pColor;
        }

        public int maxSpeed{ get {
            return 249;
        }}

        public int doors{get{
            return 4;
        }}

        public string name { get; set; }
        public string color { get; set; }
    }
}