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
        public static Plugin instance;

        void Start()
        {
            instance = this;
        }

        void OnEnable()
        {
            Events.GameInitialized += OnGameInitialized;
            HarmonyPatches.ApplyHarmonyPatches();
            rainGOF.SetActive(false);
            rainGOF2.SetActive(false);
            snowGO.SetActive(false);
        }

        void OnDisable()
        {
            rainGOF.SetActive(true);
            rainGOF2.SetActive(true);
            snowGO.SetActive(true);
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            rainGOF = GameObject.Find("Enivronment Objects/Local Objects_Prefab/Forest/WeatherDayNight/rain");
            rainGOF2 = GameObject.Find("Enivronment Objects/Local Objects_Prefab/Forest/WeatherDayNight/rain/DependentStuff");
            snowGO = GameObject.Find("Enivronment Objects/Local Objects_Prefab/Mountain/Weather/snow (1)");
        }
    }
}
