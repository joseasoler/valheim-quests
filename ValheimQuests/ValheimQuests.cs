using System.Diagnostics;
using System.Reflection;
using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;

namespace VQ
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(Jotunn.Main.ModGuid)]
	[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Patch)]
	internal class ValheimQuests : BaseUnityPlugin
	{
		private const string PluginGuid = "joseasoler.ValheimQuests";
		private const string PluginName = "ValheimQuests";
		private const string PluginVersion = "0.0.1";

		public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

		private void Awake()
		{
			VersionCheck();
		}

		[Conditional("DEBUG")]
		private static void VersionCheck()
		{
			var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
			if (assemblyVersion != PluginVersion)
			{
				Jotunn.Logger.LogWarning($"Version mismatch. Plugin: {PluginVersion}, assembly: {assemblyVersion}");
			}
		}
	}
}