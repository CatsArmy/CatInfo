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
        public const string Version = "2.1.2";
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
        public static bool GhostBullet
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
        public static bool NoFullAutoInTheBuilding
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
        }
        private static void NewGUI(GameObject menu)
        {
            MenuHandler.CreateText(" Toggle" + ModName + "Stats", menu, out TextMeshProUGUI _, 70);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
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
            
            GameObject PresetOn = MenuHandler.CreateButton("",menu,60,PresetAllOn(),true,menu);
        }
        private static void PresetAllOn(GameObject menu)
        {

        }
        private static void BasicStatsToggles(GameObject menu)
        {
            MenuHandler.CreateText("This Cannot Toggle The Defualt Basic Stats That TabInfo Adds Only The Ones That CatInfo Adds", menu, out TextMeshProUGUI _, 30);
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
        }
        private static void UsefulStatsToggles(GameObject menu)
        {
            MenuHandler.CreateText("Unblockable Bullets is just unblockable bullets", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(UnblockableBullets, "Unblockable Bullets", menu, value => UnblockableBullets = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Ghost Bullets lets your bullets pass through walls and shit", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(GhostBullet, "Ghost Bullets", menu, value => GhostBullet = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Plasma Gun aka Use Charge like plasma rifle (WWC) or plasma shotgun (WWC)", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Causes the gun to use a charge system for firing. None of the charge stats work without this being set to true.", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(UseCharge, "Chargable Plasma Gun", menu, value => UseCharge = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("No Full Auto In The Building lol u cant hold down the mouse like demonic pact", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(NoFullAutoInTheBuilding, "Not An Automatic Gun", menu, value => NoFullAutoInTheBuilding = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText("%Ammo Regen is the percentage of ammo regenerated each second", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(AmmoRegen, "%Ammo Regen", menu, value => AmmoRegen = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(OnBounceBulletDamage, "On Bounce Bullet Damage", menu, value => OnBounceBulletDamage = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(OnBounceBulletSpeed, "On Bounce Bullet Speed", menu, value => OnBounceBulletSpeed = value, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedHealthStatsToggles(GameObject menu)
        {
            MenuHandler.CreateToggle(Revives, "Revives", menu, value => Revives = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Healing On Block adds to the amount of HP the player heals when they block", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(HealingOnBlock, "Healing On Block", menu, value => HealingOnBlock = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Health Decay increases the amount of time damage is applied to the player over", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(HealthDecay, "Health Decay", menu, value => HealthDecay = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Regenaration, "Regenaration", menu, value => Regenaration = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("The Size stat multiplies the current size of the player", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(Size, "Size", menu, value => Size = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Jumps, "Jumps", menu, value => Jumps = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(JumpHight, "Jump Hight", menu, value => JumpHight = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Gravity, "Gravity", menu, value => Gravity = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("What i use as the total recoil of bodyrecoil * chargerecoil * recoilmultiplier", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(Recoil, "Recoil", menu, value => Recoil = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(BodyRecoil, "Body Recoil", menu, value => BodyRecoil = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateToggle(RecoilMultiplier, "Recoil Multiplier", menu, value => RecoilMultiplier = value, fontSize: 50, forceUpper: false);
        }
        private static void AdvancedGunStatsToggles(GameObject menu)
        {
            MenuHandler.CreateText("%Health Culling is how much of the target's max HP adds as additional damage", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(HealthCulling, "%Health Culling", menu, value => HealthCulling = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletRange, "Bullet Range", menu, value => BulletRange = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletSpeed, "Bullet Speed", menu, value => BulletSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Bullet Size makes ur bullet bigger", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(BulletSize, "Bullet Size", menu, value => BulletSize = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Projectile Size makes ur projectiles bigger", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(ProjectileSize, "Bullet Size", menu, value => ProjectileSize = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Projectile Size And Bullet Size are diffrent but idk in what way", menu, out TextMeshProUGUI _, 40);
            MenuHandler.CreateToggle(ProjectileSpeed, "Projectile Speed", menu, value => ProjectileSpeed = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Damage Growth adjusts the damage of the bullet after it moves 10 units", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(DamageGrowth, "Damage Growth", menu, value => DamageGrowth = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletSpread, "Bullet Spread", menu, value => BulletSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(EvenBulletSpread, "Even Bullet Spread", menu, value => EvenBulletSpread = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateText("Bullet Drag is how much the bullet is affected by simulated air resistance", menu, out TextMeshProUGUI _, 60);
            MenuHandler.CreateToggle(BulletDrag, "Bullet Drag", menu, value => BulletDrag = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletSlow, "Bullet Slow", menu, value => BulletSlow = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(BulletGravity, "Bullet Gravity", menu, value => BulletGravity = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(Knockback, "Knockback", menu, value => Knockback = value, fontSize: 50, forceUpper: false);
            MenuHandler.CreateText(" ", menu, out TextMeshProUGUI _, 30);
            MenuHandler.CreateToggle(TimeBetweenBursts, "Time Between Bursts", menu, value => TimeBetweenBursts = value, fontSize: 50, forceUpper: false);
        }
        private static void ChargedStatsToggles(GameObject menu)
        {
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
    }
}