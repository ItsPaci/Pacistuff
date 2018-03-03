using Pacistuff.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items.Weapons
{
	public class CrystalCutter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It breaks light in beatiful ways");

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
			item.knockBack = 2.5f;
			item.damage = 15;
			item.rare = 5;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<CrystalCutterProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amber, 5);
			recipe.AddIngredient(ItemID.Diamond, 5);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(ItemID.Sapphire, 5);
			recipe.AddIngredient(ItemID.Topaz, 5);
			recipe.AddIngredient(ItemID.Amethyst, 5);
			recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddIngredient(null, "ExtractedSoul",3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
