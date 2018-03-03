using Terraria;
using Terraria.ModLoader;

namespace Pacistuff.Buffs
{
	public class Killer : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Killer");
			Description.SetDefault("Melee damage bosted by 1000%, Crit doubled, Speed by 100% it has a catch tho.");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.meleeDamage += 10f;
		player.meleeSpeed += 1f;
		player.meleeCrit += 50; 
		player.jumpSpeedBoost -= 4f;
		player.statDefense -= 75;
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