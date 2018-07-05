using ColossalFramework.Plugins;
using ColossalFramework.UI;
using UnityEngine;

namespace CheatCodes.UI
{
    public class CheatCodesUserInterfaceComponent : MonoBehaviour
    {

        private static CheatCodesUserInterfaceComponent component = null;

        private bool CtrlCmdDown
        {
            get
            {
                return Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl) ||
                       Input.GetKey(KeyCode.LeftCommand) || Input.GetKey(KeyCode.RightCommand);
            }
        }

        private bool ShiftDown
        {
            get
            {
                return Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C) && CtrlCmdDown && ShiftDown)
            {
                //Todo: Load UI Panel with input field and button
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Cheat Codes Activated");

                UIView view = UIView.GetAView();
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "GetAllView");

                UIPanel panel = view.AddUIComponent(typeof(UIPanel)) as UIPanel;
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Created Panel");

                panel.name = "CheatSettingsPanel";
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Panel has a name");
                UILabel title = panel.AddUIComponent<UILabel>();
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Created Label");
                title.text = "Type in your cheat code.";
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Label has been added to panel");

                //GameObject obj = new GameObject("CheatSettingsPanel");
                //component = obj.AddComponent<CheatCodesUserInterfaceComponent>();
            }
        }
    }
}