using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     class Program
     {
          public static void Main()
          {
               runMainMenu();
          }

          private static void runMainMenu()
          {
               MainMenu mainMenu = new MainMenu("Main Menu");

               Menu dataAndTime=new Menu(mainMenu, "Show Date/Time");
               Button showDate = new Button(dataAndTime, "Show Date");
               Button showTime = new Button(dataAndTime, "Show Time");

               Menu versionAndDigit=new Menu(mainMenu, "Version and Digit");
               Button countDigits = new Button(versionAndDigit, "Count Digits");
               Button showVersion = new Button(versionAndDigit, "Show Version");

               mainMenu.Show();
          }
     }
}
