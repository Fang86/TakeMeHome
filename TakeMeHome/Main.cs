using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using BepInEx.Configuration;
using System.IO;

namespace TakeMeHome
{
    [BepInPlugin(MID, NAME, VERSION)]
    public class TakeMeHome : BaseUnityPlugin
    {
        private const string MID = "valheim.mod.takemehome";
        private const string NAME = "Take Me Home";
        private const string VERSION = "1.0.2";
        private const string author = "Fang86";

        

        public static ConfigFile configFile = new ConfigFile(Path.Combine(Paths.ConfigPath, "TakeMeHome.cfg"), true);
        public static ConfigEntry<KeyCode> homeKey = configFile.Bind("General", "Home key", KeyCode.P, "The key pressed to teleport home");
        public static ConfigEntry<KeyCode> backKey = configFile.Bind("General", "Back key", KeyCode.L, "The key pressed to teleport back to where you were when you teleported home");
        void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);

            Logger.LogInfo($"Take Me Home mod - Created by {author}");
        }
    }
}
