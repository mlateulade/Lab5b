using System;

class MainClass {
  public static void Main (string[] args) {    
    
    int x = 1;
    int y = 1; 
    int z;//added variable z to represent number of cars   
    double speed;
    double total = 0;
    double average; 
    //added console request for input of number of cars
    Console.WriteLine("Enter the number of cars");
      //defined z by converting string value of read input to int
      z = Convert.ToInt32(Console.ReadLine());

    //changed second for loop statement to input variable z
    for (int counter=1; counter<=z; counter++)

    {
      Console.WriteLine("Enter the distance covered by Car#"+y);
      double dist = Convert.ToDouble(Console.ReadLine());
      y++;

      Console.WriteLine("Enter the time taken by Car#"+x);
      double hrs = Convert.ToDouble(Console.ReadLine());     
      x++;
      
      speed = (dist/hrs);       
      
      total = total + speed;           
      Console.WriteLine("The speed of this car is "+ speed + " mile per hour");
           
    }
      //updated average calculation to use input variable z
      average = total / z;
      Console.WriteLine("The average speed of the cars is "+average+" miles per hour");
         

   

    


  }
}
