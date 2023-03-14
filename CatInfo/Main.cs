using UnboundLib.Utils.UI;
using UnityEngine;
using UnboundLib;
using BepInEx;
using TMPro;

namespace CatInfo
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willuwontu.rounds.tabinfo", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class CatInfo : BaseUnityPlugin
    {
        private const string ModId = "Com.Cat.Info";
        private const string ModName = "CatInfo";
        public const string Version = "2.3.0";
        public const string ModInitials = "Cats";
        
        private void Start()
        {
            TabinfoInterface.Setup();
            Unbound.RegisterClientSideMod(ModId);
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
    }
}