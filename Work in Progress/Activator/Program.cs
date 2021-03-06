﻿using System;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += GameOnOnGameLoad;
        }

        private static void GameOnOnGameLoad(EventArgs args)
        {
            Config.Menu = new Menu("Activator", "Activator", true);

            //Auto Shield
            AutoShield.AddToMenu(Config.Menu);
            
            //Auto Potion
            AutoPotion.AddToMenu(Config.Menu);

            //Auto Smite
            AutoSmite.AddToMenu(Config.Menu);

            //Auto Exhaust
            AutoExhaust.AddToMenu(Config.Menu);
           
            Config.Menu.AddToMainMenu();

            //PrintChat
            Game.PrintChat("Activator loaded! Credits@Github");
        }

    }
}
