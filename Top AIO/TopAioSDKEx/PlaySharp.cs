#region

using LeagueSharp;
using LeagueSharp.SDK;
using LeagueSharp.SDK.UI;
using System;
using System.Collections.Generic;
using System.Reflection;

#endregion

namespace Top_AIO.TopAioSDKEx
{
    internal class PlaySharp
    {
        public static string ChampionName => "Top Aio";
        public static void Init()
        {
            Bootstrap.Init();
            Events.OnLoad += Top_AIO_OnLoad;
        }

        private static void Top_AIO_OnLoad(object sender, EventArgs e)
        {
            if (ObjectManager.Player.CharData.BaseSkinName != ChampionName)
            {
                return;
            }

            Core.CoreMenu.Init();

            Game.PrintChat("<font color='#DDDDFF'><b> Taiwan By: CjShu :) </b></font>");
            Game.PrintChat("<font color='#FF8EFF'><b> If you like.</font><font color='#96FED1'><b>Donations welcome!</b></font>");
            Game.PrintChat("<font color='#990033'><b>PayPal: </b></font><font color='#CCFF66'><b> az937182@Gmail.com </b></font><font color='#FF9900'><b>-Top Aio SDK</b></font>");

        }
    }
