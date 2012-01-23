using System;

public class GradeBookTest{
   public static void Main(string[] args){
      
      //Create a GradeBook object and assign it to myGradeBook
      GradeBook myGradeBook = new GradeBook();

      //Prompt for course name
      Console.WriteLine("please enter course name");
      string nameOfCourse = Console.ReadLine(); //Reads a line puts it in nameOfCourse
      Console.WriteLine(""); // Outputs Blank Line

      // call myGradeBook's DisplayMessage method and pass nameOfCourse as an argument


      myGradeBook.DisplayMessage(nameOfCourse);
      
      //Print a blank line, tell them to press enter, read return to continue
      Console.WriteLine("\n");
      Console.WriteLine("Press Enter To Close");
      nameOfCourse = Console.ReadLine();


   } //Ends Main
} //Ends GradeBookTest





