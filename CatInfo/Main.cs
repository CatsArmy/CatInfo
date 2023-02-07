using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
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
        public const string Version = "2.2.0";
        public const string ModInitials = "Cats";

        private static Color easyChangeColor = new Color(0.521f, 1f, 0.521f, 1f);
        private static Color hardChangeColor = new Color(1f, 0.521f, 0.521f, 1f);

        
        internal static string ConfigKey(string name)
        {
            return $"{ModId}_{name.ToLower()}";
        }
        internal static bool GetBool(string name, bool defaultValue = false)
        {
            return PlayerPrefs.GetInt(ConfigKey(name), defaultValue ? 1 : 0) == 1;
        }
        internal static void SetBool(string name, bool value)
        {
            PlayerPrefs.SetInt(ConfigKey(name), value ? 1 : 0);
        }

        public static bool DeprecatedGUI{
            get { return GetBool("DeprecatedGUI"); }
            set { SetBool("DeprecatedGUI", value); }
        }
        //# Basic Stats Extended
        public static bool EchoBlocks{
            get { return GetBool("EchoBlocks", true); }
            set { SetBool("EchoBlocks", value); }
        }
        public static bool AttackSpeed{
            get { return GetBool("AttackSpeed", true); }
            set { SetBool("AttackSpeed", value); }
        }
        public static bool LifeSteal{
            get { return GetBool("LifeSteal", true); }
            set { SetBool("LifeSteal", value); }
        }
        public static bool Bounces{
            get { return GetBool("Bounces", true); }
            set { SetBool("Bounces", value); }
        }
        public static bool Bursts{
            get { return GetBool("Bursts", true); }
            set { SetBool("Bursts", value); }
        }
        public static bool Bullets{
            get { return GetBool("Bullets", true); }
            set { SetBool("Bullets", value); }
        }
        public static bool BounceDamage{
            get { return GetBool("BounceDamage", true); }
            set { SetBool("BounceDamage", value); }
        }
        public static bool BounceSpeed{
            get { return GetBool("BounceSpeed", true); }
            set { SetBool("BounceSpeed", value); }
        }
        //# Useful Stats
        public static bool Unblockable{
            get { return GetBool("Unblockable", true); }
            set { SetBool("Unblockable", value); }
        }
        public static bool GhostBullets{
            get { return GetBool("Ghost", true); }
            set { SetBool("Ghost", value); }
        }
        public static bool Chargable{
            get { return GetBool("Chargable"); }
            set { SetBool("Chargable", value); }
        }
        public static bool DemonicGun{
            get { return GetBool("DemonicGun"); }
            set { SetBool("DemonicGun", value); }
        }
        //# Advanced Health Stats
        public static bool Phoenix{
            get { return GetBool("Phoenix", true); }
            set { SetBool("Phoenix", value); }
        }
        public static bool HealingOnBlock{
            get { return GetBool("HealingOnBlock"); }
            set { SetBool("HealingOnBlock", value); }
        }
        public static bool Decay{
            get { return GetBool("Decay", true); }
            set { SetBool("Decay", value); }
        }
        public static bool Regenaration{
            get { return GetBool("Regenaration", true); }
            set { SetBool("Regenaration", value); }
        }
        public static bool Size{
            get { return GetBool("Size", true); }
            set { SetBool("Size", value); }
        }
        public static bool Jumps{
            get { return GetBool("Jumps"); }
            set { SetBool("Jumps", value); }
        }
        public static bool JumpHight{
            get { return GetBool("JumpHight"); }
            set { SetBool("JumpHight", value); }
        }
        public static bool Gravity{
            get { return GetBool("Gravity"); }
            set { SetBool("Gravity", value); }
        }
        //# Advanced Gun Stats
        public static bool HealthCulling{
            get { return GetBool("HealthCulling", true); }
            set { SetBool("HealthCulling", value); }
        }
        public static bool BulletRange{
            get { return GetBool("BulletRange", true); }
            set { SetBool("BulletRange", value); }
        }
        public static bool BulletSpeed{
            get { return GetBool("BulletSpeed", true); }
            set { SetBool("BulletSpeed", value); }
        }
        public static bool BulletSize{
            get { return GetBool("BulletSize", true); }
            set { SetBool("BulletSize", value); }
        }
        public static bool ProjectileSize{
            get { return GetBool("ProjectileSize", true); }
            set { SetBool("ProjectileSize", value); }
        }
        public static bool ProjectileTimeScale{
            get { return GetBool("ProjectileTimeScale", true); }
            set { SetBool("ProjectileTimeScale", value); }
        }
        public static bool DamageGrowth{
            get { return GetBool("DamageGrowth", true); }
            set { SetBool("DamageGrowth", value); }
        }
        public static bool GunSpread{
            get { return GetBool("GunSpread", true); }
            set { SetBool("GunSpread", value); }
        }
        public static bool EvenGunSpread{
            get { return GetBool("EvenGunSpread"); }
            set { SetBool("EvenGunSpread", value); }
        }
        public static bool BulletDrag{
            get { return GetBool("BulletDrag"); }
            set { SetBool("BulletDrag", value); }
        }
        public static bool ColdBullets{
            get { return GetBool("ColdBullets"); }
            set { SetBool("ColdBullets", value); }
        }
        public static bool Knockback{
            get { return GetBool("Knockback", true); }
            set { SetBool("Knockback", value); }
        }
        public static bool BulletGravity{
            get { return GetBool("BulletGravity"); }
            set { SetBool("BulletGravity", value); }
        }
        public static bool TimeBetweenBursts{
            get { return GetBool("TimeBetweenBursts"); }
            set { SetBool("TimeBetweenBursts", value); }
        }
        public static bool AmmoRegeneration{
            get { return GetBool("AmmoRegeneration"); }
            set { SetBool("AmmoRegeneration", value); }
        }
        public static bool Recoil{
            get { return GetBool("Recoil"); }
            set { SetBool("Recoil", value); }
        }
        public static bool BodyRecoil{
            get { return GetBool("BodyRecoil"); }
            set { SetBool("BodyRecoil", value); }
        }
        public static bool RecoilMultiplier{
            get { return GetBool("RecoilMultiplier"); }
            set { SetBool("RecoilMultiplier", value); }
        }//HealthCulling BulletRange BulletSpeed BulletSize ProjectileSize ProjectileTimeScale DamageGrowth GunSpread EvenGunSpread BulletDrag ColdBullets Knockback BulletGravity TimeBetweenBursts
         //AmmoRegeneration Recoil BodyRecoil RecoilMultiplier ChargedDamageMultiplier ChargedSpeed ChargedGunSpread ChargedEvenGunSpread ChargedRecoil ChargedNumberOfProjectiles

        //# Charged Stats
        public static bool ChargedDamageMultiplier{
            get { return GetBool("ChargedDamageMultiplier"); }
            set { SetBool("ChargedDamageMultiplier", value); }
        }
        public static bool ChargedSpeed{
            get { return GetBool("ChargedSpeed"); }
            set { SetBool("ChargedSpeed", value); }
        }
        public static bool ChargedGunSpread{
            get { return GetBool("ChargedGunSpread"); }
            set { SetBool("ChargedGunSpread", value); }
        }
        public static bool ChargedEvenGunSpread{
            get { return GetBool("ChargedEvenGunSpread"); }
            set { SetBool("ChargedEvenGunSpread", value); }
        }
        public static bool ChargedRecoil{
            get { return GetBool("ChargedRecoil"); }
            set { SetBool("ChargedRecoil", value); }
        }
        public static bool ChargedNumberOfProjectiles{
            get { return GetBool("ChargedNumberOfProjectiles"); }
            set { SetBool("ChargedNumberOfProjectiles", value); }
        }
        internal static Dictionary<string, List<Toggle>> TogglesToSync = new Dictionary<string, List<Toggle>>();
        
        private void Start()
        {
            TabinfoInterface.Setup();
            Unbound.RegisterClientSideMod(ModId);

            Unbound.RegisterMenu(ModName, () => { }, NewGUI, null, true);
            if (DeprecatedGUI)
            {//Deprecated GUI
                Unbound.RegisterGUI(ModName, DrawBasicStatsGUI);
                Unbound.RegisterGUI(ModName, DrawUsefulStatsGUI);
                Unbound.RegisterGUI(ModName, DrawAdvHealthStatsGUI);
                Unbound.RegisterGUI(ModName, DrawAdvGunStatsGUI);
                Unbound.RegisterGUI(ModName, DrawChargedStatsGUI);
            }
        }
        //Deprecated GUI Toggles
        private void DrawBasicStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Basic Stats\n");
                EchoBlocks = GUILayout.Toggle(EchoBlocks, "Echo Blocks");
                AttackSpeed = GUILayout.Toggle(AttackSpeed, "Attack Speed");
                LifeSteal = GUILayout.Toggle(LifeSteal, "Life Steal");
                Bounces = GUILayout.Toggle(Bounces, "Bounces");
                Bursts = GUILayout.Toggle(Bursts, "Bursts");
                Bullets = GUILayout.Toggle(Bullets, "Bullets");
                BounceDamage = GUILayout.Toggle(BounceDamage, "On Bounce Bullet Damage");
                BounceSpeed = GUILayout.Toggle(BounceSpeed, "On Bounce Bullet Speed");
            }
        }
        private void DrawUsefulStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Useful Stats\n");
                Unblockable = GUILayout.Toggle(Unblockable, "Unblockable Bullets");
                GhostBullets = GUILayout.Toggle(GhostBullets, "Ghost Bullets");
                Chargable = GUILayout.Toggle(Chargable, "Use Charge");
                DemonicGun = GUILayout.Toggle(DemonicGun, "Dont Allow Auto Fire");
            }
        }
        private void DrawAdvHealthStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Advanced Health Stats\n");
                Phoenix = GUILayout.Toggle(Phoenix, "Revives");
                HealingOnBlock = GUILayout.Toggle(HealingOnBlock, "Healing On Block");
                Decay = GUILayout.Toggle(Decay, "Health Decay");
                Regenaration = GUILayout.Toggle(Regenaration, "Regenaration");
                Size = GUILayout.Toggle(Size, "Size");
                Jumps = GUILayout.Toggle(Jumps, "Jumps");
                JumpHight = GUILayout.Toggle(JumpHight, "Jump Hight");
                Gravity = GUILayout.Toggle(Gravity, "Gravity");
            }
        }
        private void DrawAdvGunStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Advanced Gun Stats\n");
                HealthCulling = GUILayout.Toggle(HealthCulling, "%Health Culling");
                BulletRange = GUILayout.Toggle(BulletRange, "Bullet Range");
                BulletSpeed = GUILayout.Toggle(BulletSpeed, "Bullet Speed");
                BulletSize = GUILayout.Toggle(BulletSize, "Bullet Size");
                ProjectileSize = GUILayout.Toggle(ProjectileSize, "Projectile Size");
                ProjectileTimeScale = GUILayout.Toggle(ProjectileTimeScale, "Projectile Speed");
                DamageGrowth = GUILayout.Toggle(DamageGrowth, "Damage Growth");
                GunSpread = GUILayout.Toggle(GunSpread, "Bullet Spread");
                EvenGunSpread = GUILayout.Toggle(EvenGunSpread, "Even Bullet Spread");
                BulletDrag = GUILayout.Toggle(BulletDrag, "Bullet Drag");
                ColdBullets = GUILayout.Toggle(ColdBullets, "Bullet Slow");
                BulletGravity = GUILayout.Toggle(BulletGravity, "Bullet Gravity");
                Knockback = GUILayout.Toggle(Knockback, "Knockback");
                TimeBetweenBursts = GUILayout.Toggle(TimeBetweenBursts, "Time Between Bursts");
                AmmoRegeneration = GUILayout.Toggle(AmmoRegeneration, "%Ammo Regenaration");
                Recoil = GUILayout.Toggle(Recoil, "Recoil");
                BodyRecoil = GUILayout.Toggle(BodyRecoil, "Body Recoil");
                RecoilMultiplier = GUILayout.Toggle(RecoilMultiplier, "Recoil Multiplier");
            }
        }
        private void DrawChargedStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Charged Stats\n");
                ChargedDamageMultiplier = GUILayout.Toggle(ChargedDamageMultiplier, "Charged Damage Multiplier");
                ChargedSpeed = GUILayout.Toggle(ChargedSpeed, "Charged Speed");
                ChargedGunSpread = GUILayout.Toggle(ChargedGunSpread, "Charged Spread");
                ChargedEvenGunSpread = GUILayout.Toggle(ChargedEvenGunSpread, "Charged Even Spread");
                ChargedRecoil = GUILayout.Toggle(ChargedRecoil, "Charged Recoil");
                ChargedNumberOfProjectiles = GUILayout.Toggle(ChargedNumberOfProjectiles, "Charged Number Of Projectiles");
            }
        }
        //Menu GUI
        private static void NewGUI(GameObject menu)
        {
            InitializeOptionsDictionaries();

            MenuHandler.CreateText($"Toggle {ModName} Stats\n", menu, out TextMeshProUGUI _, 90);
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn(), 75, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset(), 75);
            MenuHandler.CreateButton("Disable All\n", menu, () => PresetOff(), 75, color: hardChangeColor);
            
            GameObject BasicStats = MenuHandler.CreateMenu("Basic Stats Extended", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            BasicStatsToggles(BasicStats);
            
            GameObject UsefulStats = MenuHandler.CreateMenu("Useful Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            UsefulStatsToggles(UsefulStats);
            
            GameObject AdvancedHealthStats = MenuHandler.CreateMenu("Advanced Health Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            AdvancedHealthStatsToggles(AdvancedHealthStats);
            
            GameObject AdvancedGunStats = MenuHandler.CreateMenu("Advanced Gun Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            AdvancedGunStatsToggles(AdvancedGunStats);
            
            GameObject ChargedStats = MenuHandler.CreateMenu("Plasma Charged Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            ChargedStatsToggles(ChargedStats);
            void DeprecatedGUIChanged(bool value)
            {
                EchoBlocks = value;
                SyncOptionsMenus();
            }
            TogglesToSync["DeprecatedGUI"].Add(MenuHandler.CreateToggle(DeprecatedGUI,
           "Deprecated GUI", menu, DeprecatedGUIChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            MenuHandler.CreateToggle(DeprecatedGUI, "Enable Deprecated GUI", menu, value => DeprecatedGUI = value, fontSize: 20, forceUpper: false,color: hardChangeColor);

        }
        //Menu GUI Toggle Presets
        private static void PresetOn(string menuCat = "menuCatagory")
        {
            bool setValue = true;
            if (menuCat == "menuCatagory")
            {
                DeprecatedGUI = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "BasicStats")
            {//BasicStats
                EchoBlocks = setValue;
                AttackSpeed = setValue;
                LifeSteal = setValue;
                Bounces = setValue;
                Bursts = setValue;
                Bullets = setValue;
                BounceDamage = setValue;
                BounceSpeed = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                Unblockable = setValue;
                GhostBullets = setValue;
                Chargable = setValue;
                DemonicGun = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvHealthStats")
            {//AdvHealthStats  
                Phoenix = setValue;
                HealingOnBlock = setValue;
                Decay = setValue;
                Regenaration = setValue;
                Size = setValue;
                Jumps = setValue;
                JumpHight = setValue;
                Gravity = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvGunStats")
            {//AdvGunStats
                HealthCulling = setValue;
                BulletRange = setValue;
                BulletSpeed = setValue;
                BulletSize = setValue;
                ProjectileSize = setValue;
                ProjectileTimeScale = setValue;
                DamageGrowth = setValue;
                GunSpread = setValue;
                EvenGunSpread = setValue;
                BulletDrag = setValue;
                ColdBullets = setValue;
                BulletGravity = setValue;
                Knockback = setValue;
                TimeBetweenBursts = setValue;
                AmmoRegeneration = setValue;
                Recoil = setValue;
                BodyRecoil = setValue;
                RecoilMultiplier = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "ChargedStats")
            {//ChargedStats
                ChargedDamageMultiplier = setValue;
                ChargedSpeed = setValue;
                ChargedGunSpread = setValue;
                ChargedEvenGunSpread = setValue;
                ChargedRecoil = setValue;
                ChargedNumberOfProjectiles = setValue;
            }
        }
        private static void PresetOff(string menuCat = "menuCatagory")
        {
            bool setValue = false;
            if (menuCat == "menuCatagory")
            {
                DeprecatedGUI = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "BasicStats")
            {//BasicStats
                EchoBlocks = setValue;
                AttackSpeed = setValue;
                LifeSteal = setValue;
                Bounces = setValue;
                Bursts = setValue;
                Bullets = setValue;
                BounceDamage = setValue;
                BounceSpeed = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                Unblockable = setValue;
                GhostBullets = setValue;
                Chargable = setValue;
                DemonicGun = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvHealthStats")
            {//AdvHealthStats  
                Phoenix = setValue;
                HealingOnBlock = setValue;
                Decay = setValue;
                Regenaration = setValue;
                Size = setValue;
                Jumps = setValue;
                JumpHight = setValue;
                Gravity = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvGunStats")
            {//AdvGunStats
                HealthCulling = setValue;
                BulletRange = setValue;
                BulletSpeed = setValue;
                BulletSize = setValue;
                ProjectileSize = setValue;
                ProjectileTimeScale = setValue;
                DamageGrowth = setValue;
                GunSpread = setValue;
                EvenGunSpread = setValue;
                BulletDrag = setValue;
                ColdBullets = setValue;
                BulletGravity = setValue;
                Knockback = setValue;
                TimeBetweenBursts = setValue;
                AmmoRegeneration = setValue;
                Recoil = setValue;
                BodyRecoil = setValue;
                RecoilMultiplier = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "ChargedStats")
            {//ChargedStats
                ChargedDamageMultiplier = setValue;
                ChargedSpeed = setValue;
                ChargedGunSpread = setValue;
                ChargedEvenGunSpread = setValue;
                ChargedRecoil = setValue;
                ChargedNumberOfProjectiles = setValue;
            }
        }
        private static void ResetToDefualtPreset(string menuCat = "menuCatagory")
        {
            if (menuCat == "menuCatagory")
            {
                DeprecatedGUI = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "BasicStats")
            {//BasicStats
                EchoBlocks = true;
                AttackSpeed = true;
                LifeSteal = true;
                Bounces = true;
                Bursts = true;
                Bullets = true;
                BounceDamage = true;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                BounceSpeed = true;
                Unblockable = true;
                GhostBullets = true;
                Chargable = false;
                DemonicGun = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvHealthStats")
            {//AdvHealthStats
                Phoenix = true;
                HealingOnBlock = false;
                Decay = true;
                Regenaration = true;
                Size = true;
                Jumps = false;
                JumpHight = false;
                Gravity = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvGunStats")
            {//AdvGunStats
                HealthCulling = true;
                BulletRange = true;
                BulletSpeed = true;
                BulletSize = true;
                ProjectileSize = true;
                ProjectileTimeScale = true;
                DamageGrowth = true;
                GunSpread = true;
                EvenGunSpread = false;
                BulletDrag = false;
                ColdBullets = false;
                BulletGravity = false;
                Knockback = true;
                TimeBetweenBursts = false;
                AmmoRegeneration = false;
                Recoil = false;
                BodyRecoil = false;
                RecoilMultiplier = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "ChargedStats")
            {//ChargedStats
                ChargedDamageMultiplier = false;
                ChargedSpeed = false;
                ChargedGunSpread = false;
                ChargedEvenGunSpread = false;
                ChargedRecoil = false;
                ChargedNumberOfProjectiles = false;
            }
        }
        //Menu GUI Toggles
        private static void BasicStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("BasicStats"), 75, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("BasicStats"), 75);
            MenuHandler.CreateButton("Disable All\n", menu, () => PresetOff("BasicStats"), 75, color: hardChangeColor);
            MenuHandler.CreateText("Can Only Toggle Basic Stats Added By CatInfo\n", menu, out TextMeshProUGUI _, 40);
            void EchoBlocksChanged(bool value)
            {
                EchoBlocks = value;
                SyncOptionsMenus();
            }
            TogglesToSync["EchoBlocks"].Add(MenuHandler.CreateToggle(EchoBlocks,
            "Echo Blocks", menu, EchoBlocksChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            
            void AttackSpeedChanged(bool value)
            {
                AttackSpeed = value;
                SyncOptionsMenus();
            }
            TogglesToSync["AttackSpeed"].Add(MenuHandler.CreateToggle(AttackSpeed,
            "Attack Speed", menu, AttackSpeedChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            
            void LifeStealChanged(bool value)
            {
                LifeSteal = value;
                SyncOptionsMenus();
            }
            TogglesToSync["LifeSteal"].Add(MenuHandler.CreateToggle(LifeSteal,
            "Life Steal", menu, LifeStealChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BouncesChanged(bool value)
            {
                Bounces = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Bounces"].Add(MenuHandler.CreateToggle(Bounces,
            "Bounces", menu, BouncesChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BurstsChanged(bool value)
            {
                Bounces = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Bursts"].Add(MenuHandler.CreateToggle(Bursts,
            "Bursts", menu, BurstsChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BulletsChanged(bool value)
            {
                Bullets = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Bullets"].Add(MenuHandler.CreateToggle(Bullets,
            "Bullets", menu, BulletsChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BounceDamageChanged(bool value)
            {
                BounceDamage = value;
                SyncOptionsMenus();
            }//Needs to change Regex
            TogglesToSync["BounceDamage"].Add(MenuHandler.CreateToggle(BounceDamage,
            "Bounce Damage", menu, BounceDamageChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BounceSpeedChanged(bool value)
            {//Needs to change Regex
                BounceSpeed = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BounceSpeed"].Add(MenuHandler.CreateToggle(BounceSpeed,
            "Bounce Speed", menu, BounceSpeedChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
        }
        private static void UsefulStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("UsefulStats"), 75, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("UsefulStats"), 75);
            MenuHandler.CreateButton("Disable All\n", menu, () => PresetOff("UsefulStats"), 75, color: hardChangeColor);

            void UnblockableChanged(bool value)
            {
                Unblockable = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Unblockable"].Add(MenuHandler.CreateToggle(Unblockable,
            "Unblockable", menu, UnblockableChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void GhostBulletsChanged(bool value)
            {
                GhostBullets = value;
                SyncOptionsMenus();
            }
            TogglesToSync["GhostBullets"].Add(MenuHandler.CreateToggle(GhostBullets,
            "Ghost Bullets", menu, GhostBulletsChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ChargableChanged(bool value)
            {
                Chargable = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Chargable"].Add(MenuHandler.CreateToggle(Chargable,
            "Chargable", menu, ChargableChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void DemonicGunChanged(bool value)
            {
                DemonicGun = value;
                SyncOptionsMenus();
            }
            TogglesToSync["DemonicGun"].Add(MenuHandler.CreateToggle(DemonicGun,
            "Demonic Gun", menu, DemonicGunChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
        }
        private static void AdvancedHealthStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("AdvHealthStats"), 75, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("AdvHealthStats"), 75);
            MenuHandler.CreateButton("Disable All\n", menu, () => PresetOff("AdvHealthStats"), 75, color: hardChangeColor);
            void PhoenixChanged(bool value)
            {
                Phoenix = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Phoenix"].Add(MenuHandler.CreateToggle(Phoenix,
            "Phoenix", menu, PhoenixChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void HealingOnBlockChanged(bool value)
            {
                HealingOnBlock = value;
                SyncOptionsMenus();
            }
            TogglesToSync["HealingOnBlock"].Add(MenuHandler.CreateToggle(HealingOnBlock,
            "Healing On Block", menu, HealingOnBlockChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void DecayChanged(bool value)
            {
                Decay = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Decay"].Add(MenuHandler.CreateToggle(Decay,
            "Decay", menu, DecayChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void RegenerationChanged(bool value)
            {
                Regenaration = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Regeneration"].Add(MenuHandler.CreateToggle(Regenaration,
            "Regeneration", menu, RegenerationChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void SizeChanged(bool value)
            {
                Size = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Size"].Add(MenuHandler.CreateToggle(Size,
            "Size", menu, SizeChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void JumpsChanged(bool value)
            {
                Jumps = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Jumps"].Add(MenuHandler.CreateToggle(Jumps,
            "Jumps", menu, JumpsChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void JumpHightChanged(bool value)
            {
                JumpHight = value;
                SyncOptionsMenus();
            }
            TogglesToSync["JumpHight"].Add(MenuHandler.CreateToggle(JumpHight,
            "Jump Hight", menu, JumpHightChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void GravityChanged(bool value)
            {
                Gravity = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Gravity"].Add(MenuHandler.CreateToggle(Gravity,
            "Gravity", menu, GravityChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
        }
        private static void AdvancedGunStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("AdvGunStats"), 75, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("AdvGunStats"), 75);
            MenuHandler.CreateButton("Disable All\n", menu, () => PresetOff("AdvGunStats"), 75, color: hardChangeColor);

            void HealthCullingChanged(bool value) 
            {
                HealthCulling = value;
                SyncOptionsMenus();
            }
            TogglesToSync["HealthCulling"].Add(MenuHandler.CreateToggle(HealthCulling,
            "%Health Culling", menu, HealthCullingChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BulletRangeChanged(bool value)
            {
                BulletRange = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BulletRange"].Add(MenuHandler.CreateToggle(BulletRange,
            "Bullet Range", menu, BulletRangeChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BulletSpeedChanged(bool value)
            {
                BulletSpeed = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BulletSpeed"].Add(MenuHandler.CreateToggle(BulletSpeed,
            "Bullet Speed", menu, BulletSpeedChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BulletSizeChanged(bool value)
            {
                BulletSize = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BulletSize"].Add(MenuHandler.CreateToggle(BulletSize,
            "Bullet Size", menu, BulletSizeChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ProjectileSizeChanged(bool value)
            {
                ProjectileSize = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ProjectileSize"].Add(MenuHandler.CreateToggle(ProjectileSize,
            "Projectile Size", menu, ProjectileSizeChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ProjectileTimeScaleChanged(bool value)
            {
                ProjectileTimeScale = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ProjectileTimeScale"].Add(MenuHandler.CreateToggle(ProjectileTimeScale,
                "Projectile Time Scale", menu, ProjectileTimeScaleChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void DamageGrowthChanged(bool value)
            {
                DamageGrowth = value;
                SyncOptionsMenus();
            }
            TogglesToSync["DamageGrowth"].Add(MenuHandler.CreateToggle(DamageGrowth,
            "Damage Growth", menu, DamageGrowthChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void GunSpreadChanged(bool value)
            {
                GunSpread = value;
                SyncOptionsMenus();
            }
            TogglesToSync["GunSpread"].Add(MenuHandler.CreateToggle(GunSpread,
            "Gun Spread", menu, GunSpreadChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void EvenGunSpreadChanged(bool value)
            {
                EvenGunSpread = value;
                SyncOptionsMenus();
            }
            TogglesToSync["EvenGunSpread"].Add(MenuHandler.CreateToggle(EvenGunSpread,
            "Even Gun Spread", menu, EvenGunSpreadChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BulletDragChanged(bool value)
            {
                BulletDrag = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BulletDrag"].Add(MenuHandler.CreateToggle(BulletDrag,
            "Bullet Drag", menu, BulletDragChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ColdBulletsChanged(bool value)
            {
                ColdBullets = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ColdBullets"].Add(MenuHandler.CreateToggle(ColdBullets,
            "Cold Bullets", menu, ColdBulletsChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BulletGravityChanged(bool value)
            {
                BulletGravity = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BulletGravity"].Add(MenuHandler.CreateToggle(BulletGravity,
            "Bullet Gravity", menu, BulletGravityChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void KnockbackChanged(bool value)
            {
                Knockback = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Knockback"].Add(MenuHandler.CreateToggle(Knockback,
            "Knockback", menu, KnockbackChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void TimeBetweenBurstsChanged(bool value)
            {
                TimeBetweenBursts = value;
                SyncOptionsMenus();
            }
            TogglesToSync["TimeBetweenBursts"].Add(MenuHandler.CreateToggle(TimeBetweenBursts,
            "Time Between Bursts", menu, TimeBetweenBurstsChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void AmmoRegenerationChanged(bool value)
            {
                AmmoRegeneration = value;
                SyncOptionsMenus();
            }
            TogglesToSync["AmmoRegeneration"].Add(MenuHandler.CreateToggle(AmmoRegeneration,
            "%Ammo Regeneration", menu, AmmoRegenerationChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            MenuHandler.CreateText("Most Mods havent updated to use the BodyRecoil Stat for recoil as it was only fixed reacntly " +
                "and are currently using their own recoil stat that i cannot display\nRecoil = bodyRecoil * chargedRecoil * recoilMultiplier", menu, out TextMeshProUGUI _, 40);
            void RecoilChanged(bool value)
            {
                Recoil = value;
                SyncOptionsMenus();
            }
            TogglesToSync["Recoil"].Add(MenuHandler.CreateToggle(Recoil,
            "Recoil", menu, RecoilChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void BodyRecoilChanged(bool value)
            {
                BodyRecoil = value;
                SyncOptionsMenus();
            }
            TogglesToSync["BodyRecoil"].Add(MenuHandler.CreateToggle(BodyRecoil,
            "Body Recoil", menu, BodyRecoilChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void RecoilMultiplierChanged(bool value)
            {
                RecoilMultiplier = value;
                SyncOptionsMenus();
            }
            TogglesToSync["RecoilMultiplier"].Add(MenuHandler.CreateToggle(RecoilMultiplier,
            "Recoil Multiplier", menu, RecoilMultiplierChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
        }
        private static void ChargedStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("ChargedStats"), 75, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("ChargedStats"), 75);
            MenuHandler.CreateButton("Disable All\n", menu, () => PresetOff("ChargedStats"), 75, color: hardChangeColor);

            void ChargedDamageMultiplierChanged(bool value)
            {
                ChargedDamageMultiplier = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ChargedDamageMultiplier"].Add(MenuHandler.CreateToggle(ChargedDamageMultiplier,
            "Charged Damage Multiplier", menu, ChargedDamageMultiplierChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ChargedSpeedChanged(bool value)
            {
                ChargedSpeed = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ChargedSpeed"].Add(MenuHandler.CreateToggle(ChargedSpeed,
            "Charged Speed", menu, ChargedSpeedChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ChargedGunSpreadChanged(bool value)
            {
                ChargedGunSpread = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ChargedGunSpread"].Add(MenuHandler.CreateToggle(ChargedGunSpread,
            "Charged Gun Spread", menu, ChargedGunSpreadChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ChargedEvenGunSpreadChanged(bool value)
            {
                ChargedEvenGunSpread = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ChargedEvenGunSpread"].Add(MenuHandler.CreateToggle(ChargedEvenGunSpread,
            "Charged Even Gun Spread", menu, ChargedEvenGunSpreadChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ChargedRecoilChanged(bool value)
            {
                ChargedRecoil = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ChargedRecoil"].Add(MenuHandler.CreateToggle(ChargedRecoil,
            "Charged Recoil", menu, ChargedRecoilChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
            void ChargedNumberOfProjectilesChanged(bool value)
            {
                ChargedNumberOfProjectiles = value;
                SyncOptionsMenus();
            }
            TogglesToSync["ChargedNumberOfProjectiles"].Add(MenuHandler.CreateToggle(ChargedNumberOfProjectiles,
            "Charged Number Of Projectiles", menu, ChargedNumberOfProjectilesChanged, fontSize: 50, forceUpper: false).GetComponent<Toggle>());
        }
        
        private static void InitializeOptionsDictionaries()
        {
            if (!TogglesToSync.Keys.Contains("DeprecatedGUI")) { TogglesToSync["EchoBlocks"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("EchoBlocks")) { TogglesToSync["EchoBlocks"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Attackspeed")) { TogglesToSync["Attackspeed"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("LifeSteal")) { TogglesToSync["LifeSteal"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Bounces")) { TogglesToSync["Bounces"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Bursts")) { TogglesToSync["Bursts"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Bullets")) { TogglesToSync["Bullets"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BounceDamage")) { TogglesToSync["BounceDamage"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BounceSpeed")) { TogglesToSync["BounceSpeed"] = new List<Toggle>() { }; }
            //
            if (!TogglesToSync.Keys.Contains("Unblockable")) { TogglesToSync["Unblockable"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Ghost")) { TogglesToSync["Ghost"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Chargable")) { TogglesToSync["Chargable"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("DemonicGun")) { TogglesToSync["DemonicGun"] = new List<Toggle>() { }; }
            //
            if (!TogglesToSync.Keys.Contains("Phoenix")) { TogglesToSync["Phoenix"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("HealingOnBlock")) { TogglesToSync["HealingOnBlock"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Decay")) { TogglesToSync["Decay"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Regeneration")) { TogglesToSync["Regeneration"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Size")) { TogglesToSync["Size"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Jumps")) { TogglesToSync["Jumps"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("JumpHight")) { TogglesToSync["JumpHight"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Gravity")) { TogglesToSync["Gravity"] = new List<Toggle>() { }; }
            //
            if (!TogglesToSync.Keys.Contains("HealthCulling")) { TogglesToSync["HealthCulling"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BulletRange")) { TogglesToSync["BulletRange"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BulletSpeed")) { TogglesToSync["BulletSpeed"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BulletSize")) { TogglesToSync["BulletSize"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ProjectileSize")) { TogglesToSync["ProjectileSize"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ProjectileTimeScale")) { TogglesToSync["ProjectileTimeScale"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("DamageGrowth")) { TogglesToSync["DamageGrowth"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("GunSpread")) { TogglesToSync["GunSpread"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("EvenGunSpread")) { TogglesToSync["EvenGunSpread"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BulletDrag")) { TogglesToSync["BulletDrag"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ColdBullets")) { TogglesToSync["ColdBullets"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Knockback")) { TogglesToSync["Knockback"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BulletGravity")) { TogglesToSync["BulletGravity"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("TimeBetweenBursts")) { TogglesToSync["TimeBetweenBursts"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("AmmoRegeneration")) { TogglesToSync["AmmoRegeneration"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("Recoil")) { TogglesToSync["Recoil"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("BodyRecoil")) { TogglesToSync["BodyRecoil"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("RecoilMultiplier")) { TogglesToSync["RecoilMultiplier"] = new List<Toggle>() { }; }
            //
            if (!TogglesToSync.Keys.Contains("ChargedDamageMultiplier")) { TogglesToSync["ChargedDamageMultiplier"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ChargedSpeed")) { TogglesToSync["ChargedSpeed"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ChargedGunSpread")) { TogglesToSync["ChargedGunSpread"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ChargedEvenGunSpread")) { TogglesToSync["ChargedEvenGunSpread"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ChargedRecoil")) { TogglesToSync["ChargedRecoil"] = new List<Toggle>() { }; }
            if (!TogglesToSync.Keys.Contains("ChargedNumberOfProjectiles")) { TogglesToSync["ChargedNumberOfProjectiles"] = new List<Toggle>() { }; }
        }
        private static void SyncOptionsMenus(int recurse = 3)
        {
            foreach (Toggle toggle in TogglesToSync["DeprecatedGUI"]) { toggle.isOn = DeprecatedGUI; }
            foreach (Toggle toggle in TogglesToSync["EchoBlocks"]) { toggle.isOn = EchoBlocks; }
            foreach (Toggle toggle in TogglesToSync["AttackSpeed"]) { toggle.isOn = AttackSpeed; }
            foreach (Toggle toggle in TogglesToSync["LifeSteal"]) { toggle.isOn = LifeSteal; }
            foreach (Toggle toggle in TogglesToSync["Bounces"]) { toggle.isOn = Bounces; }
            foreach (Toggle toggle in TogglesToSync["Bursts"]) { toggle.isOn = Bursts; }
            foreach (Toggle toggle in TogglesToSync["Bullets"]) { toggle.isOn = Bullets; }
            foreach (Toggle toggle in TogglesToSync["BounceDamage"]) { toggle.isOn = BounceDamage; }
            foreach (Toggle toggle in TogglesToSync["BounceSpeed"]) { toggle.isOn = BounceSpeed; }
            //
            foreach (Toggle toggle in TogglesToSync["Unblockable"]) { toggle.isOn = Unblockable; }
            foreach (Toggle toggle in TogglesToSync["Ghost"]) { toggle.isOn = GhostBullets; }
            foreach (Toggle toggle in TogglesToSync["Chargable"]) { toggle.isOn = Chargable; }
            foreach (Toggle toggle in TogglesToSync["DemonicGun"]) { toggle.isOn = DemonicGun; }
            //
            foreach (Toggle toggle in TogglesToSync["Phoenix"]) { toggle.isOn = Phoenix; }
            foreach (Toggle toggle in TogglesToSync["HealingOnBlock"]) { toggle.isOn = HealingOnBlock; }
            foreach (Toggle toggle in TogglesToSync["Decay"]) { toggle.isOn = Decay; }
            foreach (Toggle toggle in TogglesToSync["Regeneration"]) { toggle.isOn = Regenaration; }
            foreach (Toggle toggle in TogglesToSync["Size"]) { toggle.isOn = Size; }
            foreach (Toggle toggle in TogglesToSync["Jumps"]) { toggle.isOn = Jumps; }
            foreach (Toggle toggle in TogglesToSync["JumpHight"]) { toggle.isOn = JumpHight; }
            foreach (Toggle toggle in TogglesToSync["Gravity"]) { toggle.isOn = Gravity; }
            //
            foreach (Toggle toggle in TogglesToSync["HealthCulling"]) { toggle.isOn = HealthCulling; }
            foreach (Toggle toggle in TogglesToSync["BulletRange"]) { toggle.isOn = BulletRange; }
            foreach (Toggle toggle in TogglesToSync["BulletSpeed"]) { toggle.isOn = BulletSpeed; }
            foreach (Toggle toggle in TogglesToSync["BulletSize"]) { toggle.isOn = BulletSize; }
            foreach (Toggle toggle in TogglesToSync["ProjectileSize"]) { toggle.isOn = ProjectileSize; }
            foreach (Toggle toggle in TogglesToSync["ProjectileTimeScale"]) { toggle.isOn = ProjectileTimeScale; }
            foreach (Toggle toggle in TogglesToSync["DamageGrowth"]) { toggle.isOn = DamageGrowth; }
            foreach (Toggle toggle in TogglesToSync["GunSpread"]) { toggle.isOn = GunSpread; }
            foreach (Toggle toggle in TogglesToSync["EvenGunSpread"]) { toggle.isOn = EvenGunSpread; }
            foreach (Toggle toggle in TogglesToSync["BulletDrag"]) { toggle.isOn = BulletDrag; }
            foreach (Toggle toggle in TogglesToSync["ColdBullets"]) { toggle.isOn = ColdBullets; }
            foreach (Toggle toggle in TogglesToSync["Knockback"]) { toggle.isOn = Knockback; }
            foreach (Toggle toggle in TogglesToSync["BulletGravity"]) { toggle.isOn = BulletGravity; }
            foreach (Toggle toggle in TogglesToSync["TimeBetweenBursts"]) { toggle.isOn = TimeBetweenBursts; }
            foreach (Toggle toggle in TogglesToSync["AmmoRegeneration"]) { toggle.isOn = AmmoRegeneration; }
            foreach (Toggle toggle in TogglesToSync["Recoil"]) { toggle.isOn = Recoil; }
            foreach (Toggle toggle in TogglesToSync["BodyRecoil"]) { toggle.isOn = BodyRecoil; }
            foreach (Toggle toggle in TogglesToSync["RecoilMultiplier"]) { toggle.isOn = RecoilMultiplier; }
            //
            foreach (Toggle toggle in TogglesToSync["ChargedDamageMultiplier"]) { toggle.isOn = ChargedDamageMultiplier; }
            foreach (Toggle toggle in TogglesToSync["ChargedSpeed"]) { toggle.isOn = ChargedSpeed; }
            foreach (Toggle toggle in TogglesToSync["ChargedSpread"]) { toggle.isOn = ChargedGunSpread; }
            foreach (Toggle toggle in TogglesToSync["ChargedEvenGunSpread"]) { toggle.isOn = ChargedEvenGunSpread; }
            foreach (Toggle toggle in TogglesToSync["ChargedRecoil"]) { toggle.isOn = ChargedRecoil; }
            foreach (Toggle toggle in TogglesToSync["ChargedNumberOfProjectiles"]) { toggle.isOn = ChargedNumberOfProjectiles; }

            if (recurse > 0) { SyncOptionsMenus(recurse - 1); }
        }
    }
}