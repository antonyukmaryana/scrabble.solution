using System;
using System.Collections.Generic;

 public class Scrabble
 {
   public static void Main()
   {
     Console.WriteLine("Welcome to Scrabble! Please enter the word");
     Dictionary<string,int> scrabbleDictionary= new Dictionary<string,int>()

    {
      {"a",1},{"e",1},{"i",1},{"o",1},{"u",1},{"l",1},{"n",1},{"r",1},{"s",1},{"t",1},
      {"d",2},{"g",2},{"b",3},{"c",3},{"m",3},{"p",3},{"f",4},{"h",4},{"v",4},{"w",4},
      {"y",4},{"k",5},{"j",8},{"x",8},{"q",10},{"z",10}
    };
      int points = 0;
      string userInput=Console.ReadLine();
      char[] userArray=userInput.ToCharArray();
      for (int i=0;i< userArray.Length; i++)
    {
      string convertChar = userArray[i].ToString();
      points += scrabbleDictionary[convertChar];
    }
      Console.WriteLine("points =" + points);
    }
  }
