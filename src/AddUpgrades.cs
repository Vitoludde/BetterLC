//
// Credits to https://github.com/Malcolm-Q/LC-LateGameUpgrades/tree/main!
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterLC.src.Storage;
using BetterLC.src.Upgrades;
using LethalAPI;
using UnityEngine;

namespace BetterLC.src
{
	public class AddUpgrades
	{
		public static List<Item> upgradesList = new List<Item>();

		public static void LoadUpgrades() {
            Plugin.Log.LogInfo($"[{PluginInfo.PLUGIN_GUID}] AddUpgrades - Start of adding");

			GameObject Upgrades = new GameObject("UnlockedUpgrades");
			Upgrades.AddComponent<UnlockedUpgrades>();

			Item BackpackUpgrade = AssetLoaderAPI.GetLoadedAssetByName<Item>("assets/myassets/betterlc/backpack_item.asset");
			BackpackUpgrade.spawnPrefab.AddComponent<BackpackUpgrade>();
			ItemAPI.RegisterShopItem(BackpackUpgrade, null, null, null);
			//ItemAPI.RegisterShopItem(BackpackUpgrade, BackpackUpgrade.creditsWorth);
			upgradesList.Add(BackpackUpgrade);

            Plugin.Log.LogInfo($"[{PluginInfo.PLUGIN_GUID}] AddUpgrades - Finished adding");

		}
	}
}
