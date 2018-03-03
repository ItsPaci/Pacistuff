using Terraria;
using Terraria.ModLoader;

namespace Pacistuff.Buffs
{
	public class KillerOld : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("KillerOld");
			Description.SetDefault("Melee damage bosted by 1000%, Crit doubled, Speed by 100% it has a catch tho.");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.statDefense -= 99999;
		player.meleeDamage += 10f;
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