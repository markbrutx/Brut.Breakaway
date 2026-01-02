using TaleWorlds.CampaignSystem;
using HarmonyLib;
using Brut.Breakaway.Common;
using Brut.Breakaway.Behaviours;

namespace Brut.Breakaway
{
    public class BreakawaySubModule : ModSubModule
    {
        protected override void AddBehaviours(CampaignGameStarter gameInitializer)
        {
            gameInitializer.AddBehavior(new UtilityBehaviour());
            gameInitializer.AddBehavior(new LordRebellionBehaviour());
            gameInitializer.AddBehavior(new NationalRebellionBehaviour());
            gameInitializer.AddBehavior(new AnarchyRebellionBehaviour());
            gameInitializer.AddModel(new BreakawaySettlementLoyaltyModel());
        }

        protected override void PrintPatchingError()
        {
            base.PrintPatchingError();
        }
    }

    [HarmonyPatch(typeof(BreakawaySubModule), "PrintPatchingError")]
    public class BreakawaySubModulePatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
