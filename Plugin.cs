using BepInEx;
using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;
using Utilla;
using GorillaNetworking;

namespace RainToggle
{
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.6.3")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [Description("HauntedModMenu")]
    public class Plugin : BaseUnityPlugin
    {
        GameObject rainGOF;
        GameObject rainGOF2;

        void OnEnable()
        {
            Utilla.Events.GameInitialized += OnGameInitialized;
            HarmonyPatches.ApplyHarmonyPatches();
            rainGOF.SetActive(false);
            rainGOF2.SetActive(false);
        }

        void OnDisable()
        {
            rainGOF.SetActive(true);
            rainGOF2.SetActive(true);
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            rainGOF = GameObject.Find("Level/forest/WeatherDayNight/rain");
            rainGOF2 = GameObject.Find("Level/forest/WeatherDayNight/rain/DependentStuff");
        }
    }
}
