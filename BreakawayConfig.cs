using TaleWorlds.CampaignSystem.CampaignBehaviors;
using HarmonyLib;

namespace Brut.Breakaway
{
	public static class BreakawayConfig
	{
		private static BreakawaySettings instance;

		public static BreakawaySettings Settings
		{
			get
			{
				if (instance == null)
				{
					Refresh();
				}
				return instance;
			}
		}
		public static void Refresh()
		{
			instance = BreakawaySettings.Instance;
		}
	}
}
