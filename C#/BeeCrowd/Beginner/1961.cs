using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        string input = Console.ReadLine();      
        short frogJumpHeight = Convert.ToInt16(input.Split(' ')[0]);
        short numberOfPipes = Convert.ToInt16(input.Split(' ')[1]);

        string pipesHeights = Console.ReadLine();
        string[] pipesHeightsAsArray = pipesHeights.Split(' ');

        for (int i = 0; i < numberOfPipes - 1; i++)
        {            
            if (Math.Abs(Convert.ToInt16(pipesHeightsAsArray[i]) 
                    - Convert.ToInt16(pipesHeightsAsArray[i + 1])) > frogJumpHeight)
            {
                Console.WriteLine("GAME OVER");
                return;
            } 
        }

        Console.WriteLine("YOU WIN");
    }          

}
