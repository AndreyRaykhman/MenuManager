using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
     class MainMenu:MenuItem, IShowable
     {
          List<MenuItem> m_MenuList;
          Button m_Exit;
          private const int m_Level = 0;

          public MainMenu(string i_MainTitle)
          {
               base.m_MenuItemName = i_MainTitle;
               m_MenuList = new List<MenuItem>();
               m_Exit = new Button(this);
               m_Exit.MenuItemName = "Exit";
               m_MenuList.Add(m_Exit);
          }

          public void Show()
          {
               int numOption = -1;

               Console.WriteLine("The Main Title:{0}", base.m_MenuItemName);
               Console.WriteLine("The Level of This Menu is:{0}", m_Level);

               for (int i = 0; i < m_MenuList.Count; i++)
               {
                    Console.WriteLine("{0}.{1}", i, m_MenuList[i].MenuItemName);
               }

               while (numOption == -1)
               {
                    InputFromUser.GetOptionFromUser(m_MenuList.Count, out numOption);
               }

               if (m_MenuList[numOption] is Button)
               {
                    //clear screen
                    (m_MenuList[numOption] as Button).Run();
               }
               else
               {
                    //clear screen
                    (m_MenuList[numOption] as Menu).Show();
               }
          }
     }
}
