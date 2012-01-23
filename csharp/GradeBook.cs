//GradeBook.cs
// Class declaration with a method that has a parameter

using System;


public class GradeBook {
   public void DisplayMessage( string courseName) {
      Console.WriteLine("Welcome to the grade book for:\n{0}!", courseName);
   }
}