using ColossalFramework.Plugins;

namespace CheatCodes.UserSettings
{
    public static class CheatCodeSettings
    {
        public static void SaveSettings()
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Cheat Codes Saved!");
        }
    }
}
