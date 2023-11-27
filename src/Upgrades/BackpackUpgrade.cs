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
			yield return new WaitForSeconds(1);
			UnlockedUpgrades.Instance.BackpackUpgrade = true;

			PlayerControllerB[] playerControllers = GameObject.FindObjectsOfType<PlayerControllerB>();

			foreach (PlayerControllerB playerController in playerControllers)
			{
				GrabbableObject[] grabbableObjects = playerController.ItemSlots;
				grabbableObjects.Append<GrabbableObject>(grabbableObjects[0]);	// Copy first
				grabbableObjects.Append<GrabbableObject>(grabbableObjects[0]);	// Copy first
			}

		}
	}
}
