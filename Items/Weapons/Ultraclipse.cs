using Pacistuff.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items.Weapons
{
	public class Ultraclipse : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It burns your hand, making you use it as much as possible");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 0f;
			item.damage = 200;
			item.rare = 10;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<UltraclipseProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Superclipse");
			recipe.AddIngredient(ItemID.LunarBar,10);
			recipe.AddIngredient(ItemID.FragmentSolar,15);
			recipe.AddIngredient(ItemID.Terrarian);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
