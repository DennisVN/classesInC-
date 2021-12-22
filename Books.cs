namespace ClassesExercise {
    public class book
    {
        public book(string title, string author = "Dennis"){
            this.Title = title;
            this.Author = author;
        }
        // TRY TO use parameter version (return) V
        public book(){
            this.Title = "standaard titel";
            this.Author = "fluppe";
        }

        // classic implementation of properties (older code FYI)
        // private string vTitle;
        // public string Title{get{return vTitle;} set{vTitle = value;}}
        // New code
        public string Title{get; set;}
        [System.Text.Json.Serialization.JsonPropertyName("schrijver")]
        public string Author{get; set;}

        public override string ToString()
        {
            return Title;
        }
    }
}