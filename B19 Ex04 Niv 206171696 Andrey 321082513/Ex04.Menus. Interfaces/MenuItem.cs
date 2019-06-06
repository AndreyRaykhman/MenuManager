using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
     public abstract class MenuItem
     {
          protected string m_MenuItemName;

          public string MenuItemName
          {
               get { return m_MenuItemName; }
               set { m_MenuItemName = value; }
          }
     }
}
