using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class SupersonicStone : ModItem
	{	
			public override void SetDefaults()
		{
			item.width = 21;
			item.height = 14;
			item.maxStack = 30;
			item.rare = 11;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supersonic Stone");
			Tooltip.SetDefault("Once owned by a blue speed mouse.\n" +
"+600% Speed\n" +
"+600% Acceleration\n" +
"Not Consumable");
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("Supersonic"), 1800);
			player.AddBuff(BuffID.CursedInferno, 1800);
			player.AddBuff(BuffID.Ichor, 1800);
			player.AddBuff(BuffID.BrokenArmor, 1800);
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ExtractedSoul",10);
			recipe.AddIngredient(null,"PureBar",9);
			recipe.AddIngredient(ItemID.Bottle,5);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(ItemID.Moonglow, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}