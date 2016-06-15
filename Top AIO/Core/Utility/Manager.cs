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
using LeagueSharp.SDK.Utils;
using System;
using SharpDX;
using SharpDX.Direct3D9;
using System.Collections.Generic;
using System.Linq;
using Top_AIO.TopAioSDKEx;
using static LeagueSharp.Common.Packet;

#endregion

namespace Top_AIO.Core.Utility
{
        internal class Manager
        {
            private static Vector2 PingLocation;
            private static int LastPingT = 0;
            public static List<BuffType> DebuffTypes = new List<BuffType>();
            public static List<Obj_AI_Minion> GetMinions(float range)
            {
                return GameObjects.Minions.Where(x => x.IsValidTarget(range) && x.IsEnemy && x.IsMinion && x.Team != GameObjectTeam.Neutral).ToList();
            }
            public static List<Obj_AI_Minion> GetMobs(float range)
            {
                return ObjectManager.Get<Obj_AI_Minion>().Where(x => !x.IsDead && !x.IsZombie && x.Team == GameObjectTeam.Neutral && x.IsValidTarget(range)).ToList();
            }
            public static List<Obj_AI_Hero> GetEnemies(float range)
            {
                return PlaySharp.Enemies.Where(x => x.IsValidTarget(range) && !x.IsZombie && !x.IsDead).ToList();
            }
            public static Obj_AI_Hero GetTarget(float range, DamageType damagetype = DamageType.Physical)
            {
                return Variables.TargetSelector.GetTarget(range, damagetype);
            }
            public static Obj_AI_Hero GetTarget(Spell spell, bool ignote = true)
            {
                return Variables.TargetSelector.GetTarget(spell, true);
            }
            private static void SimplePing(PingCategory pingCategory = PingCategory.Fallback)
            {
                S2C.Ping.Encoded(new S2C.Ping.Struct(PingLocation.X, PingLocation.Y, 0, 0, PingType.Fallback)).Process();
                Game.ShowPing(pingCategory, PingLocation, true);

            }
            public static bool InAutoAttackRange(AttackableUnit target)
            {
                var baseTarget = (Obj_AI_Base)target;
                var myRange = ObjectManager.Player.GetRealAutoAttackRange();

                if (baseTarget != null)
                {
                    return baseTarget.IsHPBarRendered && Vector2.DistanceSquared(baseTarget.ServerPosition.ToVector2(), ObjectManager.Player.ServerPosition.ToVector2()) <= myRange * myRange;
                }

                return target.IsValidTarget() && Vector2.DistanceSquared(target.Position.ToVector2(), ObjectManager.Player.ServerPosition.ToVector2()) <= myRange * myRange;
            }
            public static bool CanMove(Obj_AI_Hero hero)
            {
                DebuffTypes.Add(BuffType.Blind);
                DebuffTypes.Add(BuffType.Charm);
                DebuffTypes.Add(BuffType.Fear);
                DebuffTypes.Add(BuffType.Flee);
                DebuffTypes.Add(BuffType.Stun);
                DebuffTypes.Add(BuffType.Snare);
                DebuffTypes.Add(BuffType.Taunt);
                DebuffTypes.Add(BuffType.Suppression);
                DebuffTypes.Add(BuffType.Polymorph);
                DebuffTypes.Add(BuffType.Blind);
                DebuffTypes.Add(BuffType.Silence);

                foreach (var buff in hero.Buffs)
                {
                    if (DebuffTypes.Contains(buff.Type) && (buff.EndTime - Game.Time) * 1000 >= 600 && buff.IsActive)
                    {
                        return false;
                    }
                }

                return true;
            }
            public static bool IsFollowing(Obj_AI_Base t)
            {
                if (!t.IsFacing(ObjectManager.Player)
                    && ObjectManager.Player.Position.Distance(t.Path[0])
                    < ObjectManager.Player.Position.Distance(t.Position))
                {
                    return true;
                }
                return false;
            }
            public static bool IsRunning(Obj_AI_Base t)
            {
                if (!t.IsFacing(ObjectManager.Player)
                    && (t.Path.Count() >= 1
                        && ObjectManager.Player.Position.Distance(t.Path[0])
                        > ObjectManager.Player.Position.Distance(t.Position)))
                {
                    return true;
                }
                return false;
            }

            private static readonly string[] BettrWithEvade =
            {
                "Jinx",
            };



        }
}