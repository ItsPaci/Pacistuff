using Terraria;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class MyGloablNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.NextBool(12)) // Main.rand.NextBool(5) is true 1:5 times , or true with a 20% chance
			{
				Item.NewItem(npc.getRect(), mod.ItemType("ExtractedSoul"), 1); // drop 1 of a custom item
			}
		}
	}
}