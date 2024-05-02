using BepInEx;
using UnityEngine;

namespace BunnySpawner
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        /*Filter = SM_Pickup_SparePart_Filter
        Circuit
        Dampener
        Distributor
        Heat Sink
        Fuse
        Piston
        Ion Coil
        Rod
        Wires 
        Bunny = SM_HAB_Prop_PinkBunny*/
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.F8))
            {
                var go = GameObject.Find("SM_HAB_Prop_PinkBunny");
                var player = GameObject.Find("Player");
                Instantiate(go, player.transform.position + player.transform.forward.normalized, player.transform.rotation);
            }
        }
    }
}
