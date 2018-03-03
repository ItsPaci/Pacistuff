using Pacistuff.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items.Weapons
{
	public class Infernia : ModItem
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
			item.knockBack = 2.5f;
			item.damage = 25;
			item.rare = 3;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<InferniaProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowChest, 1);
			recipe.AddIngredient(ItemID.GoldenKey, 3);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(null, "ExtractedSoul",3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
