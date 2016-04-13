namespace IconRestorer.Code
{
    public class IconRestorer
    {
        private readonly DesktopRegistry registry = new DesktopRegistry();
        private readonly Desktop desktop = new Desktop();
        private readonly Storage storage = new Storage();


        public void SavePositions()
        {
            var registryValues = registry.GetRegistryValues();

            var iconPositions = desktop.GetIconsPositions();

            storage.SaveIconPositions(iconPositions, registryValues);
        }

        public void RestorePositions()
        {
            var registryValues = storage.GetRegistryValues();

            registry.SetRegistryValues(registryValues);

            var iconPositions = storage.GetIconPositions();

            desktop.SetIconPositions(iconPositions);

            desktop.Refresh();
        }

       
    }
}
