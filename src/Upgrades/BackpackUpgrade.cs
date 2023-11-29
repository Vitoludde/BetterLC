using BetterLC.src.Storage;
using GameNetcodeStuff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Netcode;
using UnityEngine;
using LethalAPI;

namespace BetterLC.src.Upgrades
{
	internal class BackpackUpgrade : NetworkBehaviour
	{

		void Start()
		{
			StartCoroutine(LateApply());
		}

		private IEnumerator LateApply()
		{
			Plugin.Log.LogMessage($"[{PluginInfo.PLUGIN_GUID}] BackpackScript - LateApply");

			yield return new WaitForSeconds(1);
			UnlockedUpgrades.Instance.BackpackUpgrade = true;

			InventoryAPI.SetInventorySize(6);
		}
	}
}
