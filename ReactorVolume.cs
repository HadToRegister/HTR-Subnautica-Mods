using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;

namespace ReactorVolume
{
    [HarmonyPatch(typeof(BaseNuclearReactorGeometry), nameof(BaseNuclearReactorGeometry.SetState))]
    internal class ReactorVolume
    {
        [HarmonyPostfix]
        public static void Postfix(BaseNuclearReactorGeometry __instance, bool state)
        {
            // Turn off reactor sound
            if (state)
            {
                __instance.workSound.Stop();
            }
        }
    }
}
