using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuAPI;
using Newtonsoft.Json;
using CitizenFX.Core;
using static CitizenFX.Core.UI.Screen;
using static CitizenFX.Core.Native.API;
using static vMenuClient.CommonFunctions;
using static vMenuShared.PermissionsManager;

namespace vMenuClient
{
    public class About
    {
        // Variables
        private Menu menu;

        private void CreateMenu()
        {
            // Create the menu.
            menu = new Menu(" ", "About vMenu");
            menu.HeaderTexture = new KeyValuePair<string, string>("header", "header");

            // Create menu items.
            MenuItem credits = new MenuItem("vMenu", "vMenu mod by dotexe. www.github.com/dotexe1337");
            MenuItem servers = new MenuItem("Servers", "Servers running this mod: dotexe drift server, Vengeance Life RP, & more.");
            menu.AddMenuItem(credits);
            menu.AddMenuItem(servers);
        }

        /// <summary>
        /// Create the menu if it doesn't exist, and then returns it.
        /// </summary>
        /// <returns>The Menu</returns>
        public Menu GetMenu()
        {
            if (menu == null)
            {
                CreateMenu();
            }
            return menu;
        }
    }
}
