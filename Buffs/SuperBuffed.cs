using Terraria;
using Terraria.ModLoader;

namespace Pacistuff.Buffs
{
	public class Superbuffed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Superbuffed");
			Description.SetDefault("This is way too op tbh.");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.extraFall += 10;
		player.maxRunSpeed += 3f;
		player.runAcceleration += 3f; 
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