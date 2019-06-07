using System;
using Ex02.ConsoleUtils;
using System.Reflection;
using System.Text;

namespace Ex04.Menus.Interfaces
{
     public class Button:MenuItem, IRunable
     {
          private MenuItem m_Father;       

          public Button(MenuItem i_Father,string i_ButtonName)
          {
               base.m_MenuItemName = i_ButtonName;
               m_Father = i_Father;
               
               if (m_Father is Menu)
               {
                    (m_Father as Menu).AddMenuItem(this);
               }
               else
               {
                    (m_Father as MainMenu).AddMenuItem(this);
               }
          }

          public void Run()
          {   
               if(base.MenuItemName == "Exit")
               {
                    Environment.Exit(1);
               }

               if(base.MenuItemName == "Back")
               {        
                    if((m_Father as Menu).Father is Menu)
                    {
                         ((m_Father as Menu).Father as Menu).Show();
                         return;
                    }
                    else
                    {
                         ((m_Father as Menu).Father as MainMenu).Show();
                         return;
                    }
               }

               Type t = this.GetType();
               MethodInfo method = t.GetMethod(functionName());
               method.Invoke(this,null);

               Screen.Clear();
               if (m_Father is Menu)
               {
                    (m_Father as Menu).Show();
               }
               else
               {
                    (m_Father as MainMenu).Show();
               }
          }
          
          private string functionName()
          {
               StringBuilder functionName=new StringBuilder();

               foreach(char ch in base.MenuItemName)
               {
                    if(ch!=' ')
                    {
                         functionName.Append(ch);
                    }
               }

               return functionName.ToString();
          }

          public static void ShowVersion()
          {
               Console.WriteLine("Version: 19.2.4.32");
               Console.WriteLine("for return to the previous menu press enter");
               Console.ReadLine();
          }

          public static void CountDigits()
          {
               int counterDigit = 0;
               string sentence;

               Console.WriteLine("please write a sentence (and after press enter)");
               sentence = Console.ReadLine();

               foreach (char ch in sentence)
               {
                    if(Char.IsDigit(ch))
                    {
                         counterDigit++;
                    }
               }

               Console.WriteLine("you have {0} digits in the sentence", counterDigit);
               Console.WriteLine("for return to the previous menu press enter");
               Console.ReadLine();
          }

          public static void ShowDate()
          {
               Console.WriteLine(DateTime.Today.ToString("dd/MM/yyyy"));
               Console.WriteLine("for return to the previous menu press enter");
               Console.ReadLine();
          }

          public static void  ShowTime()
          {
               Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
               Console.WriteLine("for return to the previous menu press enter");
               Console.ReadLine();
          }
     }
}
