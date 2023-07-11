using UnboundLib.Utils.UI;
using UnityEngine;
using UnboundLib;
using BepInEx;
using TMPro;
using System.ComponentModel;

namespace CatInfo
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willuwontu.rounds.tabinfo", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class CatInfo : BaseUnityPlugin
    {
        //Major.Minor.Patch
        public const string Version = "2.4.0";
        private const string ModId = "Com.Cat.Info";
        private const string ModName = "CatInfo";
        public const string ModInitials = "Cats";

        private static Color HolyWhiteText = new Color(255f, 255f, 255f, 1f);
        private static Color GreenText = new Color(0.521f, 1f, 0.521f, 1f);
        private static Color RedText = new Color(1f, 0.521f, 0.521f, 1f);

        internal static string ConfigKey(string name) => $"{ModId}_{name.ToLower()}";
        internal static bool GetBool(string name, bool defaultValue = false) => PlayerPrefs.GetInt(ConfigKey(name), defaultValue ? 1 : 0) == 1;
        internal static void SetBool(string name, bool value) => PlayerPrefs.SetInt(ConfigKey(name), value ? 1 : 0);
        private static void CycleArt() { ArtHandler.instance.NextArt(); ArtHandler.instance.NextArt(); }
        private static void CreateSpace(GameObject menu, int size = 45) {
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, size); 
        }

        internal static bool AllwaysShowStats
        {
            get => GetBool("AllwaysShowStats");
            set => SetBool("AllwaysShowStats", value);
        }

        private void Start()
        {
            TabinfoInterface.Setup();
            Unbound.RegisterClientSideMod(ModId);
            Unbound.RegisterMenu(ModName, () => { }, NewGUI, null, false);
            Unbound.RegisterCredits(ModName, new string[] {
                "Cats Army (CatInfo)","willuwontu (Creator Of TabInfo) - Helped With Code", "Root[Tess] - Helped With Code",
                "Willis - Helped With Code" },
                new string[] { "CatInfo Thunderstore","TabInfo Thunderstore","Root Thunderstore","Willis Thunderstore" }
                ,new string[] {
                    "https://rounds.thunderstore.io/package/CatsArmy/CatInfo/",
                    "https://rounds.thunderstore.io/package/willuwontu/TabInfo/",
                    "https://rounds.thunderstore.io/package/Root/",
                    "https://rounds.thunderstore.io/package/willis81808/" });
        }
        private static void NewGUI(GameObject menu)
        {
            MenuHandler.CreateText($"Toggle {ModName} Stats", menu, out TextMeshProUGUI _, 90);
            CreateSpace(menu);
            MenuHandler.CreateToggle(AllwaysShowStats, "Allways Show Stats", menu, delegate (bool value)
            {
                AllwaysShowStats = value;
                CycleArt();
            }, fontSize: 50, forceUpper: false, AllwaysShowStats ? GreenText : RedText);
        }

    }
}