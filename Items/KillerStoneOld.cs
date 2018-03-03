using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class KillerStoneOld : ModItem
	{	
			public override void SetDefaults()
		{
			item.width = 21;
			item.height = 14;
			item.maxStack = 30;
			item.rare = 10;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Killer Stone Old");
			Tooltip.SetDefault("Once owned by a masked knife user.\n" +
"+1000% Melee Damage\n" +
"+100% Melee Speed\n" +
"+100% Crit\n" +
"Not Consumable");
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("KillerOld"), 36000);
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ExtractedSoul",5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}