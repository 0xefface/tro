using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Mobiles
{
    public enum MobileType : int
    {
        None =0x00,
        Humaniod = 0x01,
        NonHumanoid = 0x02
    }
    public static class BaseMobile
    {
        public static Dictionary<short, string> NonHumanoid { get;  private set; }
        public static Dictionary<short, string> Humanoid { get; private set; }

        public static void Init()
        {
            /*
             * These are all hardcoded mobs found in the game
             * do not change these unless you added new graphics
             * to the spots that say ERROR_NO_DATA
             */
            #region NonHumanoid
            if (NonHumanoid == null)
            {
                NonHumanoid = new Dictionary<short, string>();
                NonHumanoid.Add(2200, "Guardian");
                NonHumanoid.Add(2201, "Daemon");
                NonHumanoid.Add(2202, "Flame Daemon");
                NonHumanoid.Add(2203, "Snow Daemon");
                NonHumanoid.Add(2204, "Daemon King");
                NonHumanoid.Add(2205, "Kilrog");
                NonHumanoid.Add(2206, "King Kilrog");
                NonHumanoid.Add(2207, "Flame Daemon");
                NonHumanoid.Add(2208, "Snow Daemon");
                NonHumanoid.Add(2209, "Daemon King");
                NonHumanoid.Add(2210, "Kilrog");
                NonHumanoid.Add(2211, "King Kilrog");
                NonHumanoid.Add(2212, "Earth Elemental");
                NonHumanoid.Add(2213, "Stone Guardian");
                NonHumanoid.Add(2214, "Rock Guardian");
                NonHumanoid.Add(2215, "Water Elemental");
                NonHumanoid.Add(2216, "Fire Elemental");
                NonHumanoid.Add(2217, "Air Elemental");
                NonHumanoid.Add(2218, "Pixie");
                NonHumanoid.Add(2219, "Faery");
                NonHumanoid.Add(2220, "Wood Nymph");
                NonHumanoid.Add(2221, "Dark Faery");
                NonHumanoid.Add(2222, "Faery Queen");
                NonHumanoid.Add(2223, "Gray Fenris");
                NonHumanoid.Add(2224, "Gray Fenris");
                NonHumanoid.Add(2225, "Young Fenris");
                NonHumanoid.Add(2226, "Blood Fenris");
                NonHumanoid.Add(2227, "Howling Terror");
                NonHumanoid.Add(2228, "Hell Hound");
                NonHumanoid.Add(2229, "Hunter");
                NonHumanoid.Add(2230, "Scavenger");
                NonHumanoid.Add(2231, "Feral");
                NonHumanoid.Add(2232, "Dire Wolf");
                NonHumanoid.Add(2233, "Cobra");
                NonHumanoid.Add(2234, "Spitting Cobra");
                NonHumanoid.Add(2235, "Lava Serpent");
                NonHumanoid.Add(2236, "King Cobra");
                NonHumanoid.Add(2237, "Hell Snake");
                NonHumanoid.Add(2238, "Wyrm");
                NonHumanoid.Add(2239, "Apophis");
                NonHumanoid.Add(2248, "Ratling");
                NonHumanoid.Add(2249, "Mouse");
                NonHumanoid.Add(2250, "Wood Ratling");
                NonHumanoid.Add(2251, "Desert Ratling");
                NonHumanoid.Add(2252, "Swamp Ratling");
                NonHumanoid.Add(2253, "Cave Ratling");
                NonHumanoid.Add(2254, "Arctic Ratling");
                NonHumanoid.Add(2255, "Flame Ratling");
                NonHumanoid.Add(2256, "Plague Ratling");
                NonHumanoid.Add(2257, "Daemon Ratling");
                NonHumanoid.Add(2258, "Mouse");
                NonHumanoid.Add(2259, "Ghost");
                NonHumanoid.Add(2260, "Shade");
                NonHumanoid.Add(2261, "Banshee");
                NonHumanoid.Add(2262, "Fury");
                NonHumanoid.Add(2263, "Weakened Ghost");
                NonHumanoid.Add(2264, "Specter");
                NonHumanoid.Add(2265, "Poltergeist");
                NonHumanoid.Add(2266, "Yurei");
                NonHumanoid.Add(2267, "Apparition");
                NonHumanoid.Add(2268, "Haunt");
                NonHumanoid.Add(2269, "Spirit");
                NonHumanoid.Add(2270, "Lemure");
                NonHumanoid.Add(2271, "Eidolon");
                NonHumanoid.Add(2272, "Manes");
                NonHumanoid.Add(2273, "Sidhe");
                NonHumanoid.Add(2274, "Onryo");
                NonHumanoid.Add(2275, "Ubume");
                NonHumanoid.Add(2276, "Goryo");
                NonHumanoid.Add(2277, "Ikiryo");
                NonHumanoid.Add(2278, "Wasp Drone");
                NonHumanoid.Add(2279, "Wasp Worker");
                NonHumanoid.Add(2280, "Wasp Warrior");
                NonHumanoid.Add(2281, "Wasp Queen");
                NonHumanoid.Add(2282, "Skeleton");
                NonHumanoid.Add(2283, "Lost Sailor");
                NonHumanoid.Add(2284, "Damned One");
                NonHumanoid.Add(2285, "Phantasm");
                NonHumanoid.Add(2286, "Revenant");
                NonHumanoid.Add(2287, "Bat");
                NonHumanoid.Add(2288, "Flying Rat");
                NonHumanoid.Add(2289, "Crypt Bat");
                NonHumanoid.Add(2290, "Vampire Bat");
                NonHumanoid.Add(2291, "Storm Bat");
                NonHumanoid.Add(2292, "Screeching Horror");
                NonHumanoid.Add(2293, "Wolf");
                NonHumanoid.Add(2294, "Wolf");
                NonHumanoid.Add(2295, "Rabid Wolf");
                NonHumanoid.Add(2296, "Alpha Wolf");
                NonHumanoid.Add(2297, "Orge");
                NonHumanoid.Add(2298, "Orge Child");
                NonHumanoid.Add(2299, "Ugly Orge");
                NonHumanoid.Add(2300, "Orge Mage");
                NonHumanoid.Add(2301, "Orge Chief");
                NonHumanoid.Add(2302, "Orge Chief");
                NonHumanoid.Add(2303, "Menosz");
                NonHumanoid.Add(2304, "Troll");
                NonHumanoid.Add(2305, "Troll Armsman");
                NonHumanoid.Add(2306, "Troll Warrior");
                NonHumanoid.Add(2307, "Troll Elementalist");
                NonHumanoid.Add(2308, "Troll Sorcerer");
                NonHumanoid.Add(2309, "Troll King");
                NonHumanoid.Add(2310, "Troll King");
                NonHumanoid.Add(2311, "Imp Slave");
                NonHumanoid.Add(2312, "Imp Citizen");
                NonHumanoid.Add(2313, "Imp Guard");
                NonHumanoid.Add(2314, "Imp Slavemaster");
                NonHumanoid.Add(2315, "Imp Thaumaturgist");
                NonHumanoid.Add(2316, "Imp Necromancer");
                NonHumanoid.Add(2317, "Imp Warrior");
                NonHumanoid.Add(2318, "Imp King");
                NonHumanoid.Add(2319, "Seraph");
                NonHumanoid.Add(2320, "Seraph Warrior");
                NonHumanoid.Add(2321, "Seraph Thaumaturgist");
                NonHumanoid.Add(2322, "Seraph Queen");
                NonHumanoid.Add(2364, "Gargoyle");
                NonHumanoid.Add(2365, "Gargoyle");
                NonHumanoid.Add(2366, "Gargoyle");
                NonHumanoid.Add(2367, "Gargoyle");
                NonHumanoid.Add(2368, "Gargoyle");
                NonHumanoid.Add(2369, "Gargoyle");
                NonHumanoid.Add(2370, "Gargoyle");
                NonHumanoid.Add(2371, "Gargoyle");
                NonHumanoid.Add(2372, "Gargoyle");
                NonHumanoid.Add(2373, "Bergelmir");
                NonHumanoid.Add(2374, "Dragon");
                NonHumanoid.Add(2375, "Dragon");
                NonHumanoid.Add(2376, "Dragon");
                NonHumanoid.Add(2377, "Dragon");
                NonHumanoid.Add(2378, "Dragon");
                NonHumanoid.Add(2379, "Dragon");
                NonHumanoid.Add(2380, "Volcanic Hatchling");
                NonHumanoid.Add(2381, "Young Volcanic Hatchling");
                NonHumanoid.Add(2382, "Volcanic Dragon");
                NonHumanoid.Add(2383, "Volcanic Elder Dragon");
                NonHumanoid.Add(2384, "Legendary Volcanic Dragon");
                NonHumanoid.Add(2385, "Moor Hatchling");
                NonHumanoid.Add(2386, "Young Moor Dragon");
                NonHumanoid.Add(2387, "Moor Dragon");
                NonHumanoid.Add(2388, "Moor Elder Dragon");
                NonHumanoid.Add(2389, "Legendary Moor Dragon");
                NonHumanoid.Add(2390, "Bog Hatchling");
                NonHumanoid.Add(2391, "Young Bog Dragon");
                NonHumanoid.Add(2392, "Bog Dragon");
                NonHumanoid.Add(2393, "Bog Elder Dragon");
                NonHumanoid.Add(2394, "Legendary Bog Dragon");
                NonHumanoid.Add(2395, "Mire Hatchling");
                NonHumanoid.Add(2396, "Young Mire Dragon");
                NonHumanoid.Add(2397, "Mire Dragon");
                NonHumanoid.Add(2398, "Mire Elder Dragon");
                NonHumanoid.Add(2399, "Legendary Mire Dragon");
                NonHumanoid.Add(2400, "Frost Hatchling");
                NonHumanoid.Add(2401, "Young Frost Dragon");
                NonHumanoid.Add(2402, "Frost Dragon");
                NonHumanoid.Add(2403, "Frost Elder Dragon");
                NonHumanoid.Add(2404, "Legendary Frost Dragon");
                NonHumanoid.Add(2405, "Storm Hatchling");
                NonHumanoid.Add(2406, "Young Storm Dragon");
                NonHumanoid.Add(2407, "Storm Dragon");
                NonHumanoid.Add(2408, "Storm Elder Dragon");
                NonHumanoid.Add(2409, "Legendary Storm Dragon");
                NonHumanoid.Add(2410, "Swamp Hatchling");
                NonHumanoid.Add(2411, "Young Swamp Dragon");
                NonHumanoid.Add(2412, "Swamp Dragon");
                NonHumanoid.Add(2413, "Swamp Elder Dragon");
                NonHumanoid.Add(2414, "Legendary Swamp Dragon");
                NonHumanoid.Add(2415, "Legendary Storm Dragon");
                NonHumanoid.Add(2416, "Legendary Swamp Dragon");
                NonHumanoid.Add(2417, "Legendary Bog Dragon");
                NonHumanoid.Add(2418, "Legendary Bog Dragon");
                NonHumanoid.Add(2419, "Legendary Mire Dragon");
                NonHumanoid.Add(2420, "Legendary Moor Dragon");
                NonHumanoid.Add(2421, "Legendary Swamp Dragon");
                NonHumanoid.Add(2422, "Legendary Storm Dragon");
                NonHumanoid.Add(2423, "Legendary Storm Dragon");
                NonHumanoid.Add(2424, "Watcher");
                NonHumanoid.Add(2425, "Sentinel");
                NonHumanoid.Add(2426, "ERROR_NO_DATA");
                NonHumanoid.Add(2427, "Hell Soul");
                NonHumanoid.Add(2428, "Blighted Soul");
                NonHumanoid.Add(2429, "Malevolent Soul");
                NonHumanoid.Add(2430, "Cursed Soul");
                NonHumanoid.Add(2431, "Fiendish Soul");
                NonHumanoid.Add(2432, "Infernal Soul");
                NonHumanoid.Add(2433, "ERROR_NO_DATA");
                NonHumanoid.Add(2434, "Ooze");
                NonHumanoid.Add(2435, "Mire");
                NonHumanoid.Add(2436, "Muck");
                NonHumanoid.Add(2437, "Goo");
                NonHumanoid.Add(2438, "Gunk");
                NonHumanoid.Add(2439, "Slime");
                NonHumanoid.Add(2440, "Sludge");
                NonHumanoid.Add(2476, "Minotaur");
                NonHumanoid.Add(2477, "Minotaur");
                NonHumanoid.Add(2478, "Minotaur");
                NonHumanoid.Add(2479, "Dolus Thrall");
                NonHumanoid.Add(2480, "Uplander Drudge");
                NonHumanoid.Add(2481, "Kamirian Invader");
                NonHumanoid.Add(2482, "Avalonian");
                NonHumanoid.Add(2483, "Saurilian Warrior");
                NonHumanoid.Add(2484, "Dolus Acolyte");
                NonHumanoid.Add(2485, "Drudge Cleric");
                NonHumanoid.Add(2486, "Kamirian Druid");
                NonHumanoid.Add(2487, "Avalonian Wizard");
                NonHumanoid.Add(2488, "Saurilian Necromancer");
                NonHumanoid.Add(2489, "Squirrel");
                NonHumanoid.Add(2490, "Bobby");
                NonHumanoid.Add(2491, "Grey Squirrel");
                NonHumanoid.Add(2492, "Rabbit");
                NonHumanoid.Add(2493, "Rabbit");
                NonHumanoid.Add(2494, "Rabbit");
                NonHumanoid.Add(2495, "Rabbit");
                NonHumanoid.Add(2496, "Rabbit");
                NonHumanoid.Add(2497, "Sprite");
                NonHumanoid.Add(2498, "Snow Sprite");
                NonHumanoid.Add(2499, "Flame Sprite");
                NonHumanoid.Add(2500, "Storm Sprite");
                NonHumanoid.Add(2501, "Water Sprite");
                NonHumanoid.Add(2502, "Sprite Matriarch");
                NonHumanoid.Add(2503, "Rock Troll");
                NonHumanoid.Add(2504, "Rock Troll Healer");
                NonHumanoid.Add(2505, "Rock Troll Warrior");
                NonHumanoid.Add(2506, "Rock Troll Hunter");
                NonHumanoid.Add(2507, "Rock Troll Mage");
                NonHumanoid.Add(2508, "Rock Troll Chieftan");
                NonHumanoid.Add(2513, "Basilisk");
                NonHumanoid.Add(2514, "Flametongued Basilisk");
                NonHumanoid.Add(2515, "Chilltooth Basilisk");
                NonHumanoid.Add(2516, "Shockscale Baskilisk");
                NonHumanoid.Add(2517, "Blightblood Baskilisk");
                NonHumanoid.Add(2518, "Vitriolic Baskilisk");
                
            }

                #endregion
            #region Humaniod
            if (Humanoid == null)
            {
                Humanoid = new Dictionary<short, string>();
                Humanoid.Add(2240, "Naked Zombie");
                Humanoid.Add(2241, "Zombie");
                Humanoid.Add(2242, "Ghoul");
                Humanoid.Add(2243, "Undead Necromancer");
                Humanoid.Add(2244, "Entombed One");
                Humanoid.Add(2245, "Lich");
                Humanoid.Add(2246, "Crypt Keeper");
                Humanoid.Add(2247, "Wraith");
                Humanoid.Add(2323, "Medusa");
                Humanoid.Add(2324, "Cyclops");
                Humanoid.Add(2325, "Devil");
                Humanoid.Add(2326, "Devil");
                Humanoid.Add(2327, "Tulor");
                Humanoid.Add(2328, "Thief");
                Humanoid.Add(2329, "Thief");
                Humanoid.Add(2330, "Thief");
                Humanoid.Add(2331, "Thief");
                Humanoid.Add(2332, "Thief");
                Humanoid.Add(2333, "Thief");
                Humanoid.Add(2334, "Bounty Hunter");
                Humanoid.Add(2335, "Bounty Hunter");
                Humanoid.Add(2336, "Bounty Hunter");
                Humanoid.Add(2337, "Bounty Hunter");
                Humanoid.Add(2338, "Bounty Hunter");
                Humanoid.Add(2339, "Bounty Hunter");
                Humanoid.Add(2340, "Bounty Hunter");
                Humanoid.Add(2341, "Warrior");
                Humanoid.Add(2342, "Warrior");
                Humanoid.Add(2343, "Warrior");
                Humanoid.Add(2344, "Warrior");
                Humanoid.Add(2345, "Warrior");
                Humanoid.Add(2346, "Warrior");
                Humanoid.Add(2347, "Cleric");
                Humanoid.Add(2348, "Wizard of Light");
                Humanoid.Add(2349, "Priestess");
                Humanoid.Add(2350, "Fuloran");
                Humanoid.Add(2351, "Mist Creature");
                Humanoid.Add(2352, "Seeker");
                Humanoid.Add(2353, "Servant of the Mists");
                Humanoid.Add(2354, "Berserker");
                Humanoid.Add(2355, "Wizard");
                Humanoid.Add(2356, "Guard");
                Humanoid.Add(2357, "Warlock");
                Humanoid.Add(2358, "Ancient One");
                Humanoid.Add(2359, "Mist Mage");
                Humanoid.Add(2360, "Evil Minion");
                Humanoid.Add(2361, "Champion");
                Humanoid.Add(2362, "Protector");
                Humanoid.Add(2363, "Berzerker");
                Humanoid.Add(2441, "Paladin");
                Humanoid.Add(2442, "Paladin");
                Humanoid.Add(2443, "Paladin");
                Humanoid.Add(2444, "Gray Lord");
                Humanoid.Add(2445, "Gray Lord");
                Humanoid.Add(2446, "Gray Lord");
                Humanoid.Add(2447, "Cerberean");
                Humanoid.Add(2448, "Cerberean");
                Humanoid.Add(2449, "Cerberean");
                Humanoid.Add(2450, "Warden");
                Humanoid.Add(2451, "Warden");
                Humanoid.Add(2452, "Warden");
                Humanoid.Add(2453, "Warden");
                Humanoid.Add(2454, "Warden");
                Humanoid.Add(2455, "Warden");
                Humanoid.Add(2456, "Warden");
                Humanoid.Add(2457, "Warden");
                Humanoid.Add(2458, "Warden");
                Humanoid.Add(2459, "Base Soldier");
                Humanoid.Add(2460, "Soldier");
                Humanoid.Add(2461, "Soldier");
                Humanoid.Add(2462, "Soldier");
                Humanoid.Add(2463, "ERROR_NO_DATA");
                Humanoid.Add(2464, "ERROR_NO_DATA");
                Humanoid.Add(2465, "ERROR_NO_DATA");
                Humanoid.Add(2466, "ERROR_NO_DATA");
                Humanoid.Add(2467, "ERROR_NO_DATA");
                Humanoid.Add(2468, "ERROR_NO_DATA");
                Humanoid.Add(2469, "Aegiscian");
                Humanoid.Add(2470, "ERROR_NO_DATA");
                Humanoid.Add(2471, "ERROR_NO_DATA");
                Humanoid.Add(2472, "ERROR_NO_DATA");
                Humanoid.Add(2473, "ERROR_NO_DATA");
                Humanoid.Add(2474, "ERROR_NO_DATA");
                Humanoid.Add(2475, "ERROR_NO_DATA");
                Humanoid.Add(2509, "Nightmare");
                Humanoid.Add(2510, "Borei");
                Humanoid.Add(2511, "Phantom");
                Humanoid.Add(2512, "Shiryo");
                Humanoid.Add(2519, "Orc");
                Humanoid.Add(2520, "Orc Scout");
                Humanoid.Add(2521, "Orc Thug");
                Humanoid.Add(2522, "Orc Bandit");
                Humanoid.Add(2523, "Orc Magnus");
                Humanoid.Add(2524, "Orc Warlord");
            }
                #endregion
        }
        public static string MobNameFromID(short id, out MobileType type)
        {
            if (NonHumanoid == null) Init();
            string name = "Mob Not Found.";
            type = MobileType.None;
            foreach (KeyValuePair<short, string> n in NonHumanoid)
            {
                if (n.Key == id)
                {
                    type = MobileType.NonHumanoid;
                    return n.Value;
                }
            }
            // Not a non humaniod
            foreach (KeyValuePair<short, string> h in Humanoid)
            {
                if (h.Key == id)
                {
                    type = MobileType.Humaniod;
                    return h.Value;
                }
            }
            return name;
        }
        public static bool IsValidHumanoid(ushort graphicID)
        {
            foreach (KeyValuePair<short, string> h in Humanoid)
            {
                if (h.Key == graphicID) return true;
            }
            return false;
        }
        public static bool IsValidNonHumanoid(short graphicID)
        {
            foreach (KeyValuePair<short, string> h in NonHumanoid)
            {
                if (h.Key == graphicID) return true;
            }
            return false;
        }
    }
}
