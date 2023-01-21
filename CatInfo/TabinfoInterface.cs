using TabInfo.Utils;

namespace CatInfo
{
    public class TabinfoInterface
    {
        public static void Setup()
        {
            var cat = TabInfoManager.RegisterCategory("Basic Stats Extended", 1);
            //#Basic Stats Extended
            TabInfoManager.RegisterStat(cat, "Echo Blocks", (p) => CatInfo.EchoBlocks && p.data.block.additionalBlocks > 0, (p) => string.Format("{0:F0}", p.data.block.additionalBlocks));
            TabInfoManager.RegisterStat(cat, "Attack Speed", (p) => CatInfo.AttackSpeed, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.attackSpeed));
            TabInfoManager.RegisterStat(cat, "Life Steal", (p) => CatInfo.LifeSteal && p.data.stats.lifeSteal > 0, (p) => string.Format("{0:F2}", p.data.stats.lifeSteal));
            TabInfoManager.RegisterStat(cat, "Bullet Bounces", (p) => CatInfo.BulletBounces && p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            TabInfoManager.RegisterStat(cat, "Bursts", (p) => CatInfo.Bursts && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            TabInfoManager.RegisterStat(cat, "Bullets", (p) => CatInfo.Bullets && p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            var UsefullCat = TabInfoManager.RegisterCategory("Useful Stats", 1);
            //#Useful Stats
            TabInfoManager.RegisterStat(UsefullCat, "Unblockable", (p) => CatInfo.Unblockable && p.data.weaponHandler.gun.unblockable == true, (p) => "Bullets");
            TabInfoManager.RegisterStat(UsefullCat, "Ghost", (p) => CatInfo.Ghost && p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Bullets");
            var AdvCatHealth = TabInfoManager.RegisterCategory("Advanced Health Stats", 2);
            //#Advanced Health Stats
            TabInfoManager.RegisterStat(AdvCatHealth, "Revives", (p) => CatInfo.Revives && p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            TabInfoManager.RegisterStat(AdvCatHealth, "Healing On Block", (p) => CatInfo.HealingOnBlock && p.data.block.healing > 0, (p) => string.Format("{0:F0}", p.data.block.healing));
            TabInfoManager.RegisterStat(AdvCatHealth, "Health Decay", (p) => CatInfo.HealthDecay && p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            TabInfoManager.RegisterStat(AdvCatHealth, "Regeneration", (p) => CatInfo.Regenaration && p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}s", p.data.healthHandler.regeneration));
            TabInfoManager.RegisterStat(AdvCatHealth, "Size", (p) => CatInfo.Size && p.data.stats.sizeMultiplier != 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            var AdvCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            //#Advanced Gun Stats
            TabInfoManager.RegisterStat(AdvCatGun, "Health Culling ", (p) => CatInfo.HealthCulling && p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            TabInfoManager.RegisterStat(AdvCatGun, "Bullet Size", (p) => CatInfo.BulletSize && p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            TabInfoManager.RegisterStat(AdvCatGun, "Bullet Range", (p) => CatInfo.BulletRange && p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            TabInfoManager.RegisterStat(AdvCatGun, "Bullet Speed", (p) => CatInfo.BulletSpeed && p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            TabInfoManager.RegisterStat(AdvCatGun, "Projectile Speed", (p) => CatInfo.ProjectileSpeed && p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            TabInfoManager.RegisterStat(AdvCatGun, "Damage Growth", (p) => CatInfo.DamageGrowth && p.data.weaponHandler.gun.damageAfterDistanceMultiplier > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            TabInfoManager.RegisterStat(AdvCatGun, "Bullet Spread", (p) => CatInfo.BulletSpread && p.data.weaponHandler.gun.spread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            TabInfoManager.RegisterStat(AdvCatGun, "Bullet Drag", (p) => CatInfo.BulletDrag && p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            TabInfoManager.RegisterStat(AdvCatGun, "Bullet Slow", (p) => CatInfo.BulletSlow && p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            TabInfoManager.RegisterStat(AdvCatGun, "Knockback", (p) => CatInfo.Knockback && p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            var BounceCat = TabInfoManager.RegisterCategory("On Bounce Effects", 4);
            //#On Bounce Effects
            TabInfoManager.RegisterStat(BounceCat, "On Bounce Bullet Damage", (p) => CatInfo.OnBounceBulletDamage && p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1 , (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            TabInfoManager.RegisterStat(BounceCat, "On Bounce Bullet Speed", (p) => CatInfo.OnBounceBulletSpeed  && p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
        }

    }
}