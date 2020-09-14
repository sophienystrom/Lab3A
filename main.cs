using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter Temperature in Celcius");
    var y = Console.ReadLine();
    Double y1 = Convert.ToDouble(y);
    var Farenheit = ((y1*9/5)+32);
    Console.WriteLine ("Farenheit equivalent for " + y + " degree Celcius is " + Farenheit);
    if (Farenheit < 32)
    {
      Console.WriteLine ("This temperature is below freezing of 32 degrees Farenheit"); }
    if (Farenheit > 212)
    { 
      Console.WriteLine ("This temperature is above boiling point of 212 degree Farenheight");
    }
  }
}