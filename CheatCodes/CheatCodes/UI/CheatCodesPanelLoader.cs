using ICities;

namespace CheatCodes.UI
{
    class CheatCodesPanelLoader : ILoadingExtension
    {
        public void OnCreated(ILoading loading)
        {

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
            if (component != null)
            {
                Object.Destroy(component.gameObject);
                component = null;
            }
        }
    }
}
