using Pacistuff.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pacistuff.Items.Weapons
{
	public class Naturalia : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It grows vines around your hand");

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
			item.damage = 20;
			item.rare = 2;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<NaturaliaProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IvyChest, 1);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddIngredient(ItemID.GoldenKey, 3);
			recipe.AddIngredient(null, "ExtractedSoul",3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
