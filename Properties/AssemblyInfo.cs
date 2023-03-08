using System.Reflection;
using bonelab_template;
using MelonLoader;

[assembly: AssemblyTitle(bonelab_template.Main.Description)]
[assembly: AssemblyDescription(bonelab_template.Main.Description)]
[assembly: AssemblyCompany(bonelab_template.Main.Company)]
[assembly: AssemblyProduct(bonelab_template.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + bonelab_template.Main.Author)]
[assembly: AssemblyTrademark(bonelab_template.Main.Company)]
[assembly: AssemblyVersion(bonelab_template.Main.Version)]
[assembly: AssemblyFileVersion(bonelab_template.Main.Version)]
[assembly: MelonInfo(typeof(bonelab_template.Main), bonelab_template.Main.Name, bonelab_template.Main.Version, bonelab_template.Main.Author, bonelab_template.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]