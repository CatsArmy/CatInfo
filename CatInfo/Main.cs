using BepInEx;
using UnboundLib;
using UnboundLib.Utils.UI;
using UnityEngine;
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
        
        //# Basic Stats Extended
        public static bool EchoBlocks
        {
            get
            {
                return GetBool("EchoBlocks", true);
            }
            set
            {
                SetBool("EchoBlocks", value);
            }
        }
        public static bool AttackSpeed
        {
            get
            {
                return GetBool("AttackSpeed", true);
            }
            set
            {
                SetBool("AttackSpeed", value);
            }
        }
        public static bool LifeSteal
        {
            get
            {
                return GetBool("LifeSteal", true);
            }
            set
            {
                SetBool("LifeSteal", value);
            }
        }
        public static bool BulletBounces
        {
            get
            {
                return GetBool("BulletBounces", true);
            }
            set
            {
                SetBool("BulletBounces", value);
            }
        }
        public static bool Bursts
        {
            get
            {
                return GetBool("Bursts", true);
            }
            set
            {
                SetBool("Bursts", value);
            }
        }
        public static bool Bullets
        {
            get
            {
                return GetBool("Bullets", true);
            }
            set
            {
                SetBool("Bullets", value);
            }
        }
        public static bool OnBounceBulletDamage
        {
            get
            {
                return GetBool("OnBounceBulletDamage", true);
            }
            set
            {
                SetBool("OnBounceBulletDamage", value);
            }
        }
        public static bool OnBounceBulletSpeed
        {
            get
            {
                return GetBool("OnBounceBulletSpeed", true);
            }
            set
            {
                SetBool("OnBounceBulletSpeed", value);
            }
        }
        //# Useful Stats
        public static bool UnblockableBullets
        {
            get
            {
                return GetBool("Unblockable", true);
            }
            set
            {
                SetBool("Unblockable", value);
            }
        }
        public static bool GhostBullets
        {
            get
            {
                return GetBool("Ghost", true);
            }
            set
            {
                SetBool("Ghost", value);
            }
        }
        public static bool UseCharge
        {
            get
            {
                return GetBool("UseCharge");
            }
            set
            {
                SetBool("UseCharge", value);
            }
        }
        public static bool DontAllowAutoFire
        {
            get
            {
                return GetBool("NoFullAutoInTheBuilding");
            }
            set
            {
                SetBool("NoFullAutoInTheBuilding", value);
            }
        }
        //# Advanced Health Stats
        public static bool Revives
        {
            get
            {
                return GetBool("Revives", true);
            }
            set
            {
                SetBool("Revives", value);
            }
        }
        public static bool HealingOnBlock
        {
            get
            {
                return GetBool("HealingOnBlock");
            }
            set
            {
                SetBool("HealingOnBlock", value);
            }
        }
        public static bool HealthDecay
        {
            get
            {
                return GetBool("HealthDecay", true);
            }
            set
            {
                SetBool("HealthDecay", value);
            }
        }
        public static bool Regenaration
        {
            get
            {
                return GetBool("Regenaration", true);
            }
            set
            {
                SetBool("Regenaration", value);
            }
        }
        public static bool Size
        {
            get
            {
                return GetBool("Size", true);
            }
            set
            {
                SetBool("Size", value);
            }
        }
        public static bool Jumps
        {
            get
            {
                return GetBool("Jumps");
            }
            set
            {
                SetBool("Jumps", value);
            }
        }
        public static bool JumpHight
        {
            get
            {
                return GetBool("JumpHight");
            }
            set
            {
                SetBool("JumpHight", value);
            }
        }
        public static bool Gravity
        {
            get
            {
                return GetBool("Gravity");
            }
            set
            {
                SetBool("Gravity", value);
            }
        }
        //#Advanced Gun Stats
        public static bool HealthCulling
        {
            get
            {
                return GetBool("HealthCulling", true);
            }
            set
            {
                SetBool("HealthCulling", value);
            }
        }
        public static bool BulletRange
        {
            get
            {
                return GetBool("BulletRange", true);
            }
            set
            {
                SetBool("BulletRange", value);
            }
        }
        public static bool BulletSpeed
        {
            get
            {
                return GetBool("BulletSpeed", true);
            }
            set
            {
                SetBool("BulletSpeed", value);
            }
        }
        public static bool BulletSize
        {
            get
            {
                return GetBool("BulletSize", true);
            }
            set
            {
                SetBool("BulletSize", value);
            }
        }
        public static bool ProjectileSize
        {
            get
            {
                return GetBool("ProjectileSize", true);
            }
            set
            {
                SetBool("ProjectileSize", value);
            }
        }
        public static bool ProjectileSpeed
        {
            get
            {
                return GetBool("ProjectileSpeed", true);
            }
            set
            {
                SetBool("ProjectileSpeed", value);
            }
        }
        public static bool DamageGrowth
        {
            get
            {
                return GetBool("DamageGrowth", true);
            }
            set
            {
                SetBool("DamageGrowth", value);
            }
        }
        public static bool BulletSpread
        {
            get
            {
                return GetBool("BulletSpread", true);
            }
            set
            {
                SetBool("BulletSpread", value);
            }
        }
        public static bool EvenBulletSpread
        {
            get
            {
                return GetBool("EvenBulletSpread");
            }
            set
            {
                SetBool("EvenBulletSpread", value);
            }
        }
        public static bool BulletDrag
        {
            get
            {
                return GetBool("BulletDrag");
            }
            set
            {
                SetBool("BulletDrag", value);
            }
        }
        public static bool BulletSlow
        {
            get
            {
                return GetBool("BulletSlow");
            }
            set
            {
                SetBool("BulletSlow", value);
            }
        }
        public static bool Knockback
        {
            get
            {
                return GetBool("Knockback", true);
            }
            set
            {
                SetBool("Knockback", value);
            }
        }
        public static bool BulletGravity
        {
            get
            {
                return GetBool("BulletGravity");
            }
            set
            {
                SetBool("BulletGravity", value);
            }
        }
        public static bool TimeBetweenBursts
        {
            get
            {
                return GetBool("TimeBetweenBursts");
            }
            set
            {
                SetBool("TimeBetweenBursts", value);
            }
        }
        public static bool AmmoRegen
        {
            get
            {
                return GetBool("AmmoRegen");
            }
            set
            {
                SetBool("AmmoRegen", value);
            }
        }
        public static bool Recoil
        {
            get
            {
                return GetBool("Recoil");
            }
            set
            {
                SetBool("Recoil", value);
            }
        }
        public static bool BodyRecoil
        {
            get
            {
                return GetBool("BodyRecoil");
            }
            set
            {
                SetBool("BodyRecoil", value);
            }
        }
        public static bool RecoilMultiplier
        {
            get
            {
                return GetBool("RecoilMultiplier");
            }
            set
            {
                SetBool("RecoilMultiplier", value);
            }
        }
        //#Charged Stats
        public static bool ChargedDamageMultiplier
        {
            get
            {
                return GetBool("ChargedDamageMultiplier");
            }
            set
            {
                SetBool("ChargedDamageMultiplier", value);
            }
        }
        public static bool ChargedSpeed
        {
            get
            {
                return GetBool("ChargedSpeed");
            }
            set
            {
                SetBool("ChargedSpeed", value);
            }
        }
        public static bool ChargedSpread
        {
            get
            {
                return GetBool("ChargedSpread");
            }
            set
            {
                SetBool("ChargedSpread", value);
            }
        }
        public static bool ChargedEvenSpread
        {
            get
            {
                return GetBool("ChargedEvenSpread");
            }
            set
            {
                SetBool("ChargedEvenSpread", value);
            }
        }
        public static bool ChargedRecoil
        {
            get
            {
                return GetBool("ChargedRecoil");
            }
            set
            {
                SetBool("ChargedRecoil", value);
            }
        }
        public static bool ChargedNumberOfProjectiles
        {
            get
            {
                return GetBool("ChargedNumberOfProjectiles");
            }
            set
            {
                SetBool("ChargedNumberOfProjectiles", value);
            }
        }


        private void Start()
        {
            TabinfoInterface.Setup();
            Unbound.RegisterClientSideMod(ModId);

            Unbound.RegisterMenu(ModName, () => { }, NewGUI, null, true);
            
            Unbound.RegisterGUI(ModName + " Basic Stats", DrawBasicStatsGUI);
            Unbound.RegisterGUI(ModName + " Useful Stats", DrawUsefulStatsGUI);
            Unbound.RegisterGUI(ModName + " Advanced Health Stats", DrawAdvHealthStatsGUI);
            Unbound.RegisterGUI(ModName + " Advanced Gun Stats", DrawAdvGunStatsGUI);
            Unbound.RegisterGUI(ModName + " Charged Stats", DrawChargedStatsGUI);
        }
        private static void NewGUI(GameObject menu)
        {
            MenuHandler.CreateText(" Toggle" + ModName + "Stats", menu, out TextMeshProUGUI _, 70);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn(), 60, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset(), 60);
            MenuHandler.CreateButton("Disable All", menu, () => PresetOff(), 60, color: hardChangeColor);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30); MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
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

        }
        //Toggle Presets
        private static void PresetOn(string menuCat = "menuCatagory")
        {
            bool setValue = true;
            if (menuCat == "menuCatagory" || menuCat == "BasicStats")
            {//BasicStats
                EchoBlocks = setValue;
                AttackSpeed = setValue;
                LifeSteal = setValue;
                BulletBounces = setValue;
                Bursts = setValue;
                Bullets = setValue;
                OnBounceBulletDamage = setValue;
                OnBounceBulletSpeed = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                UnblockableBullets = setValue;
                GhostBullets = setValue;
                UseCharge = setValue;
                DontAllowAutoFire = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvHealthStats")
            {//AdvHealthStats  
                Revives = setValue;
                HealingOnBlock = setValue;
                HealthDecay = setValue;
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
                ProjectileSpeed = setValue;
                DamageGrowth = setValue;
                BulletSpread = setValue;
                EvenBulletSpread = setValue;
                BulletDrag = setValue;
                BulletSlow = setValue;
                BulletGravity = setValue;
                Knockback = setValue;
                TimeBetweenBursts = setValue;
                AmmoRegen = setValue;
                Recoil = setValue;
                BodyRecoil = setValue;
                RecoilMultiplier = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "ChargedStats")
            {//ChargedStats
                ChargedDamageMultiplier = setValue;
                ChargedSpeed = setValue;
                ChargedSpread = setValue;
                ChargedEvenSpread = setValue;
                ChargedRecoil = setValue;
                ChargedNumberOfProjectiles = setValue;
            }
        }
        private static void PresetOff(string menuCat = "menuCatagory")
        {
            bool setValue = false;
            if (menuCat == "menuCatagory" || menuCat == "BasicStats")
            {//BasicStats
                EchoBlocks = setValue;
                AttackSpeed = setValue;
                LifeSteal = setValue;
                BulletBounces = setValue;
                Bursts = setValue;
                Bullets = setValue;
                OnBounceBulletDamage = setValue;
                OnBounceBulletSpeed = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                UnblockableBullets = setValue;
                GhostBullets = setValue;
                UseCharge = setValue;
                DontAllowAutoFire = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvHealthStats")
            {//AdvHealthStats  
                Revives = setValue;
                HealingOnBlock = setValue;
                HealthDecay = setValue;
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
                ProjectileSpeed = setValue;
                DamageGrowth = setValue;
                BulletSpread = setValue;
                EvenBulletSpread = setValue;
                BulletDrag = setValue;
                BulletSlow = setValue;
                BulletGravity = setValue;
                Knockback = setValue;
                TimeBetweenBursts = setValue;
                AmmoRegen = setValue;
                Recoil = setValue;
                BodyRecoil = setValue;
                RecoilMultiplier = setValue;
            }
            if (menuCat == "menuCatagory" || menuCat == "ChargedStats")
            {//ChargedStats
                ChargedDamageMultiplier = setValue;
                ChargedSpeed = setValue;
                ChargedSpread = setValue;
                ChargedEvenSpread = setValue;
                ChargedRecoil = setValue;
                ChargedNumberOfProjectiles = setValue;
            }
        }
        private static void ResetToDefualtPreset(string menuCat = "menuCatagory")
        {
            if (menuCat == "menuCatagory" || menuCat == "BasicStats")
            {//BasicStats
                EchoBlocks = true;
                AttackSpeed = true;
                LifeSteal = true;
                BulletBounces = true;
                Bursts = true;
                Bullets = true;
                OnBounceBulletDamage = true;
            }
            if (menuCat == "menuCatagory" || menuCat == "UsefulStats")
            {//UsefulStats
                OnBounceBulletSpeed = true;
                UnblockableBullets = true;
                GhostBullets = true;
                UseCharge = false;
                DontAllowAutoFire = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "AdvHealthStats")
            {//AdvHealthStats
                Revives = true;
                HealingOnBlock = false;
                HealthDecay = true;
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
                ProjectileSpeed = true;
                DamageGrowth = true;
                BulletSpread = true;
                EvenBulletSpread = false;
                BulletDrag = false;
                BulletSlow = false;
                BulletGravity = false;
                Knockback = true;
                TimeBetweenBursts = false;
                AmmoRegen = false;
                Recoil = false;
                BodyRecoil = false;
                RecoilMultiplier = false;
            }
            if (menuCat == "menuCatagory" || menuCat == "ChargedStats")
            {//ChargedStats
                ChargedDamageMultiplier = false;
                ChargedSpeed = false;
                ChargedSpread = false;
                ChargedEvenSpread = false;
                ChargedRecoil = false;
                ChargedNumberOfProjectiles = false;
            }
        }
        //Toggles
        private static void BasicStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("BasicStats"), 60, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("BasicStats"), 60);
            MenuHandler.CreateButton("Disable All", menu, () => PresetOff("BasicStats"), 60, color: hardChangeColor);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30); MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("This Cannot Toggle The Defualt Basic Stats That TabInfo Adds Only The Ones That CatInfo Adds", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(EchoBlocks, "Echo Blocks", menu, value => EchoBlocks = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(AttackSpeed, "Attack Speed", menu, value => AttackSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(LifeSteal, "Life Steal", menu, value => LifeSteal = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletBounces, "Bullet Bounces", menu, value => BulletBounces = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Bursts, "Bursts", menu, value => Bursts = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Bullets, "Bullets", menu, value => Bullets = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(OnBounceBulletDamage, "On Bounce Bullet Damage", menu, value => OnBounceBulletDamage = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(OnBounceBulletSpeed, "On Bounce Bullet Speed", menu, value => OnBounceBulletSpeed = value, fontSize: 50, forceUpper: false);
        }
        private static void UsefulStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("UsefulStats"), 60, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("UsefulStats"), 60);
            MenuHandler.CreateButton("Disable All", menu, () => PresetOff("UsefulStats"), 60, color: hardChangeColor);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30); MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Unblockable Bullets is just unblockable bullets", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(UnblockableBullets, "Unblockable Bullets", menu, value => UnblockableBullets = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Ghost Bullets lets your bullets pass through walls and shit", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(GhostBullets, "Ghost Bullets", menu, value => GhostBullets = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Causes the gun to use a charge system for firing (like Plasma Rifle/Shotgun From WWC). None of the charge stats work without this being set to true", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(UseCharge, "Chargable Plasma Gun", menu, value => UseCharge = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Dont Allow Auto Fire Prevents a player from firing their gun by holding down the shoot button", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(DontAllowAutoFire, "Dont Allow Auto Fire", menu, value => DontAllowAutoFire = value, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedHealthStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("AdvHealthStats"), 60, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("AdvHealthStats"), 60);
            MenuHandler.CreateButton("Disable All", menu, () => PresetOff("AdvHealthStats"), 60, color: hardChangeColor);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30); MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Revives, "Revives", menu, value => Revives = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Healing On Block adds to the amount of HP the player heals when they block", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(HealingOnBlock, "Healing On Block", menu, value => HealingOnBlock = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Health Decay increases the amount of time damage is applied to the player over", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(HealthDecay, "Health Decay", menu, value => HealthDecay = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Regenaration, "Regenaration", menu, value => Regenaration = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("The Size stat multiplies the current size of the player", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Size, "Size", menu, value => Size = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Jumps, "Jumps", menu, value => Jumps = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(JumpHight, "Jump Hight", menu, value => JumpHight = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Gravity, "Gravity", menu, value => Gravity = value, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedGunStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("AdvGunStats"), 60, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("AdvGunStats"), 60);
            MenuHandler.CreateButton("Disable All", menu, () => PresetOff("AdvGunStats"), 60, color: hardChangeColor);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30); MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("%Health Culling is how much of the target's max HP adds as additional damage", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(HealthCulling, "%Health Culling", menu, value => HealthCulling = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletRange, "Bullet Range", menu, value => BulletRange = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletSpeed, "Bullet Speed", menu, value => BulletSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Bullet Size makes ur bullet bigger", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(BulletSize, "Bullet Size", menu, value => BulletSize = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Projectile Size makes ur projectiles bigger", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(ProjectileSize, "Projectile Size", menu, value => ProjectileSize = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Projectile Size And Bullet Size are diffrent but idk in what way", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(ProjectileSpeed, "Projectile Speed", menu, value => ProjectileSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Damage Growth adjusts the damage of the bullet after it moves 10 units", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(DamageGrowth, "Damage Growth", menu, value => DamageGrowth = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletSpread, "Bullet Spread", menu, value => BulletSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(EvenBulletSpread, "Even Bullet Spread", menu, value => EvenBulletSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Bullet Drag is how much the bullet is affected by simulated air resistance", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(BulletDrag, "Bullet Drag", menu, value => BulletDrag = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletSlow, "Bullet Slow", menu, value => BulletSlow = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletGravity, "Bullet Gravity", menu, value => BulletGravity = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Knockback, "Knockback", menu, value => Knockback = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(TimeBetweenBursts, "Time Between Bursts", menu, value => TimeBetweenBursts = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("%Ammo Regen is the percentage of ammo regenerated each second", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(AmmoRegen, "%Ammo Regen", menu, value => AmmoRegen = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("What i use as the total recoil of bodyrecoil * chargerecoil * recoilmultiplier", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(Recoil, "Recoil", menu, value => Recoil = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BodyRecoil, "Body Recoil", menu, value => BodyRecoil = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(RecoilMultiplier, "Recoil Multiplier", menu, value => RecoilMultiplier = value, fontSize: 50, forceUpper: false);
        }
        private static void ChargedStatsToggles(GameObject menu)
        {
            MenuHandler.CreateButton("Enable All", menu, () => PresetOn("ChargedStats"), 60, color: easyChangeColor);
            MenuHandler.CreateButton("Reset To Defualt", menu, () => ResetToDefualtPreset("ChargedStats"), 60);
            MenuHandler.CreateButton("Disable All", menu, () => PresetOff("ChargedStats"), 60, color: hardChangeColor);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30); MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(ChargedDamageMultiplier, "Plasma Charged Damage Multiplier", menu, value => ChargedDamageMultiplier = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(ChargedSpeed, "Plasma Charged Speed", menu, value => ChargedSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(ChargedSpread, "Plasma Charged Spread", menu, value => ChargedSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(ChargedEvenSpread, "Plasma Charged Even Spread", menu, value => ChargedEvenSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(ChargedRecoil, "Plasma Charged Recoil", menu, value => ChargedRecoil = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(ChargedNumberOfProjectiles, "Plasma Charged Number Of Bullets", menu, value => ChargedNumberOfProjectiles = value, fontSize: 50, forceUpper: false);
        }
        void DrawBasicStatsGUI()
        {
            EchoBlocks = GUILayout.Toggle(EchoBlocks, "Echo Blocks");
            AttackSpeed = GUILayout.Toggle(AttackSpeed, "Attack Speed");
            LifeSteal = GUILayout.Toggle(LifeSteal, "Life Steal");
            BulletBounces = GUILayout.Toggle(BulletBounces, "Bounces");
            Bursts = GUILayout.Toggle(Bursts, "Bursts");
            Bullets = GUILayout.Toggle(Bullets, "Bullets");
            OnBounceBulletDamage = GUILayout.Toggle(OnBounceBulletDamage, "On Bounce Bullet Damage");
            OnBounceBulletSpeed = GUILayout.Toggle(OnBounceBulletSpeed, "On Bounce Bullet Speed");
        }
        void DrawUsefulStatsGUI()
        {
            UnblockableBullets = GUILayout.Toggle(UnblockableBullets, "Unblockable Bullets");
            GhostBullets = GUILayout.Toggle(GhostBullets, "Ghost Bullets");
            UseCharge = GUILayout.Toggle(UseCharge, "Use Charge");
            DontAllowAutoFire = GUILayout.Toggle(DontAllowAutoFire, "Dont Allow Auto Fire");
        }
        void DrawAdvHealthStatsGUI()
        {
            Revives = GUILayout.Toggle(Revives, "Revives");
            HealingOnBlock = GUILayout.Toggle(HealingOnBlock, "Healing On Block");
            HealthDecay = GUILayout.Toggle(HealthDecay, "Health Decay");
            Regenaration = GUILayout.Toggle(Regenaration, "Regenaration");
            Size = GUILayout.Toggle(Size, "Size");
            Jumps = GUILayout.Toggle(Jumps, "Jumps");
            JumpHight = GUILayout.Toggle(JumpHight, "Jump Hight");
            Gravity = GUILayout.Toggle(Gravity, "Gravity");
        }
        void DrawAdvGunStatsGUI()
        {
            HealthCulling = GUILayout.Toggle(HealthCulling, "%Health Culling");
            BulletRange = GUILayout.Toggle(BulletRange, "Bullet Range");
            BulletSpeed = GUILayout.Toggle(BulletSpeed, "Bullet Speed");
            BulletSize = GUILayout.Toggle(BulletSize, "Bullet Size");
            ProjectileSize = GUILayout.Toggle(ProjectileSize, "Projectile Size");
            ProjectileSpeed = GUILayout.Toggle(ProjectileSpeed, "Projectile Speed");
            DamageGrowth = GUILayout.Toggle(DamageGrowth, "Damage Growth");
            BulletSpread = GUILayout.Toggle(BulletSpread, "Bullet Spread");
            EvenBulletSpread = GUILayout.Toggle(EvenBulletSpread, "Even Bullet Spread");
            BulletDrag = GUILayout.Toggle(BulletDrag, "Bullet Drag");
            BulletSlow = GUILayout.Toggle(BulletSlow, "Bullet Slow");
            BulletGravity = GUILayout.Toggle(BulletGravity, "Bullet Gravity");
            Knockback = GUILayout.Toggle(Knockback, "Knockback");
            TimeBetweenBursts = GUILayout.Toggle(TimeBetweenBursts, "Time Between Bursts");
            AmmoRegen = GUILayout.Toggle(AmmoRegen, "%Ammo Regenaration");
            Recoil = GUILayout.Toggle(Recoil, "Recoil");
            BodyRecoil = GUILayout.Toggle(BodyRecoil, "Body Recoil");
            RecoilMultiplier = GUILayout.Toggle(RecoilMultiplier, "Recoil Multiplier");
        }
        void DrawChargedStatsGUI()
        {
            ChargedDamageMultiplier = GUILayout.Toggle(ChargedDamageMultiplier, "Charged Damage Multiplier");
            ChargedSpeed = GUILayout.Toggle(ChargedSpeed, "Charged Speed");
            ChargedSpread = GUILayout.Toggle(ChargedSpread, "Charged Spread");
            ChargedEvenSpread = GUILayout.Toggle(ChargedEvenSpread, "Charged Even Spread");
            ChargedRecoil = GUILayout.Toggle(ChargedRecoil, "Charged Recoil");
            ChargedNumberOfProjectiles = GUILayout.Toggle(ChargedNumberOfProjectiles, "Charged Number Of Projectiles");
        }
    }
}