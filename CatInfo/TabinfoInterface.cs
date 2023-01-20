using TabInfo.Utils;

namespace CatInfo
{
    public class TabinfoInterface
    {
        public static void Setup()
        {
            var cat = TabInfoManager.RegisterCategory("Basic Stats Extended", 1);
            if (CatsTab.EchoBlocks)
            {
                TabInfoManager.RegisterStat(cat, "Echo Blocks", (p) => p.data.block.additionalBlocks > 0, (p) => string.Format("{0:F0}", p.data.block.additionalBlocks));
            }
            if (CatsTab.AttackSpeed)
            {
                TabInfoManager.RegisterStat(cat, "Attack Speed", (p) => true, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.attackSpeed));
            }
            if (CatsTab.LifeSteal)
            {
                TabInfoManager.RegisterStat(cat, "Life Steal", (p) => p.data.stats.lifeSteal > 0, (p) => string.Format("{0:F2}", p.data.stats.lifeSteal));
            }
            if (CatsTab.BulletBounces)
            {
                TabInfoManager.RegisterStat(cat, "Bullet Bounces", (p) => p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            }
            if (CatsTab.Bursts)
            {
                TabInfoManager.RegisterStat(cat, "Bursts", (p) => p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            }

            if (CatsTab.Bullets)
            {
                TabInfoManager.RegisterStat(cat, "Bullets", (p) => p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            }
            var UsefullCat = TabInfoManager.RegisterCategory("Useful Stats", 1);
            if (CatsTab.Unblockable)
            {
                TabInfoManager.RegisterStat(UsefullCat, "Unblockable", (p) => p.data.weaponHandler.gun.unblockable == true, (p) => "Bullets");
            }
            if (CatsTab.Ghost)
            {
                TabInfoManager.RegisterStat(UsefullCat, "Ghost", (p) => p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Bullets");
            }
            var AdvCatHealth = TabInfoManager.RegisterCategory("Advanced Health Stats", 2);

            if (CatsTab.Revives)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Revives", (p) => p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            }
            if (CatsTab.HealingOnBlock)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Healing On Block", (p) => p.data.block.healing > 0, (p) => string.Format("{0:F0}", p.data.block.healing));

            }
            if (CatsTab.HealthDecay)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Health Decay", (p) => p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            }
            if (CatsTab.Regenaration)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Regeneration", (p) => p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}s", p.data.healthHandler.regeneration));
            }
            if (CatsTab.Size)
            {
                TabInfoManager.RegisterStat(AdvCatHealth, "Size", (p) => p.data.stats.sizeMultiplier != 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            }
            var AdvCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            if (CatsTab.HealthCulling)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Health Culling ", (p) => p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            }
            if (CatsTab.BulletSize)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Size", (p) => p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            }
            if (CatsTab.BulletRange)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Range", (p) => p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            }
            if (CatsTab.BulletSpeed)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Speed", (p) => p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            }
            if (CatsTab.ProjectileSpeed)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Projectile Speed", (p) => p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            }
            if (CatsTab.DamageGrowth)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Damage Growth", (p) => p.data.weaponHandler.gun.damageAfterDistanceMultiplier > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            }
            if (CatsTab.BulletSpread)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Spread", (p) => p.data.weaponHandler.gun.spread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            }
            if (CatsTab.BulletDrag)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Drag", (p) => p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            }
            if (CatsTab.BulletSlow)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Bullet Slow", (p) => p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            }
            if (CatsTab.Knockback)
            {
                TabInfoManager.RegisterStat(AdvCatGun, "Knockback", (p) => p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            }
            var BounceCat = TabInfoManager.RegisterCategory("On Bounce Multipliers", 4);
            if (CatsTab.OnBounceBulletDamage)
            {
                TabInfoManager.RegisterStat(BounceCat, "On Bounce Bullet Damage", (p) => p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            }
            if (CatsTab.OnBounceBulletSpeed)
            {
                TabInfoManager.RegisterStat(BounceCat, "On Bounce Bullet Speed", (p) => p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
            }
        }

    }
}