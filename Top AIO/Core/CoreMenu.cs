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

using System;
using LeagueSharp;
using LeagueSharp.SDK.UI;
using System.Reflection;

#endregion

namespace Top_AIO.Core
{
    internal class CoreMenu
    {       
        public static void Init()
        {
        var Config = new Menu("Top Aio", "Top AIO SDKEx", true);

            Config.Add(new MenuSeparator("Credit", "Credit : CjShu"));
            Config.Add(new MenuSeparator("Version", "Version : " + Assembly.GetExecutingAssembly().GetName().Version));
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
}