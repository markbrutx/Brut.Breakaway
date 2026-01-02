using HarmonyLib;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.Settlements;

namespace Brut.Breakaway.Patches.Patches
{
	[HarmonyPatch(typeof(RebellionsCampaignBehavior), "DailyTickSettlement")]
	public static class RebellionsCampaignBehaviorPatch
	{
		public static void Prefix(Settlement settlement, RebellionsCampaignBehavior __instance)
		{
			AccessTools.Field(typeof(RebellionsCampaignBehavior), "_rebellionEnabled").SetValue(__instance, BreakawayConfig.Settings.SettlementRebellionsEnabled);
		}
	}
}
