using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace TakeMeHome
{
    [HarmonyPatch(typeof(Game), "Update")]
    class GamePatcher
    {
        public static void Postfix(ref Game __instance)
        {
            /*if (!SPSaved && )
            {
                PlayerProfile thisPlayerProfile = (PlayerProfile)Traverse.Create(__instance).Field("m_playerProfile").GetValue();
                PlayerPatcher.spawnPoint = thisPlayerProfile.GetCustomSpawnPoint();
                SPSaved = true;
            }*/

            if (PlayerPatcher.hkPressed)
            {
                PlayerProfile thisPlayerProfile = (PlayerProfile)Traverse.Create(__instance).Field("m_playerProfile").GetValue();
                PlayerPatcher.spawnPoint = thisPlayerProfile.GetCustomSpawnPoint();
                PlayerPatcher.spawnPoint.y += .5f;

                if (!PlayerPatcher.hkActivated)
                {
                    PlayerPatcher.hkActivated = true;
                    Debug.Log($"Initial Spawn Point = {PlayerPatcher.spawnPoint}");
                }
                else
                {
                    Debug.Log($"Current Spawn Point = {PlayerPatcher.spawnPoint}");
                }
            }
        }
    }
}
