using ICities;
using UnityEngine;

namespace CheatCodes.UI
{
    public class CheatCodesOnDemandLoader : ILoadingExtension
    {
        private static CheatCodesUserInterfaceComponent component = null;

        public void OnCreated(ILoading loading)
        {
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.LoadGame || mode == LoadMode.NewGame)
            {
                GameObject obj = new GameObject("CheatCodesUserInterfaceComponent");
                component = obj.AddComponent<CheatCodesUserInterfaceComponent>();
            }
        }

        public void OnLevelUnloading()
        {
            if (component != null)
            {
                Object.Destroy(component.gameObject);
                component = null;
            }
        }

        public void OnReleased()
        {
        }
    }
}