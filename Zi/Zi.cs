using Smod2;
using Smod2.Attributes;
using scp4aiur;

namespace Zi
{
	[PluginDetails(
		author = "Albertinchu",
		name = "Zi",
		description = "si un Zombie mata a un jugador este se transforma en zombie.",
		id = "albertinchu.zi",
		version = "1.0.0",
		SmodMajor = 3,
		SmodMinor = 0,
		SmodRevision = 0
		)]
	public class Zi : Plugin
	{
		public override void OnDisable()
		{
			this.Info("ZombieInfection - Desactivado");
		}

		public override void OnEnable()
		{
			this.Info("ZombieInfection - Activado.");
		}

		public override void Register()
		{
			Timing.Init(this);
			this.AddEventHandlers(new PlayerEvents(this));
		}
	}
}

