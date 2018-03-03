using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class SuperStone : ModItem
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
			DisplayName.SetDefault("Super Stone");
			Tooltip.SetDefault("An OP combination");
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("Superbuffed"), 1800);
			player.AddBuff(BuffID.CursedInferno, 1800);
			player.AddBuff(BuffID.Ichor, 1800);
			player.AddBuff(BuffID.BrokenArmor, 1800);
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ExtractedSoul",30);
			recipe.AddIngredient(null,"ImpureSoul",3);
			recipe.AddIngredient(null,"PureBar",15);
			recipe.AddIngredient(null,"KillerStone");
			recipe.AddIngredient(null,"SupersonicStone");
			recipe.AddIngredient(ItemID.Bottle,5);
			recipe.AddIngredient(ItemID.Sapphire, 15);
			recipe.AddIngredient(ItemID.Ruby, 15);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}