using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class PerfectSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Perfect Soul");
			Tooltip.SetDefault("'The essence of all perfect creatures'");
			// ticksperframe, frameCount
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 28));
			ItemID.Sets.AnimatesAsSoul[item.type] = false;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		// TODO -- Velocity Y smaller, post NewItem?
		public override void SetDefaults()
		{
			Item refItem = new Item();
			refItem.SetDefaults(ItemID.SoulofSight);
			item.width = refItem.width;
			item.height = refItem.height;
			item.maxStack = 9999;
			item.value = 1000;
			item.rare = 11;
		}

		public override void PostUpdate()
		{
			Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
		}
	}
}