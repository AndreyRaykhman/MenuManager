using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
     class Menu:MenuItem, IShowable
     {
          private List<MenuItem> m_MenuList;
          private Button m_Back;
          private readonly int m_Level;

          public Menu(string i_Title, int i_Level)
          {
               base.m_MenuItemName = i_Title;
               m_Level = i_Level;
               m_MenuList = new List<MenuItem>();
               m_Back = new Button(this);
               m_Back.MenuItemName = "Back";
               m_MenuList.Add(m_Back);
          }

          public void Show()
          {
               int numOption=-1;

               Console.WriteLine("The Title:{0}", base.m_MenuItemName);
               Console.WriteLine("The Level of This Menu is:{0}", m_Level);

               for(int i=0 ; i < m_MenuList.Count ; i++)
               {
                    Console.WriteLine("{0}.{1}", i, m_MenuList[i].MenuItemName);
               }
               
               while(numOption==-1)
               {
                    InputFromUser.GetOptionFromUser(m_MenuList.Count, out numOption);
               }

               if(m_MenuList[numOption] is Button)
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
