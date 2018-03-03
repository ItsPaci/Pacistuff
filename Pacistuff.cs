using Terraria.ModLoader;

namespace Pacistuff
{
	class Pacistuff : Mod
	{
		public Pacistuff()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
