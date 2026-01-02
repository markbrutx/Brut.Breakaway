using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace Brut.Breakaway.Patches.Patches
{
	[HarmonyPatch(typeof(Hero), "IsFriend")]
	public static class HeroIsFriendPatch
	{
		public static bool Prefix(Hero otherHero, Hero __instance, ref bool __result)
		{
			__result = CharacterRelationManager.GetHeroRelation(__instance, otherHero) > BreakawayConfig.Settings.FriendThreshold;
			return false;
		}
	}

	[HarmonyPatch(typeof(Hero), "IsEnemy")]
	public static class HeroIsEnemyPatch
	{
		public static bool Prefix(Hero otherHero, Hero __instance, ref bool __result)
		{
			__result = CharacterRelationManager.GetHeroRelation(__instance, otherHero) < BreakawayConfig.Settings.EnemyThreshold;
			return false;
		}
	}
}
