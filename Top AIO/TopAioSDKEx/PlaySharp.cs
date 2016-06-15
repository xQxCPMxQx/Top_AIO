#region License : 許可證
/* Copyright (c) LeagueSharp 2016
 * 版權所有 (C) LeagueSharp 2016
 * No reproduction is allowed in any way unless given written consent
 * 無不能 在產生 是允許以任何方式 除非 特定書面同意
 * from the LeagueSharp staff.
 * 來自 原作者 LeagueSharp 開發者人員
 * Author: xQx And NightMoon
 * 作者 : xQx 和 中國作者: 花邊
 * Date: 2016/6/15
 * 日期: 2016/6/15
 * File: Top_AIO.CoreMenu.cs
 * 文件: Top_AIO.CoreMenu.cs
 */
#endregion License : 許可證

#region

using LeagueSharp;
using LeagueSharp.SDK;
using System;
using System.Collections.Generic;
using LeagueSharp.SDK.UI;
using LeagueSharp.SDK.Utils;
using LeagueSharp.SDK.Enumerations;
using SharpDX;
using SharpDX.Direct3D9;
using System.Drawing;
using System.Linq;
using System.Reflection;

#endregion

namespace Top_AIO.TopAioSDKEx
{
    internal class PlaySharp
    {
        public static Obj_AI_Hero Player { get { return ObjectManager.Player; } }
        public static List<Obj_AI_Hero> Enemies = new List<Obj_AI_Hero>(), Allies = new List<Obj_AI_Hero>();
        public static Spell Q, W, E, R;
        public static List<Spell> SpellList = new List<Spell>();
        public static Orbwalker Orbwalker;
        public static Menu Config { get; set; }
        public static Menu Ser { get; set; }
        public static Menu Combo { get; set; }
        public static Menu LaneClear { get; set; }
        public static Menu Harass { get; set; }
        public static Menu Key { get; set; }
        public static Menu LastHit { get; set; }
        public static Menu Activator { get; set; }
        public static SpellSlot Ignite { get; set; }
        public static SpellSlot Flash { get; set; }

        public static void Init()
        {
            Bootstrap.Init();
            Events.OnLoad += Top_AIO_OnLoad;
        }

        private static void Top_AIO_OnLoad(object sender, EventArgs e)
        {           
            foreach (var enemy in GameObjects.EnemyHeroes) { Enemies.Add(enemy); }
                foreach (var ally in GameObjects.AllyHeroes) { Allies.Add(ally); }

            var championName = ObjectManager.Player.ChampionName.ToLowerInvariant();

            Core.CoreMenu.Init();

            Game.PrintChat("<font color='#DDDDFF'><b> Taiwan By: CjShu :) </b></font>");
            Game.PrintChat("<font color='#FF8EFF'><b> If you like.</font><font color='#96FED1'><b>Donations welcome!</b></font>");
            Game.PrintChat("<font color='#990033'><b>PayPal: </b></font><font color='#CCFF66'><b> az937182@Gmail.com </b></font><font color='#FF9900'><b>-Top Aio SDK</b></font>");

            switch (Player.ChampionName)
            {
                case "jinx":
                    new Champions.Jinx.Jinx();
                    break;
            }
            new Core.Utility.Manager();
            Config.Attach();
          }        
     }
 }
