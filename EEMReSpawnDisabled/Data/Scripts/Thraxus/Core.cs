using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Definitions;
using VRage.Game.Components;
using Sandbox.ModAPI;
using VRage.Utils;

namespace EemDisableReSpawnShips.EEMReSpawnDisabled.Data.Scripts.Thraxus
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, priority: int.MaxValue)]
	public class Core : MySessionComponentBase
	{
		public override void LoadData()
		{
			base.LoadData();
			foreach (KeyValuePair<string, MyRespawnShipDefinition> k in MyDefinitionManager.Static.GetRespawnShipDefinitions())
			{
				if (k.Key == "Ibis_Respawnship")
				{
					k.Value.Enabled = false;
					k.Value.Prefab.AvailableInSurvival = false;
					k.Value.UseForSpace = false;
					k.Value.UseForPlanetsWithAtmosphere = false;
					k.Value.UseForPlanetsWithoutAtmosphere  = false;
					continue;
				}
				if (k.Key == "Little_Bird_Respawnship")
				{
					k.Value.Enabled = false;
					k.Value.UseForSpace = false;
					k.Value.UseForPlanetsWithAtmosphere = false;
					k.Value.UseForPlanetsWithoutAtmosphere = false;
					continue;
				}
				if (k.Key == "M3_Miner_Respawnship")
				{
					k.Value.Enabled = false;
					k.Value.UseForSpace = false;
					k.Value.UseForPlanetsWithAtmosphere = false;
					k.Value.UseForPlanetsWithoutAtmosphere = false;
					continue;
				}
				if (k.Key == "Range_Runner_Respawncar")
				{
					k.Value.Enabled = false;
					k.Value.UseForSpace = false;
					k.Value.UseForPlanetsWithAtmosphere = false;
					k.Value.UseForPlanetsWithoutAtmosphere = false;
					continue;
				}
			}
		}
	}
}
