using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("TweakScaleCompanion_PKMC")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(TweakScaleCompanion.PKMC.LegalMamboJambo.Company)]
[assembly: AssemblyProduct(TweakScaleCompanion.PKMC.LegalMamboJambo.Product)]
[assembly: AssemblyCopyright(TweakScaleCompanion.PKMC.LegalMamboJambo.Copyight)]
[assembly: AssemblyTrademark(TweakScaleCompanion.PKMC.LegalMamboJambo.Trademark)]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

//[assembly: AssemblyVersion("1.0.*")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
[assembly: AssemblyVersion(TweakScaleCompanion.PKMC.Version.Number)]
[assembly: AssemblyFileVersion(TweakScaleCompanion.PKMC.Version.Number)]
[assembly: KSPAssembly("TweakScaleCompanion_PKMC", TweakScaleCompanion.PKMC.Version.major, TweakScaleCompanion.PKMC.Version.minor)]
[assembly: KSPAssemblyDependency("KSPe.Light.TweakScale", 2, 5)]
[assembly: KSPAssemblyDependency("Scale", 2, 4)]
