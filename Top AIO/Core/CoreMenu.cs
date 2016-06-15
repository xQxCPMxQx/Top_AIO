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
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace Top_AIO.Core
{
    internal class CoreMenu
    {
        public static Orbwalker Orbwalker;
        public static Menu Menu { get; private set; }
        public static Menu Key { get; private set; }
        public static Menu Q { get; private set; }
        public static Menu W { get; private set; }
        public static Menu E { get; private set; }
        public static Menu R { get; private set; }
        public static Menu Combo { get; private set; }
        public static Menu Farm { get; private set; }
        public static Menu Tools { get; private set; }
        public static Menu Props { get; private set; }
        public static Menu Draw { get; private set; }
        public static Menu Misc { get; private set; }
        public static Menu Flee { get; private set; }
        public static Menu Harass { get; private set; }

    }
}
