using TabInfo.Utils;

namespace CatInfo
{
    public class TabinfoInterface
    {
        public static void Setup()
        {
            //#Basic Stats Extended
            var basicCat = TabInfoManager.basicStats;            
            TabInfoManager.RegisterStat(basicCat, "Echo Blocks", (p) => CatInfo.EchoBlocks && p.data.block.additionalBlocks > 0, (p) => string.Format("{0:F0}", p.data.block.additionalBlocks));
            TabInfoManager.RegisterStat(basicCat, "Attack Speed", (p) => CatInfo.AttackSpeed, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.attackSpeed));
            TabInfoManager.RegisterStat(basicCat, "Life Steal", (p) => CatInfo.LifeSteal && p.data.stats.lifeSteal > 0, (p) => string.Format("{0:F2}", p.data.stats.lifeSteal));
            TabInfoManager.RegisterStat(basicCat, "Bullet Bounces", (p) => CatInfo.BulletBounces && p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            TabInfoManager.RegisterStat(basicCat, "Bursts", (p) => CatInfo.Bursts && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            TabInfoManager.RegisterStat(basicCat, "Bullets", (p) => CatInfo.Bullets && p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            var usefulCat = TabInfoManager.RegisterCategory("Useful Stats", 1);
            //#Useful Stats
            TabInfoManager.RegisterStat(usefulCat, "Unblockable Bullets", (p) => CatInfo.UnblockableBullets && p.data.weaponHandler.gun.unblockable == true, (p) => "Ignores Blocks");
            TabInfoManager.RegisterStat(usefulCat, "Ghost Bullets", (p) => CatInfo.GhostBullet && p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Ignores Walls");
            TabInfoManager.RegisterStat(usefulCat, "Plasma Gun", (p) => CatInfo.UseCharge && p.data.weaponHandler.gun.useCharge == true, (p) => "Can Be  Charge");
            TabInfoManager.RegisterStat(usefulCat, "Not An Automatic Gun", (p) => CatInfo.NoFullAutoInTheBuilding && p.data.weaponHandler.gun.dontAllowAutoFire == true, (p) => "Click Fast NOW!");
            TabInfoManager.RegisterStat(usefulCat, "%Ammo Regen", (p) => CatInfo.AmmoRegen && p.data.weaponHandler.gun.ammoReg > 0, (p) => string.Format("{0:0F}", p.data.weaponHandler.gun.ammoReg * 100.0f));
            TabInfoManager.RegisterStat(usefulCat, "On Bounce Bullet Damage", (p) => CatInfo.OnBounceBulletDamage && p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1 , (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            TabInfoManager.RegisterStat(usefulCat, "On Bounce Bullet Speed", (p) => CatInfo.OnBounceBulletSpeed  && p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
            var advCatHealth = TabInfoManager.RegisterCategory("Advanced Health Stats", 2);
            //#Advanced Health Stats
            TabInfoManager.RegisterStat(advCatHealth, "Revives", (p) => CatInfo.Revives && p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            TabInfoManager.RegisterStat(advCatHealth, "Healing On Block", (p) => CatInfo.HealingOnBlock && p.data.block.healing > 0, (p) => string.Format("{0:F0}", p.data.block.healing));
            TabInfoManager.RegisterStat(advCatHealth, "Health Decay", (p) => CatInfo.HealthDecay && p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            TabInfoManager.RegisterStat(advCatHealth, "Regeneration", (p) => CatInfo.Regenaration && p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}s", p.data.healthHandler.regeneration));
            TabInfoManager.RegisterStat(advCatHealth, "Size", (p) => CatInfo.Size && p.data.stats.sizeMultiplier > 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            TabInfoManager.RegisterStat(advCatHealth, "Jumps", (p) => CatInfo.Jumps && p.data.stats.numberOfJumps > 1, (p) => string.Format("{0:F0}", p.data.stats.numberOfJumps));
            TabInfoManager.RegisterStat(advCatHealth, "Jump Hight", (p) => CatInfo.JumpHight && p.data.stats.jump != 1, (p) => string.Format("{0:F2}", p.data.stats.jump));
            TabInfoManager.RegisterStat(advCatHealth, "Gravity", (p) => CatInfo.Gravity && p.data.stats.gravity != 1, (p) => string.Format("{0:F2}", p.data.stats.gravity));
            TabInfoManager.RegisterStat(advCatHealth, "Recoil", (p) => CatInfo.Recoil && p.data.weaponHandler.gun.bodyRecoil != 0 && p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil * p.data.weaponHandler.gun.recoilMuiltiplier)); ;
            TabInfoManager.RegisterStat(advCatHealth, "Recoil Multiplier", (p) => CatInfo.RecoilMultiplier && p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.recoilMuiltiplier));
            TabInfoManager.RegisterStat(advCatHealth, "Body Recoil", (p) => CatInfo.BodyRecoil && p.data.weaponHandler.gun.bodyRecoil != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil));
            var advCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            //#Advanced Gun Stats
            TabInfoManager.RegisterStat(advCatGun, "%Health Damage", (p) => CatInfo.HealthCulling && p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Range", (p) => CatInfo.BulletRange && p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Speed", (p) => CatInfo.BulletSpeed && p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Size", (p) => CatInfo.BulletSize && p.data.weaponHandler.gun.size > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.size));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Size", (p) => CatInfo.ProjectileSize && p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Speed", (p) => CatInfo.ProjectileSpeed && p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Damage Growth", (p) => CatInfo.DamageGrowth && p.data.weaponHandler.gun.damageAfterDistanceMultiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Spread", (p) => CatInfo.BulletSpread && p.data.weaponHandler.gun.spread != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            TabInfoManager.RegisterStat(advCatGun, "Even Bullet Spread", (p) => CatInfo.EvenBulletSpread && p.data.weaponHandler.gun.evenSpread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.evenSpread));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Drag", (p) => CatInfo.BulletDrag && p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Slow", (p) => CatInfo.BulletSlow && p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Gravity", (p) => CatInfo.BulletGravity && p.data.weaponHandler.gun.gravity != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.gravity));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Knockback", (p) => CatInfo.Knockback && p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            TabInfoManager.RegisterStat(advCatGun, "Time Between Bursts", (p) => CatInfo.TimeBetweenBursts && p.data.weaponHandler.gun.timeBetweenBullets != 1 && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.timeBetweenBullets));
            var chargedCat = TabInfoManager.RegisterCategory("Plasma Charged Stats", 4);
            //#ChargedStats
            TabInfoManager.RegisterStat(chargedCat, "Plasma Charged Damage Multiplier", (p) => CatInfo.ChargedDamageMultiplier && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeDamageMultiplier != 0, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeDamageMultiplier));
            TabInfoManager.RegisterStat(chargedCat, "Plasma Charged Bullet Speed", (p) => CatInfo.ChargedSpeed && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpeedTo != 0, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpeedTo));
            TabInfoManager.RegisterStat(chargedCat, "Plasma Charged Bullet Spread", (p) => CatInfo.ChargedSpread && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpreadTo != 0, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Plasma Charged Bullet Even Spread", (p) => CatInfo.ChargedEvenSpread && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeEvenSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeEvenSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Plasma Charged Gun Recoil", (p) => CatInfo.ChargedRecoil && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeRecoilTo != 0, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeRecoilTo));
            TabInfoManager.RegisterStat(chargedCat, "Plasma Charged Number Of Bullets", (p) => CatInfo.ChargedNumberOfProjectiles && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeNumberOfProjectilesTo != 0, (p) => string.Format("{0:F0}",p.data.weaponHandler.gun.chargeNumberOfProjectilesTo));
        }
    }
}