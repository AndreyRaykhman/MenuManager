using System;

namespace Ex04.Menus.Interfaces
{
     static class InputFromUser
     {
          public static void GetOptionFromUser(int i_MaxOption, out int io_NumOption)
          {
               int option;
               string optionString;

               Console.WriteLine("Please choose number in range of 0-{0}", i_MaxOption - 1);
               optionString = Console.ReadLine();

               if(!int.TryParse(optionString,out option))
               {
                    Console.WriteLine("Not In Context Input");
                    io_NumOption = -1;
               }
               else
               {
                    if(option >= i_MaxOption)
                    {
                         Console.WriteLine("option not in range");
                         io_NumOption = -1;
                    }
                    else
                    {
                         io_NumOption = option;
                    }
               }
          }         
     }
}
