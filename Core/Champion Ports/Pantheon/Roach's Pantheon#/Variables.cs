using System.Collections.Generic;
using LeagueSharp;
using LeagueSharp.Common;

using EloBuddy; 
 using LeagueSharp.Common; 
 namespace RoachPantheon
{
    internal class Variable
    {
        public const string CharName = "Pantheon";
        public static Orbwalking.Orbwalker Orbwalker;
        public static List<Spell> Spells = new List<Spell>();
        public static Spell Q;
        public static Spell W;
        public static Spell E;
        public static SpellSlot IgniteSlot;
        public static SpellSlot SmiteSlot;
        public static Menu Config;
        public static AIHeroClient Player = ObjectManager.Player;
    }
}