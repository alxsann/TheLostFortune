using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune
{
    public class ItemStats
    {
        //   1     2       3          4           5           6               7                 8
        // Name, Type, MinDamage, MaxDamage, BonusHealth, BonusMana, BonusPhysicalDamage, BonusMagicalDamage,
        //      9           10              11               12         13    14
        // BonusResist, BonusDodge, CurrentDurability, MaxDurability, Image, Lore
        // Items position i denne liste er den samme som dens Id.
        private static List<object[]> Items = new List<object[]>();
        static void GenerateItems()
        {
            //string name = Items[1][0].ToString();
            // One Hand Swords
            // Normal
            Items.Add(new object[] { "Rusted Sword", "One Handed Sword", 2, 5, 0, 0, 0, 0, 0, 0, 10, 10, Properties.Resources.RustedSwordImage, "Old Rusted and heavily worn sword." });
            Items.Add(new object[] { "Short Sword", "One Handed Sword", 4, 7, 0, 0, 0, 0, 0, 0, 15, 15, Properties.Resources.BilledeHer, "A short sword with fine quality." });
            Items.Add(new object[] { "Long Sword", "One Handed Sword", 7, 10, 0, 0, 0, 0, 0, 0, 18, 18, Properties.Resources.BilledeHer, "A long sword with fine quality." });
            // Rare
            Items.Add(new object[] { "The Hungering Cold", "One Handed Sword", 30, 42, 5, 0, 0, 0, 50, 0, 60, 60, Properties.Resources.DifferentSwords, "Worn by the frost king Hugar, this sword has been born during the cold winter in the frozen caves and therefore it gives great magical resistance." });
            Items.Add(new object[] { "Hungarian, the devil’s lost tongue", "One Handed Sword", 24, 32, 30, 0, 5, 0, 10, 0, 50, 50, Properties.Resources.BilledeHer, "Hungarian is the strongest devil in these lands, he lost his tongue centuries ago and yet it still holds great power!" });
            Items.Add(new object[] { "Maladath, Runed blade of the dark flight", "One handed Sword", 15, 22, 10, 0, 5, 0, 0, 20, 40, 40, Properties.Resources.BilledeHer, "Maladath was the great beast tamer, when his companion died in combat he engraved this sword with the blood of the tiger." });

            // Two Handed Swords
            // Normal
            Items.Add(new object[] { "Great Sword", "Two Handed Sword", 12, 24, 0, 0, 0, 0, 0, 0, 0, 0, Properties.Resources.BilledeHer, "A heavy sword crafted in the far lands." });
            // Rare
            Items.Add(new object[] { "Subrami, Sharpened divine stones", "Two Handed Sword", 50, 70, 50, 20, 10, 10, 20, 0, 60, 60, Properties.Resources.BilledeHer, "The divine stones are filled with power so great that they are thhought of as a myth." });
            Items.Add(new object[] { "Sword of Destiny", "Two Handed Sword", 15, 30, 20, 10, 5, 0, 10, 0, 50, 50, Properties.Resources.BilldeHer, "Those who believe in the old gods says that the destiny of the first men is carved within." });

            // One Handed Axes
            // Normal
            Items.Add(new object[] { "Short Axe", "One Handed Axe", 3, 9, 0, 0, 0, 0, 0, 0, 15, 15, Properties.Resources.BilledeHer, "A short axe in fine condition." });
            Items.Add(new object[] { "Double bladed axe", "One Handed Axe", 5, 13, 0, 0, 0, 0, 0, 18, 18, Properties.Resources.BilledeHer, "A axe with blades on both sides." });
            // Rare
            Items.Add(new object[] { "Gallaths lost blade", "One Handed Axe", 10, 20, 0, 0, 8, 0, 10, 0, 20, 20, Properties.Resources.BilledeHer, "Gallaths who is a dwarven knight." });
        }

        public object[] GetItem(int itemId)
        {
            return Items[itemId];
        }
    }
}
