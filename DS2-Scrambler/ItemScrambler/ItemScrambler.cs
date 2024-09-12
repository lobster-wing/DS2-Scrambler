using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulsFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DS2_Scrambler
{
    public class ItemScrambler
    {
        public Random rand;
        public Regulation regulation;
        public ScramblerData Data;

        public bool T_Ignore_Keys = false;
        public bool T_Ignore_Tools = false;
        public bool T_Include_Boss_Treasure = false;
        public bool T_Include_Character_Treasure = false;
        public bool T_Include_Covenant_Treasure = false;
        public bool T_Include_Bird_Treasure = false;
        public bool T_Include_Event_Treasure = false;
        public bool T_Ensure_Lifegems = false;
        public bool T_Retain_Shop_Spread = false;

        public ItemScrambler(Random random, Regulation reg, ScramblerData scramblerData)
        {
            Data = scramblerData;
            rand = random;
            regulation = reg;
        }

        public Regulation Scramble_Loot(bool scrambleLoot, bool scrambleEnemyDrops, bool scrambleShops, bool scrambleBossTrades, bool includeBossTreasure, bool includeCharacterTreasure, bool includeCovenantTreasure, bool includeBirdTreasure, bool includeEventTreasure, bool ignoreKeys, bool ignoreTools, bool ensureLifegems, bool retainShopSpread)
        {
            if (!scrambleLoot)
            {
                return regulation;
            }

            T_Ignore_Keys = ignoreKeys;
            T_Ignore_Tools = ignoreTools;
            T_Include_Boss_Treasure = includeBossTreasure;
            T_Include_Character_Treasure = includeCharacterTreasure;
            T_Include_Covenant_Treasure = includeCovenantTreasure;
            T_Include_Bird_Treasure = includeBirdTreasure;
            T_Include_Event_Treasure = includeEventTreasure;
            T_Ensure_Lifegems = ensureLifegems;
            T_Retain_Shop_Spread = retainShopSpread;

            CollectLocationsAndItems();

            return regulation;
        }

        private void CollectLocationsAndItems()
        {

        }

    }
}
