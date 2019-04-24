using System.Collections.Generic;
using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;
using scp4aiur;

namespace Zi
{
	partial class PlayerEvents : IEventHandlerPlayerDie
	{
		private Zi plugin;

		public PlayerEvents(Zi plugin)
		{
			this.plugin = plugin;
		}

		public void OnPlayerDie(PlayerDeathEvent ev)
		{
			if ((ev.Killer.TeamRole.Role == Role.SCP_049_2) && (ev.Killer.SteamId != ev.Player.SteamId))
			{
				ev.SpawnRagdoll = false;
				Timing.Run(Zi(ev.Player));
			}
		}

		public static IEnumerable<float> Zi(Player player)
		{
			yield return 0.2f;
			player.ChangeRole(Role.SCP_049_2);
		}
	}
}
