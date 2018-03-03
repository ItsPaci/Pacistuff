using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items
{
	public class BigSacrificeStone : ModItem
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
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big Sacrifice Stone");
			Tooltip.SetDefault("This might be a bad life choice...\n" +
"+5000% Melee Damage");
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("BigSacrifice"), 600);
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"PerfectSoul",1);
			recipe.SetResult(this,2);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ImpureSoul",5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}