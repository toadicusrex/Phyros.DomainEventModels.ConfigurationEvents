namespace Phyros.DomainEventModels.ConfigurationEvents.FeatureToggle
{
	public class FeatureToggleChanged
	{
		public string Name { get; set; }
		public string OrganizationalUnit { get; set; }
		public bool Enabled { get; set; }
		public bool Locked { get; set; }
	}
}
