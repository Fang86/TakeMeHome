using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace TakeMeHome
{
    [HarmonyPatch(typeof(TextInput), "Update")]
    class TextInputPatcher
    {
        public static bool tiVisible = false;
        public static void Postfix(ref TextInput __instance)
        {
            if (__instance.m_panel.gameObject.activeSelf)
            {
                tiVisible = true;
            }
            else
            {
                tiVisible = false;
            }
        }
    }
}
