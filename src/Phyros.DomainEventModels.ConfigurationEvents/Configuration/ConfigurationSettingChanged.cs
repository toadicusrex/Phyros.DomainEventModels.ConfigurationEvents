namespace Phyros.DomainEventModels.ConfigurationEvents.Configuration
{
	public class ConfigurationSettingChanged
	{
		public string Key { get; set; }
		public string OrganizationalUnit { get; set; }
	}
}
