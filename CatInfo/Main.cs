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
        public const string Version = "2.0.0";
        public const string ModInitials = "Cats";

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
        //# Useful Stats
        public static bool Unblockable
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
        public static bool Ghost
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
                return GetBool("HealingOnBlock", true);
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
        public static bool BulletDrag
        {
            get
            {
                return GetBool("BulletDrag", true);
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
                return GetBool("BulletSlow", true);
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
        //# On Bounce Multiplyers
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

        private void Start()
        {
            TabinfoInterface.Setup();
            Unbound.RegisterClientSideMod(ModId);

            Unbound.RegisterMenu(ModName, () => { }, NewGUI, null, false);
        }
        private static void NewGUI(GameObject menu)
        {
            MenuHandler.CreateText(ModName + " Options", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            GameObject BasicStatsExtended = MenuHandler.CreateMenu("BasicStatsExtended", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            BasicStatsExtendedToggles(BasicStatsExtended);
            GameObject UsefulStats = MenuHandler.CreateMenu("UsefulStats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            UsefulStatsToggles(UsefulStats);
            GameObject AdvancedHealthStats = MenuHandler.CreateMenu("AdvancedHealthStats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            AdvancedHealthStatsToggles(AdvancedHealthStats);
            GameObject AdvancedGunStats = MenuHandler.CreateMenu("AdvancedGunStats", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            AdvancedGunStatsToggles(AdvancedGunStats);
            GameObject OnBounceEffects = MenuHandler.CreateMenu("OnBounceMultipliers", () => { }, menu, 60, true, true, menu.transform.parent.gameObject);
            OnBounceEffectsToggles(OnBounceEffects);
        }
        private static void BasicStatsExtendedToggles(GameObject menu)
        {
            MenuHandler.CreateToggle(EchoBlocks, "Echo Blocks", menu, value => EchoBlocks = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(AttackSpeed, "Attack Speed", menu, value => AttackSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(LifeSteal, "Life Steal", menu, value => LifeSteal = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletBounces, "Bullet Bounces", menu, value => BulletBounces = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(Bursts, "Bursts", menu, value => Bursts = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(Bullets, "Bullets", menu, value => Bullets = value, fontSize: 50, forceUpper: false);
        }
        private static void UsefulStatsToggles(GameObject menu)
        {
            MenuHandler.CreateToggle(Unblockable, "Unblockable", menu, value => Unblockable = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(Ghost, "Ghost", menu, value => Ghost = value, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedHealthStatsToggles(GameObject menu)
        {
            MenuHandler.CreateToggle(Revives, "Revives", menu, value => Revives = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(HealingOnBlock, "Healing On Block", menu, value => HealingOnBlock = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(HealthDecay, "Health Decay", menu, value => HealthDecay = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(Regenaration, "Regenaration", menu, value => Regenaration = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(Size, "Size", menu, value => Size = value, fontSize: 50, forceUpper: false);

        }
        private static void AdvancedGunStatsToggles(GameObject menu)
        {
            MenuHandler.CreateToggle(HealthCulling, "Health Culling", menu, value => HealthCulling = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletSize, "Bullet Size", menu, value => BulletSize = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletRange, "Bullet Range", menu, value => BulletRange = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletSpeed, "Bullet Speed", menu, value => BulletSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(ProjectileSpeed, "Projectile Speed", menu, value => ProjectileSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(DamageGrowth, "Damage Growth", menu, value => DamageGrowth = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletSpread, "Bullet Spread", menu, value => BulletSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletDrag, "Bullet Drag", menu, value => BulletDrag = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BulletSlow, "Bullet Slow", menu, value => BulletSlow = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(Knockback, "Knockback", menu, value => Knockback = value, fontSize: 50, forceUpper: false);

        }
        private static void OnBounceEffectsToggles(GameObject menu)
        {
            MenuHandler.CreateToggle(OnBounceBulletDamage, "On Bounce Bullet Damage", menu, value => OnBounceBulletDamage = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(OnBounceBulletSpeed, "On Bounce Bullet Speed", menu, value => OnBounceBulletSpeed = value, fontSize: 50, forceUpper: false);
        }

    }
}