using System;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace ClassesExercise {
    class Program {
        static void Main(string[] args){
            book myBook1 = new book();
            Console.WriteLine( myBook1.Title + " " + myBook1.Author);

            book myBook2 = new book("Alice In Wonderland");
            Console.WriteLine(myBook2.Title + " " + myBook2.Author);


            book myBook3 = new book("Selas for Dummies", "Jan");
            myBook3.Title = "Andere titel";
            Console.WriteLine(myBook3.Title + " " + myBook3.Author); 

            Console.WriteLine(myBook1.ToString());
            string Json = "{'Title': 'JsonTitle','Author': 'JsonAuthor'}";
            // book JsonBook = JsonConvert.DeserializeObject<book>(Json);
            Json = System.Text.Json.JsonSerializer.Serialize(myBook3);
            // Console.WriteLine(JsonBook.ToString());
            Console.WriteLine(Json);
            // printAnimal(new Dog("pukkie"));
            // printAnimal(new Snake("ciske"));
            // printAnimal(new Goose("hans"));

            // LoadNewXml();
            Console.ReadLine(); 
        }

        private static void LoadNewXml()
        {

            XmlDocument lvBooks = new XmlDocument(); 
            lvBooks.PreserveWhitespace = true;
            lvBooks.Load(@"C:\Users\BEAUCOUPDARGENT\Documents\VS CODE\classesInCSharp\classesExercise\books.xml");
            string strBook = lvBooks.OuterXml;
            Console.WriteLine("LoadNewXml function result : \n" + strBook);

            // // third book element 
            // // @ for attributes ; SelectNode // SelectSingeNode learn difference well
            // try{
            //     Console.WriteLine(lvBooks.SelectSingleNode("(/catalog/book[price > 5])").OuterXml);
            // }catch(Exception a){
            //     Console.WriteLine(a.ToString());
            // }
            // Console.ReadKey();
        }

        // public static void printAnimal(IAnimal animal) 
        // {
        //     Console.WriteLine(animal.name + " has " + animal.numberOfPaws.ToString() + " paws");
        // }

    }
}
