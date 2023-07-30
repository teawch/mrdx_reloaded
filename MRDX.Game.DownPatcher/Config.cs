using MRDX.Game.DownPatcher.Template.Configuration;
using System.ComponentModel;

namespace MRDX.Game.DownPatcher.Configuration
{
    public class Config : Configurable<Config>
    {
        [DisplayName("Version")]
        [Description("MRDX Version Selection")]
        [DefaultValue(MRDXVersion.Version_1_0_0_2)]
        public MRDXVersion VersionSelected { get; set; } = MRDXVersion.Version_1_0_0_2;

        public enum MRDXVersion
        {
            Version_1_0_0_0,
            Version_1_0_0_1,
            Version_1_0_0_2,
        }
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}