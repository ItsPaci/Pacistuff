using Terraria;
using Terraria.ModLoader;

namespace Pacistuff.Buffs
{
	public class Supersonic : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Supersonic");
			Description.SetDefault("Speed bosted by 600%, it has a catch tho.");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.jumpSpeedBoost -= 1.99f;
		player.extraFall += 10;
		player.maxRunSpeed += 6f;
		player.runAcceleration += 6f; 
		player.meleeSpeed -= 2f;
		player.meleeDamage -= 2f;
		}
	}
}
			//player.lifeRegen++;
			//player.meleeCrit += 2;
			//player.meleeDamage += 0.051f;
			//player.meleeSpeed += 0.051f;
			//player.statDefense += 3;