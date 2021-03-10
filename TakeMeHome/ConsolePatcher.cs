using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace TakeMeHome
{
    [HarmonyPatch(typeof(Console), "Update")]
    class ConsolePatcher
    {
        public static bool consoleVisible = false;
        public static void Postfix(ref Console __instance)
        {
            if (__instance.m_chatWindow.gameObject.activeSelf)
            {
                consoleVisible = true;
            }
            else
            {
                consoleVisible = false;
            }
        }
    }
}
