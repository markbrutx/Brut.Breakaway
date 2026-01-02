using TaleWorlds.CampaignSystem.GameComponents;

namespace Brut.Breakaway
{
	public class BreakawaySettlementLoyaltyModel : DefaultSettlementLoyaltyModel
	{
		public override int RebellionStartLoyaltyThreshold
		{
			get
			{
				return BreakawayConfig.Settings.SettlementRebellionStartLoyaltyThreshold;
			}
		}
	}
}
