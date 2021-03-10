using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace TakeMeHome
{
    [HarmonyPatch(typeof(Chat), "Update")]
    class ChatPatcher
    {
        public static bool chatVisible = false;
        public static void Postfix(ref Chat __instance)
        {
            if (__instance.IsChatDialogWindowVisible())
            {
                chatVisible = true;
            }
            else
            {
                chatVisible = false;
            }
        }
    }
}
