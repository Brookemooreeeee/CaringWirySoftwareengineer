using System;

class Program {
  public static void Main (string[] args) 
  {
    // Declare the constant for conversion
    const double CENTIMETERS_PER_INCH = 2.54;
    // Variable to assign inch value
    double inches = -15;
    // Variable that calculates and stores the value for centimeters
    double centimeters = inches * CENTIMETERS_PER_INCH;
    // Displays inches to centimeters
    Console.WriteLine ("{0} inches is {1} centimeters", inches, centimeters);
    }
}