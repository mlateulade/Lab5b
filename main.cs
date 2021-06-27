using System;

class MainClass {
  public static void Main (string[] args) {    
    
    int x = 1;
    int y = 1; 
    int z;   
    double speed;
    double total = 0;
    double average; 

    Console.WriteLine("Enter the number of cars");
      z = Convert.ToInt32(Console.ReadLine());

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

      average = total / z;
      Console.WriteLine("The average speed of the cars is "+average+" miles per hour");
         

   

    


  }
}
