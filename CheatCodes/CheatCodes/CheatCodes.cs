using CheatCodes.UserSettings;
using ICities;

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

        public void OnSettingsUI(UIHelperBase helper)
        {   
            UIHelperBase groupCheatCodeSettings = helper.AddGroup("Cheat Code Settings"); 

            groupCheatCodeSettings.AddSpace(250);
            groupCheatCodeSettings.AddButton("Save Settings", CheatCodeSettings.SaveSettings);
        }
    }
}