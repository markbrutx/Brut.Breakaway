using HarmonyLib;
using SandBox.View.Map;

namespace Brut.Breakaway.Patches.Patches
{
	[HarmonyPatch(typeof(MapScreen), "OnEscapeMenuToggled")]
	public static class MapScreenPatch
	{
		public static void Postfix(bool isOpened = false)
		{
			if (!isOpened)
			{
				BreakawayConfig.Refresh();
			}
		}
	}
}
