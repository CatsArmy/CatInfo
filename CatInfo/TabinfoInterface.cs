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
            TabInfoManager.RegisterStat(basicCat, "Bounces", (p) => CatInfo.Bounces && p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            TabInfoManager.RegisterStat(basicCat, "Bursts", (p) => CatInfo.Bursts && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            TabInfoManager.RegisterStat(basicCat, "Bullets", (p) => CatInfo.Bullets && p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            TabInfoManager.RegisterStat(basicCat, "Bounce Damage", (p) => CatInfo.BounceDamage && p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1 , (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            TabInfoManager.RegisterStat(basicCat, "Bounce Speed", (p) => CatInfo.BounceSpeed  && p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
            var usefulCat = TabInfoManager.RegisterCategory("Useful Stats", 4);
            //#Useful Stats
            TabInfoManager.RegisterStat(usefulCat, "Unblockable", (p) => CatInfo.Unblockable && p.data.weaponHandler.gun.unblockable == true, (p) => "Ignores Blocks");
            TabInfoManager.RegisterStat(usefulCat, "Ghost Bullets", (p) => CatInfo.GhostBullets && p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Ignores Walls");
            TabInfoManager.RegisterStat(usefulCat, "Chargable Gun", (p) => CatInfo.Chargable && p.data.weaponHandler.gun.useCharge == true, (p) => "Chargable");
            TabInfoManager.RegisterStat(usefulCat, "Demonic Gun", (p) => CatInfo.DemonicGun && p.data.weaponHandler.gun.dontAllowAutoFire == true, (p) => "Cant Hold Down Mouse");
            var advCatHealth = TabInfoManager.RegisterCategory("Advanced Character Stats", 2);
            //#Advanced Health Stats
            TabInfoManager.RegisterStat(advCatHealth, "Phoenix Lives", (p) => CatInfo.Phoenix && p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            TabInfoManager.RegisterStat(advCatHealth, "Healing On Block", (p) => CatInfo.HealingOnBlock && p.data.block.healing > 0, (p) => string.Format("{0:F0}", p.data.block.healing));
            TabInfoManager.RegisterStat(advCatHealth, "Decay", (p) => CatInfo.Decay && p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            TabInfoManager.RegisterStat(advCatHealth, "Regeneration", (p) => CatInfo.Regenaration && p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}s", p.data.healthHandler.regeneration));
            TabInfoManager.RegisterStat(advCatHealth, "Size", (p) => CatInfo.Size && p.data.stats.sizeMultiplier > 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            TabInfoManager.RegisterStat(advCatHealth, "Jumps", (p) => CatInfo.Jumps && p.data.stats.numberOfJumps > 1, (p) => string.Format("{0:F0}", p.data.stats.numberOfJumps));
            TabInfoManager.RegisterStat(advCatHealth, "Jump Hight", (p) => CatInfo.JumpHight && p.data.stats.jump != 1, (p) => string.Format("{0:F2}", p.data.stats.jump));
            TabInfoManager.RegisterStat(advCatHealth, "Gravity", (p) => CatInfo.Gravity && p.data.stats.gravity != 1, (p) => string.Format("{0:F2}", p.data.stats.gravity));
            var advCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            //#Advanced Gun Stats
            TabInfoManager.RegisterStat(advCatGun, "%Health Damage", (p) => CatInfo.HealthCulling && p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Range", (p) => CatInfo.BulletRange && p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Speed", (p) => CatInfo.BulletSpeed && p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Size", (p) => CatInfo.BulletSize && p.data.weaponHandler.gun.size > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.size));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Size", (p) => CatInfo.ProjectileSize && p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Time Scale", (p) => CatInfo.ProjectileTimeScale && p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Damage Growth", (p) => CatInfo.DamageGrowth && p.data.weaponHandler.gun.damageAfterDistanceMultiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            TabInfoManager.RegisterStat(advCatGun, "Gun Spread", (p) => CatInfo.GunSpread && p.data.weaponHandler.gun.spread != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            TabInfoManager.RegisterStat(advCatGun, "Even Gun Spread", (p) => CatInfo.EvenGunSpread && p.data.weaponHandler.gun.evenSpread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.evenSpread));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Drag", (p) => CatInfo.BulletDrag && p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            TabInfoManager.RegisterStat(advCatGun, "Cold Bullets", (p) => CatInfo.ColdBullets && p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Gravity", (p) => CatInfo.BulletGravity && p.data.weaponHandler.gun.gravity != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.gravity));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Knockback", (p) => CatInfo.Knockback && p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            TabInfoManager.RegisterStat(advCatGun, "Time Between Bursts", (p) => CatInfo.TimeBetweenBursts && p.data.weaponHandler.gun.timeBetweenBullets != 1 && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.timeBetweenBullets));
            TabInfoManager.RegisterStat(advCatGun, "%Ammo Regeneration", (p) => CatInfo.AmmoRegeneration && p.data.weaponHandler.gun.ammoReg > 0, (p) => string.Format("{0:0F}", p.data.weaponHandler.gun.ammoReg * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Recoil", (p) => CatInfo.Recoil && p.data.weaponHandler.gun.bodyRecoil != 0 && p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil * p.data.weaponHandler.gun.recoilMuiltiplier)); ;
            TabInfoManager.RegisterStat(advCatGun, "Recoil Multiplier", (p) => CatInfo.RecoilMultiplier && p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.recoilMuiltiplier));
            TabInfoManager.RegisterStat(advCatGun, "Body Recoil", (p) => CatInfo.BodyRecoil && p.data.weaponHandler.gun.bodyRecoil != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil));
            var chargedCat = TabInfoManager.RegisterCategory("Charged Stats", 5);
            //#ChargedStats
            TabInfoManager.RegisterStat(chargedCat, "Charged Damage Multiplier", (p) => CatInfo.ChargedDamageMultiplier && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeDamageMultiplier != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeDamageMultiplier));
            TabInfoManager.RegisterStat(chargedCat, "Charged Bullet Speed", (p) => CatInfo.ChargedSpeed && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpeedTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpeedTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Gun Spread", (p) => CatInfo.ChargedGunSpread && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Even Gun Spread", (p) => CatInfo.ChargedEvenGunSpread && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeEvenSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeEvenSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Recoil", (p) => CatInfo.ChargedRecoil && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeRecoilTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeRecoilTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Number Of Bullets", (p) => CatInfo.ChargedNumberOfProjectiles && p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeNumberOfProjectilesTo != 0, (p) => string.Format("{0:F0}",p.data.weaponHandler.gun.chargeNumberOfProjectilesTo));
        }
    }
}