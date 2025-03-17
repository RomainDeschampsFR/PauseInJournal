using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace PauseInJournal
{
    class Patches
    {
        [HarmonyPatch(typeof(Panel_Log), nameof(Panel_Log.Enable))]
        internal class Panel_Log_Enable
        {
            private static void Postfix(Panel_Log __instance, bool enable)
            {
                if (enable)
                {
                    GameManager.m_GlobalTimeScale = 0;
                }
                else
                {
                    GameManager.m_GlobalTimeScale = 1;
                }
            }
        }
    }
}
