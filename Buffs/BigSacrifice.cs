using Terraria;
using Terraria.ModLoader;

namespace Pacistuff.Buffs
{
	public class BigSacrifice : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Big Sacrifice");
			Description.SetDefault("This was a poor life choice.");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.statDefense -= 999999;
		player.meleeDamage += 59f;
		player.meleeSpeed += 1f;
		player.meleeCrit += 50;
		}
	}
}
			//player.lifeRegen++;
			//player.meleeCrit += 2;
			//player.meleeDamage += 0.051f;
			//player.meleeSpeed += 0.051f;
			//player.statDefense += 3;
			//player.jumpSpeedBoost -= 1.99f;
			//player.extraFall += 10;
			//player.maxRunSpeed += 6f;
			//player.runAcceleration += 6f; 