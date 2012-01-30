//GradeBook.cs
// Class declaration with a method that has a parameter

using System;


public class GradeBook {
   private string courseName;

   public int key { get; set; }

   public string CourseName {
      get {
         return courseName;
      }

      set {
         courseName = value;
      }
   }

   public void DisplayMessage( string courseName) {
      Console.WriteLine("Welcome to the grade book for:\n{0} {1}!", CourseName, key);
   }
}