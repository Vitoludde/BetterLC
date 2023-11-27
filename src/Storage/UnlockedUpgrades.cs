using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Netcode;

namespace BetterLC.src.Storage
{
	public class UnlockedUpgrades : NetworkBehaviour
	{
		public static UnlockedUpgrades Instance;
		public bool BackpackUpgrade = false;
	}
}
