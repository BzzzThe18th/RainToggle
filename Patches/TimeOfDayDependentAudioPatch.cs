using System;
using System.Collections.Generic;
using HarmonyLib;

namespace RainToggle.Patches
{

    [HarmonyPatch(typeof(TimeOfDayDependentAudio))]
    [HarmonyPatch("OnEnable", MethodType.Normal)]
    class TimeOfDayDependentAudioPatch
    {
        static bool Prefix()
        {
            if (Plugin.instance.enabled) return false;
            return true;
        }
    }
}