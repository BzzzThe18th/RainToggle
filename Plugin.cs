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
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.6.7")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        GameObject rainGOF;
        GameObject rainGOF2;
        GameObject snowGO;

        void Start()
        {
            Events.GameInitialized += OnGameInitialized;
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            rainGOF = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/rain");
            rainGOF2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/rain/DependentStuff");
            snowGO = GameObject.Find("Environment Objects/LocalObjects_Prefab/Mountain/Weather/snow (1)");
        }

        void OnEnable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            rainGOF?.SetActive(true);
            rainGOF2?.SetActive(true);
            snowGO?.SetActive(true);
        }

        void OnDisable()
        {
            HarmonyPatches.RemoveHarmonyPatches();
            rainGOF?.SetActive(false);
            rainGOF2?.SetActive(false);
            snowGO?.SetActive(false);
        }
    }
}
