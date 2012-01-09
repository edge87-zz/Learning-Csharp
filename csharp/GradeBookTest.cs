using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GradeBookTest{
   static void Main(string[] args){
      GradeBook myGradeBook = new GradeBook();

      myGradeBook.DisplayMessage();
      


   }
}

public class GradeBook {
   public void DisplayMessage(){
      Console.WriteLine("Welcome to the Grade Book");
    }
}




