using TabInfo.Utils;

namespace CatInfo
{
    public class TabinfoInterface
    {
        public static void Setup()
        {
            var cat = TabInfoManager.RegisterCategory("Basic Stats Extended", 1);
            if (CatInfo.EchoBlocks)
            {
                TabInfoManager.RegisterStat(cat, "Echo Blocks", (p) => p.data.block.additionalBlocks > 0, (p) => string.Format("{0:F0}", p.data.block.additionalBlocks));
            }
            if (CatInfo.AttackSpeed)
            {
                TabInfoManager.RegisterStat(cat, "Attack Speed", (p) => true, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.attackSpeed));
            }
            if (CatInfo.LifeSteal)
            {
                TabInfoManager.RegisterStat(cat, "Life Steal", (p) => p.data.stats.lifeSteal > 0, (p) => string.Format("{0:F2}", p.data.stats.lifeSteal));
            }
            if (CatInfo.BulletBounces)
            {
                TabInfoManager.RegisterStat(cat, "Bullet Bounces", (p) => p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            }
            if (CatInfo.Bursts)
            {
                TabInfoManager.RegisterStat(cat, "Bursts", (p) => p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            }

            if (CatInfo.Bullets)
            {
                TabInfoManager.RegisterStat(cat, "Bullets", (p) => p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            }
            var UsefullCat = TabInfoManager.RegisterCategory("Useful Stats", 1);
            if (CatInfo.Unblockable)
            {
                TabInfoManager.RegisterStat(UsefullCat, "Unblockable", (p) => p.data.weaponHandler.gun.unblockable == true, (p) => "Bullets");
            }
            if (CatInfo.Ghost)
            {
                TabInfoManager.RegisterStat(UsefullCat, "Ghost", (p) => p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Bullets");
            }
            var AdvCatHealth = TabInfoManager.RegisterCategory("Advanced Health Stats", 2);

            if (CatInfo.Revives)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Revives", (p) => p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            }
            if (CatInfo.HealingOnBlock)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Healing On Block", (p) => p.data.block.healing > 0, (p) => string.Format("{0:F0}", p.data.block.healing));

            }
            if (CatInfo.HealthDecay)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Health Decay", (p) => p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            }
            if (CatInfo.Regenaration)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Regeneration", (p) => p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}s", p.data.healthHandler.regeneration));
            }
            if (CatInfo.Size)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Size", (p) => p.data.stats.sizeMultiplier != 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            }
            var AdvCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            if (CatInfo.HealthCulling)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Health Culling ", (p) => p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            }
            if (CatInfo.BulletSize)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Size", (p) => p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            }
            if (CatInfo.BulletRange)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Range", (p) => p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            }
            if (CatInfo.BulletSpeed)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Speed", (p) => p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            }
            if (CatInfo.ProjectileSpeed)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Projectile Speed", (p) => p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            }
            if (CatInfo.DamageGrowth)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Damage Growth", (p) => p.data.weaponHandler.gun.damageAfterDistanceMultiplier > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            }
            if (CatInfo.BulletSpread)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Spread", (p) => p.data.weaponHandler.gun.spread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            }
            if (CatInfo.BulletDrag)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Drag", (p) => p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            }
            if (CatInfo.BulletSlow)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Slow", (p) => p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            }
            if (CatInfo.Knockback)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Knockback", (p) => p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            }
            var BounceCat = TabInfoManager.RegisterCategory("On Bounce Multipliers", 4);
            if (CatInfo.OnBounceBulletDamage)
            {
                TabInfoManager.RegisterStat(BounceCat, "On Bounce Bullet Damage", (p) => p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            }
            if (CatInfo.OnBounceBulletSpeed)
            {
                TabInfoManager.RegisterStat(BounceCat, "On Bounce Bullet Speed", (p) => p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
            }
        }

    }
}