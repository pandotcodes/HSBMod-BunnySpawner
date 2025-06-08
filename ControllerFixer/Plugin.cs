using BepInEx;
using HarmonyLib;

namespace ControllerFixer
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
    [HarmonyPatch(typeof(SteamUtils), "IsSteamDeck")]
    public static class SteamUtils_IsSteamDeck_Patch
    {
        public static void Postfix(ref bool __result)
        {
            __result = true;
        }
    }
}
