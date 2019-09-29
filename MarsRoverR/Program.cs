using System;

namespace MarsRoverR
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.WriteLine("Input:");
            string temporaryValue = Console.ReadLine();
            string[] temporaryValue2 = temporaryValue.Split(' ');
            robot.UpperRightCoordinateX = Convert.ToInt32(temporaryValue2[0]);
            robot.UpperRightCoordinateY = Convert.ToInt32(temporaryValue2[1]);

            AGAIN:
            temporaryValue = Console.ReadLine();
            temporaryValue2 = temporaryValue.Split(' ');
            robot.CurrentLocationX = Convert.ToInt32(temporaryValue2[0]);
            robot.CurrentLocationY = Convert.ToInt32(temporaryValue2[1]);
            robot.CurrentDirection = Convert.ToChar(temporaryValue2[2]);

            string returnValue = robot.WhereIsRobot(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Output:");
            Console.WriteLine(returnValue);
            Console.WriteLine("==================\n");



            goto AGAIN;
        }
    }
}
