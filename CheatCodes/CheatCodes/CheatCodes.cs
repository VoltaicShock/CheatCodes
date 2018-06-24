using ICities;
using ColossalFramework.Plugins;

namespace CheatCodesMod
{
    public class CitiesSkylinesCheatCodes : IUserMod
    {
        public string Name
        {
            get { return "Cities Skylines Cheat Codes"; }
        }

        public string Description
        {
            get { return "Cities Skylines Cheat Codes Mod"; }
        }
    }

    public class UnlimitedMoneyEconomy : EconomyExtensionBase
    {
        public override int OnAddResource(EconomyResource resource, int amount, Service service, SubService subService, Level level)
        {
            return base.OnAddResource(resource, 5000000, service, subService, level);
        }

        //public override long OnUpdateMoneyAmount(long internalMoneyAmount)
        //{
        //    return internalMoneyAmount + 9999;
        //}

        //public override bool OverrideDefaultPeekResource
        //{
        //    get { return true; }
        //}

        //public override int OnPeekResource(EconomyResource resource, int amount)
        //{
        //    return amount;
        //}
    }

    public class MoreDemand : DemandExtensionBase
    {
        //public override int OnCalculateResidentialDemand(int originalDemand)
        //{
        //    if (originalDemand < 50)
        //        DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Residential Demand: " + originalDemand);

        //    return originalDemand;
        //}

        //public override int OnCalculateCommercialDemand(int originalDemand)
        //{
        //    if (originalDemand > 50)
        //        DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Commercial Demand: " + originalDemand);

        //    return originalDemand;
        //}

        //public override int OnCalculateWorkplaceDemand(int originalDemand)
        //{
        //    if (originalDemand > 50)
        //        DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Workplace Demand: " + originalDemand);

        //    return originalDemand;
        //}
    }
}