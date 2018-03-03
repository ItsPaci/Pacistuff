using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class KillerStone : ModItem
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
			DisplayName.SetDefault("Killer Stone");
			Tooltip.SetDefault("Once owned by a masked knife user.\n" +
"+1000% Melee Damage\n" +
"+100% Melee Speed\n" +
"+100% Crit\n" +
"Not Consumable");
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("Killer"), 1800);
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
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.Fireblossom, 25);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}