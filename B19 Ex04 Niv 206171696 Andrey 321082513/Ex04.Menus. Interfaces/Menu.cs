using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.ConsoleUtils;

namespace Ex04.Menus.Interfaces
{
     public class Menu:MenuItem, IShowable
     {
          private MenuItem m_Father;
          private List<MenuItem> m_MenuList;
          private Button m_Back;
          private readonly int m_Level;
          

          public Menu(MenuItem i_Father,string i_MenuName)
          {
               base.m_MenuItemName = i_MenuName;
               m_Father = i_Father;
               m_MenuList = new List<MenuItem>();
               m_Back = new Button(this,"Back");
               m_MenuList.Add(m_Back);

               if (m_Father is MainMenu)
               {
                    m_Level = (m_Father as MainMenu).Level+1;
                    (m_Father as MainMenu).AddMenuItem(this);
               }
               else
               {
                    m_Level = (m_Father as Menu).m_Level+1;
                    (m_Father as Menu).AddMenuItem(this);
               }
          }

          public void AddMenuItem(MenuItem i_MenuItem)
          {
               m_MenuList.Add(i_MenuItem);
          }

          public void Show()
          {
               int numOption=-1;

               Console.WriteLine("The Title:{0}", base.m_MenuItemName);
               Console.WriteLine("The Level of This Menu is:{0}", m_Level);

               for(int i=0 ; i < m_MenuList.Count ; i++)
               {
                    Console.WriteLine("{0}.{1}", i, m_MenuList.ElementAt(i).MenuItemName);
               }

               while (numOption == -1)
               {
                    InputFromUser.GetOptionFromUser(m_MenuList.Count, out numOption);
               }

               Screen.Clear();
               if (m_MenuList.ElementAt(numOption) is Button)
               {                   
                    (m_MenuList.ElementAt(numOption) as Button).Run();
               }
               else
               {
                    (m_MenuList.ElementAt(numOption) as Menu).Show();                  
               }
          }
     }
}
