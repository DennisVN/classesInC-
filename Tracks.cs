namespace ClassesExercise 
{
    // Track class
    public class Track 
    {
        // different Attributes for Track Object

        // Create Method -> Constructor (get's called when new object)
        // inside brackets are the Parameters
        public Track(string aTitle, string aArtist){
            this.Title = aTitle;
            this.Artist = aArtist;
        }

        public Track(){
            this.Title = "Blue";
            this.Artist = "Eifel 65";
        }
        
        // Getters and Setters (makes classes more secure & validation)
        public string Title{ get; set; }
        public string Artist{ get; set; }
    }
}