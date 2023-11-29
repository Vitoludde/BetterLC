using BepInEx;
using BepInEx.Logging;
using BetterLC.src;
using BetterLC.src.Storage;
using GameNetcodeStuff;
using HarmonyLib;
using LethalAPI;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BetterLC
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("LethalAPI")]
    [BepInProcess("Lethal Company.exe")]
    public class Plugin : BaseUnityPlugin
    {
		public static int MaxPlayers = 20;
		private Harmony harmony;
		public static ManualLogSource Log;
        private void Awake()
        {
			Log = Logger;

			harmony = new Harmony("BetterLC");
			harmony.PatchAll();

			AssetLoaderAPI.OnLoadedAssets += AddUpgrades.LoadUpgrades;

			// Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

		private void OnDestroy()
		{
			ServerAPI.SetModdedClientsOnly();
		}
    }
}
