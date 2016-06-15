#region License : 許可證
/* Copyright (c) LeagueSharp 2016
 * 版權所有 (C) LeagueSharp 2016
 * No reproduction is allowed in any way unless given written consent
 * 無不能 在產生 是允許以任何方式 除非 特定書面同意
 * from the LeagueSharp staff.
 * 來自 原作者 LeagueSharp 開發者人員
 * Author: xQx And NightMoon
 * 作者 : xQx 和 中國作者: 花邊
 * Date: 2/20/2016
 * 日期: 2016/6/15
 * File: Top_AIO.CoreMenu.cs
 * 文件: Top_AIO.CoreMenu.cs
 */
#endregion License : 許可證

using LeagueSharp;
using LeagueSharp.SDK;
using LeagueSharp.SDK.UI;
using LeagueSharp.SDK.Utils;
using LeagueSharp.SDK.Enumerations;
using System;
using SharpDX;
using SharpDX.Direct3D9;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace Top_AIO.Core
{
    internal class CoreMenu
    {
        public static Orbwalker Orbwalker;
        public static Champion ChampionClass;
        public static Menu Config;
        public static Menu Combo;
        public static Menu LaneClear;
        public static Menu Harass;
        public static Menu Key;
        public static Menu LastHit;
        public static Menu Activator;
        public static SpellSlot Ignite, Flash;

        public static void Init()
        {
            Config = new Menu("Top Aio", "Top AIO SDKEx", true);
            Config.Add(new MenuSeparator("Credit", "Credit : CjShu"));
            Config.Add(new MenuSeparator("News", "News :Thank you my friend xQx. And NightMoon. Aid"));
            var Ser = Config.Add(new Menu("Series", "Series Champions"));
            {
                Ser.Add(new MenuSeparator("Jinx", "Jinx"));
                Ser.Add(new MenuSeparator("Jhin", "Jhin"));
                Ser.Add(new MenuSeparator("Vayne", "Vayne"));
                Ser.Add(new MenuSeparator("Malzahar", "Malzahar"));
                Ser.Add(new MenuSeparator("Syndra", "Syndra"));
            }

            
        }
}
