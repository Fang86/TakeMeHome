using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;


namespace TakeMeHome
{
    [HarmonyPatch(typeof(Player), "Update")]
    class PlayerPatcher
    {
        public static Vector3 savedPos;
        public static Vector3 spawnPoint;
        public static bool hkActivated;
        public static bool hkPressed;
        public static void Postfix(ref Player __instance)
            {
                if (__instance == Player.m_localPlayer)
                {
                    if (!ChatPatcher.chatVisible && !ConsolePatcher.consoleVisible && !TextInputPatcher.tiVisible && !Minimap.InTextInput())
                    {
                        if (Input.GetKeyDown(TakeMeHome.homeKey.Value))
                        {
                            savedPos = new Vector3(__instance.transform.position.x, __instance.transform.position.y, __instance.transform.position.z);
                            Debug.Log($"Saved pos = {savedPos}");

                            hkPressed = true;

                            if (hkActivated)
                            {
                                __instance.TeleportTo(spawnPoint, __instance.transform.rotation, true);
                            }
                        }
                        else if (Input.GetKeyDown(TakeMeHome.backKey.Value) && hkActivated)
                        {
                            __instance.TeleportTo(savedPos, __instance.transform.rotation, true);
                        }
                        else
                        {
                            hkPressed = false;
                        }
                    }
                    else
                    {
                        hkPressed = false;
                    }
                }
            }
        
    }
}
