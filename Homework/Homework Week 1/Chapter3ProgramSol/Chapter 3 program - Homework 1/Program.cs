using System;

namespace Chapter_3_program___Homework_1
{
    class Program
    {
        static void Main()
        {
            //variables used later

            double width;
            double height;
            double glassArea;
            string widthString;
            string heightString;

            //find width of window from user
            Console.WriteLine("Enter the width in meters");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //verify the input
            //if width<100 Then Console.WriteLine("Please re-enter the width in meters")


            //find height of window from user
            Console.WriteLine("Enter the height in meters");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //verify the input
            
            //calculate area and convert it to feet^2
            double v = width * height * 3.25 * 3.25;
            glassArea = v;
            double



                        //Calculate the length of wood used
                        woodLength = (width + height) * 2 * 3.25;

            //Print the results
            Console.WriteLine("The area of the window is" +  glassArea + "feet");
            Console.WriteLine("The length of the wood is" +  woodLength + "feet");

            //prevents console from closing before user hits enter
            Console.ReadLine();
        }   
        
    }
}
