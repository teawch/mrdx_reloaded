using System.ComponentModel;
using MRDX.Game.RestoreSave.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace MRDX.Game.RestoreSave.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Backup Save Folder")]
    [Description("Location to store all the week backups")]
    [DefaultValue("")]
    [FolderPickerParams(
        initialFolderPath: Environment.SpecialFolder.MyDocuments,
        userCanEditPathText: false,
        title: "Choose Folder to Store Backup files",
        okButtonLabel: "Choose Folder",
        fileNameLabel: "SaveBackup",
        multiSelect: false,
        forceFileSystem: true)]
    public string Folder { get; set; } = "";
}

/// <summary>
///     Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
///     Override elements in <see cref="ConfiguratorMixinBase" /> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}