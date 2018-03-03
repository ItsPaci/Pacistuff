using Pacistuff.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items.Weapons
{
	public class Superclipse : ModItem
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
			item.useTime = 15;
			item.shootSpeed = 16f;
			item.knockBack = 1f;
			item.damage = 59;
			item.rare = 2;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<SuperclipseProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Eclipse",1);
			recipe.AddIngredient(ItemID.HallowedBar,10);
			recipe.AddIngredient(ItemID.SoulofMight,5);
			recipe.AddIngredient(ItemID.SoulofSight,5);
			recipe.AddIngredient(ItemID.SoulofFright,5);
			recipe.AddIngredient(null, "ExtractedSoul",10);
			recipe.AddIngredient(null, "ImpureSoul",3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
