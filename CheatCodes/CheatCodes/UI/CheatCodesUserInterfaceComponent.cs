using ColossalFramework.Plugins;
using UnityEngine;

namespace CheatCodes.UI
{
    public class CheatCodesUserInterfaceComponent : MonoBehaviour
    {
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
            }
        }
    }
}