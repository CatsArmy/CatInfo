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
        public const string Version = "2.2.2";
        public const string ModInitials = "Cats";

        private static Color HolyWhiteText = new Color(255f, 255f, 255f, 1f);
        private static Color GreenText = new Color(0.521f, 1f, 0.521f, 1f);
        private static Color RedText = new Color(1f, 0.521f, 0.521f, 1f);

        private static void CycleArt()
        {
            ArtHandler.instance.NextArt();
            ArtHandler.instance.NextArt();
        }

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
        public static bool RecoilMultiplier
        {
            get { return GetBool("RecoilMultiplier"); }
            set { SetBool("RecoilMultiplier", value); }
        }

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

            if (DeprecatedGUI)
            {
                Unbound.RegisterGUI($"{ModName} Basic Stats", DrawBasicStatsGUI);
                Unbound.RegisterGUI($"{ModName} Useful Stats", DrawUsefulStatsGUI);
                Unbound.RegisterGUI($"{ModName} Advanced Character Stats", DrawAdvCharacterStatsGUI);
                Unbound.RegisterGUI($"{ModName} Advanced Gun Stats", DrawAdvGunStatsGUI);
                Unbound.RegisterGUI($"{ModName} Charged Stats", DrawChargedStatsGUI);
            }
        }
        //Deprecated GUI Toggles
        private void DrawBasicStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Basic Stats");
                EchoBlocks = GUILayout.Toggle(EchoBlocks, "Echo Blocks");
                AttackSpeed = GUILayout.Toggle(AttackSpeed, "Attack Speed");
                LifeSteal = GUILayout.Toggle(LifeSteal, "Life Steal");
                Bounces = GUILayout.Toggle(Bounces, "Bounces");
                Bursts = GUILayout.Toggle(Bursts, "Bursts");
                Bullets = GUILayout.Toggle(Bullets, "Bullets");
                BounceDamage = GUILayout.Toggle(BounceDamage, "Bounce Damage");
                BounceSpeed = GUILayout.Toggle(BounceSpeed, "Bounce Speed");
            }
        }
        private void DrawUsefulStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Useful Stats");
                Unblockable = GUILayout.Toggle(Unblockable, "Unblockable Bullets");
                GhostBullets = GUILayout.Toggle(GhostBullets, "Ghost Bullets");
                Chargable = GUILayout.Toggle(Chargable, "Chargable");
                DemonicGun = GUILayout.Toggle(DemonicGun, "Demonic Gun");
            }
        }
        private void DrawAdvCharacterStatsGUI()
        {
            if (DeprecatedGUI)
            {
                GUILayout.Label("Advanced Character Stats");
                Phoenix = GUILayout.Toggle(Phoenix, "Phoenix");
                HealingOnBlock = GUILayout.Toggle(HealingOnBlock, "Healing On Block");
                Decay = GUILayout.Toggle(Decay, "Decay");
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
                GUILayout.Label("Advanced Gun Stats");
                HealthCulling = GUILayout.Toggle(HealthCulling, "%Health Culling");
                BulletRange = GUILayout.Toggle(BulletRange, "Bullet Range");
                BulletSpeed = GUILayout.Toggle(BulletSpeed, "Bullet Speed");
                BulletSize = GUILayout.Toggle(BulletSize, "Bullet Size");
                ProjectileSize = GUILayout.Toggle(ProjectileSize, "Projectile Size");
                ProjectileTimeScale = GUILayout.Toggle(ProjectileTimeScale, "Projectile Time Scale");
                DamageGrowth = GUILayout.Toggle(DamageGrowth, "Damage Growth");
                GunSpread = GUILayout.Toggle(GunSpread, "Gun Spread");
                EvenGunSpread = GUILayout.Toggle(EvenGunSpread, "Even Gun Spread");
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
                GUILayout.Label("Charged Stats");
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
            MenuHandler.CreateText($"Toggle {ModName} Stats", menu, out TextMeshProUGUI _, 90);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 45);

            MenuHandler.CreateButton("<b>Enable All</b>", menu, () => PresetOn(), 75, color: GreenText);
            MenuHandler.CreateButton("<b>Reset To Defualt</b>", menu, () => ResetToDefualtPreset(), 75, color: HolyWhiteText);
            MenuHandler.CreateButton("<b>Disable All</b>", menu, () => PresetOff(), 75, color: RedText);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            GameObject BasicStats = MenuHandler.CreateMenu("Basic Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            BasicStatsToggles(BasicStats);
            GameObject UsefulStats = MenuHandler.CreateMenu("Useful Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            UsefulStatsToggles(UsefulStats);
            GameObject AdvancedHealthStats = MenuHandler.CreateMenu("Advanced Character Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            AdvancedCharacterStatsToggles(AdvancedHealthStats);
            GameObject AdvancedGunStats = MenuHandler.CreateMenu("Advanced Gun Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            AdvancedGunStatsToggles(AdvancedGunStats);
            GameObject ChargedStats = MenuHandler.CreateMenu("Charged Stats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            ChargedStatsToggles(ChargedStats);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);

            void DeprecatedGUIChanged(bool value)
            {
                DeprecatedGUI = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(DeprecatedGUI,"Deprecated GUI", menu,DeprecatedGUIChanged, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText("Requires Restart Not Recommended", menu, out TextMeshProUGUI _, 50, color: RedText, forceUpper: false);
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
            if (menuCat == "menuCatagory" || menuCat == "AdvCharacterStats")
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
            CycleArt();
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
            if (menuCat == "menuCatagory" || menuCat == "AdvCharacterStats")
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
            CycleArt();
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
                BounceSpeed = true;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                Unblockable = true;
                GhostBullets = true;
                Chargable = false;
                DemonicGun = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvCharacterStats")
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
            CycleArt();
        }
        //Menu GUI Toggles
        private static void BasicStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("<b>Enable All</b>", menu, () => PresetOn("BasicStats"), 75, color: GreenText);
            MenuHandler.CreateButton("<b>Reset To Defualt</b>", menu, () => ResetToDefualtPreset("BasicStats"), 75, color: HolyWhiteText);
            MenuHandler.CreateButton("<b>Disable All</b>", menu, () => PresetOff("BasicStats"), 75, color: RedText);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Can Only Toggle Basic Stats Added By CatInfo", menu, out TextMeshProUGUI _, 40);

            void EchoBlocksChanged(bool value)
            {
                EchoBlocks = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(EchoBlocks, "Echo Blocks", menu, EchoBlocksChanged, fontSize: 50, forceUpper: false);

            void AttackSpeedChanged(bool value)
            {
                AttackSpeed = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(AttackSpeed, "Attack Speed", menu, AttackSpeedChanged, fontSize: 50, forceUpper: false);

            void LifeStealChanged(bool value)
            {
                LifeSteal = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(LifeSteal, "Life Steal", menu, LifeStealChanged, fontSize: 50, forceUpper: false);
            void BouncesChanged(bool value)
            {
                Bounces = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Bounces, "Bounces", menu, BouncesChanged, fontSize: 50, forceUpper: false);
            void BurstsChanged(bool value)
            {
                Bursts = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Bursts, "Bursts", menu, BurstsChanged, fontSize: 50, forceUpper: false);
            void BulletsChanged(bool value)
            {
                Bullets = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Bullets, "Bullets", menu, BulletsChanged, fontSize: 50, forceUpper: false);
            void BounceDamageChanged(bool value)
            {
                BounceDamage = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BounceDamage, "Bounce Damage", menu, BounceDamageChanged, fontSize: 50, forceUpper: false);
            void BounceSpeedChanged(bool value)
            {
                BounceSpeed = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BounceSpeed, "Bounce Speed", menu, BounceSpeedChanged, fontSize: 50, forceUpper: false);
        }
        private static void UsefulStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("<b>Enable All</b>", menu, () => PresetOn("UsefulStats"), 75, color: GreenText);
            MenuHandler.CreateButton("<b>Reset To Defualt</b>", menu, () => ResetToDefualtPreset("UsefulStats"), 75, color: HolyWhiteText);
            MenuHandler.CreateButton("<b>Disable All</b>", menu, () => PresetOff("UsefulStats"), 75, color: RedText);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);

            void UnblockableChanged(bool value)
            {
                Unblockable = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Unblockable,"Unblockable", menu, UnblockableChanged, fontSize: 50, forceUpper: false);
            void GhostBulletsChanged(bool value)
            {
                GhostBullets = value;
                CycleArt(); 
            }
            MenuHandler.CreateToggle(GhostBullets, "Ghost Bullets", menu, GhostBulletsChanged, fontSize: 50, forceUpper: false);
            void ChargableChanged(bool value)
            {
                Chargable = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Chargable, "Chargable", menu, ChargableChanged, fontSize: 50, forceUpper: false);
            void DemonicGunChanged(bool value)
            {
                DemonicGun = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(DemonicGun, "Demonic Gun", menu, DemonicGunChanged, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedCharacterStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("<b>Enable All</b>", menu, () => PresetOn("AdvCharacterStats"), 75, color: GreenText);
            MenuHandler.CreateButton("<b>Reset To Defualt</b>", menu, () => ResetToDefualtPreset("AdvCharacterStats"), 75, color: HolyWhiteText);
            MenuHandler.CreateButton("<b>Disable All</b>", menu, () => PresetOff("AdvCharacterStats"), 75, color: RedText);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);

            void PhoenixChanged(bool value)
            {
                Phoenix = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Phoenix,"Phoenix", menu, PhoenixChanged, fontSize: 50, forceUpper: false);
            void HealingOnBlockChanged(bool value)
            {
                HealingOnBlock = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(HealingOnBlock,"Healing On Block", menu, HealingOnBlockChanged, fontSize: 50, forceUpper: false);
            void DecayChanged(bool value)
            {
                Decay = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Decay,"Decay", menu, DecayChanged, fontSize: 50, forceUpper: false);
            void RegenerationChanged(bool value)
            {
                Regenaration = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Regenaration,"Regeneration", menu, RegenerationChanged, fontSize: 50, forceUpper: false);
            void SizeChanged(bool value)
            {
                Size = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Size,"Size", menu, SizeChanged, fontSize: 50, forceUpper: false);
            void JumpsChanged(bool value)
            {
                Jumps = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Jumps,"Jumps", menu, JumpsChanged, fontSize: 50, forceUpper: false);
            void JumpHightChanged(bool value)
            {
                JumpHight = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(JumpHight,"Jump Hight", menu, JumpHightChanged, fontSize: 50, forceUpper: false);
            void GravityChanged(bool value)
            {
                Gravity = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Gravity, "Gravity", menu, GravityChanged, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedGunStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("<b>Enable All</b>", menu, () => PresetOn("AdvGunStats"), 75, color: GreenText);
            MenuHandler.CreateButton("<b>Reset To Defualt</b>", menu, () => ResetToDefualtPreset("AdvGunStats"), 75, color: HolyWhiteText);
            MenuHandler.CreateButton("<b>Disable All</b>", menu, () => PresetOff("AdvGunStats"), 75, color: RedText);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);

            void HealthCullingChanged(bool value) 
            {
                HealthCulling = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(HealthCulling,"%Health Culling", menu, HealthCullingChanged, fontSize: 50, forceUpper: false);
            void BulletRangeChanged(bool value)
            {
                BulletRange = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BulletRange, "Bullet Range", menu, BulletRangeChanged, fontSize: 50, forceUpper: false);
            void BulletSpeedChanged(bool value)
            {
                BulletSpeed = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BulletSpeed,"Bullet Speed", menu, BulletSpeedChanged, fontSize: 50, forceUpper: false);
            void BulletSizeChanged(bool value)
            {
                BulletSize = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BulletSize,"Bullet Size", menu, BulletSizeChanged, fontSize: 50, forceUpper: false);
            void ProjectileSizeChanged(bool value)
            {
                ProjectileSize = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ProjectileSize,"Projectile Size", menu, ProjectileSizeChanged, fontSize: 50, forceUpper: false);
            void ProjectileTimeScaleChanged(bool value)
            {
                ProjectileTimeScale = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ProjectileTimeScale,"Projectile Time Scale", menu, ProjectileTimeScaleChanged, fontSize: 50, forceUpper: false);
            void DamageGrowthChanged(bool value)
            {
                DamageGrowth = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(DamageGrowth,"Damage Growth", menu, DamageGrowthChanged, fontSize: 50, forceUpper: false);
            void GunSpreadChanged(bool value)
            {
                GunSpread = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(GunSpread,"Gun Spread", menu, GunSpreadChanged, fontSize: 50, forceUpper: false);
            void EvenGunSpreadChanged(bool value)
            {
                EvenGunSpread = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(EvenGunSpread,"Even Gun Spread", menu, EvenGunSpreadChanged, fontSize: 50, forceUpper: false);
            void BulletDragChanged(bool value)
            {
                BulletDrag = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BulletDrag,"Bullet Drag", menu, BulletDragChanged, fontSize: 50, forceUpper: false);
            void ColdBulletsChanged(bool value)
            {
                ColdBullets = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ColdBullets,"Cold Bullets", menu, ColdBulletsChanged, fontSize: 50, forceUpper: false);
            void BulletGravityChanged(bool value)
            {
                BulletGravity = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BulletGravity,"Bullet Gravity", menu, BulletGravityChanged, fontSize: 50, forceUpper: false);
            void KnockbackChanged(bool value)
            {
                Knockback = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Knockback,"Knockback", menu, KnockbackChanged, fontSize: 50, forceUpper: false);
            void TimeBetweenBurstsChanged(bool value)
            {
                TimeBetweenBursts = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(TimeBetweenBursts,"Time Between Bursts", menu, TimeBetweenBurstsChanged, fontSize: 50, forceUpper: false);
            void AmmoRegenerationChanged(bool value)
            {
                AmmoRegeneration = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(AmmoRegeneration, "%Ammo Regeneration", menu, AmmoRegenerationChanged, fontSize: 50, forceUpper: false);
            void RecoilChanged(bool value)
            {
                Recoil = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(Recoil,"Recoil", menu, RecoilChanged, fontSize: 50, forceUpper: false);
            void BodyRecoilChanged(bool value)
            {
                BodyRecoil = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(BodyRecoil,"Body Recoil", menu, BodyRecoilChanged, fontSize: 50, forceUpper: false);
            void RecoilMultiplierChanged(bool value)
            {
                RecoilMultiplier = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(RecoilMultiplier,
            "Recoil Multiplier", menu, RecoilMultiplierChanged, fontSize: 50, forceUpper: false);
        }
        private static void ChargedStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("<b>Enable All</b>", menu, () => PresetOn("ChargedStats"), 75, color: GreenText);
            MenuHandler.CreateButton("<b>Reset To Defualt</b>", menu, () => ResetToDefualtPreset("ChargedStats"), 75, color: HolyWhiteText);
            MenuHandler.CreateButton("<b>Disable All</b>", menu, () => PresetOff("ChargedStats"), 75, color: RedText);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);

            void ChargedDamageMultiplierChanged(bool value)
            {
                ChargedDamageMultiplier = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ChargedDamageMultiplier, "Charged Damage Multiplier", menu, ChargedDamageMultiplierChanged, fontSize: 50, forceUpper: false);
            void ChargedSpeedChanged(bool value)
            {
                ChargedSpeed = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ChargedSpeed, "Charged Speed", menu, ChargedSpeedChanged, fontSize: 50, forceUpper: false);
            void ChargedGunSpreadChanged(bool value)
            {
                ChargedGunSpread = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ChargedGunSpread, "Charged Gun Spread", menu, ChargedGunSpreadChanged, fontSize: 50, forceUpper: false);
            void ChargedEvenGunSpreadChanged(bool value)
            {
                ChargedEvenGunSpread = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ChargedEvenGunSpread, "Charged Even Gun Spread", menu, ChargedEvenGunSpreadChanged, fontSize: 50, forceUpper: false);
            void ChargedRecoilChanged(bool value)
            {
                ChargedRecoil = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ChargedRecoil,"Charged Recoil", menu, ChargedRecoilChanged, fontSize: 50, forceUpper: false);
            void ChargedNumberOfProjectilesChanged(bool value)
            {
                ChargedNumberOfProjectiles = value;
                CycleArt();
            }
            MenuHandler.CreateToggle(ChargedNumberOfProjectiles,"Charged Number Of Projectiles", menu, ChargedNumberOfProjectilesChanged, fontSize: 50, forceUpper: false);
        }
    }
}