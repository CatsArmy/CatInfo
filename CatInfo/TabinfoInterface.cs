using TabInfo.Utils;

namespace CatInfo
{
    public class TabinfoInterface
    {
        public static void Setup()
        {
            //#Basic Stats Extended
            var basicCat = TabInfoManager.basicStats;            
            TabInfoManager.RegisterStat(basicCat, "Echo Blocks", (p) => p.data.block.additionalBlocks > 0, (p) => string.Format("{0:F0}", p.data.block.additionalBlocks));
            TabInfoManager.RegisterStat(basicCat, "Attack Speed", (p) => true, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.attackSpeed));
            TabInfoManager.RegisterStat(basicCat, "Life Steal", (p) => p.data.stats.lifeSteal > 0, (p) => string.Format("{0:F2}", p.data.stats.lifeSteal));
            TabInfoManager.RegisterStat(basicCat, "Bounces", (p) => p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            TabInfoManager.RegisterStat(basicCat, "Bursts", (p) => p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            TabInfoManager.RegisterStat(basicCat, "Bullets", (p) => p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            TabInfoManager.RegisterStat(basicCat, "Bounce Damage", (p) => p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1 , (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            TabInfoManager.RegisterStat(basicCat, "Bounce Speed", (p) => p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
            var usefulCat = TabInfoManager.RegisterCategory("Useful Stats", 4);
            //#Useful Stats
            TabInfoManager.RegisterStat(usefulCat, "Unblockable", (p) => p.data.weaponHandler.gun.unblockable == true, (p) => "Ignores Blocks");
            TabInfoManager.RegisterStat(usefulCat, "Ghost Bullets", (p) => p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Ignores Walls");
            TabInfoManager.RegisterStat(usefulCat, "Chargable Gun", (p) => p.data.weaponHandler.gun.useCharge == true, (p) => "Chargable");
            TabInfoManager.RegisterStat(usefulCat, "Demonic Gun", (p) => p.data.weaponHandler.gun.dontAllowAutoFire == true, (p) => "Cant Hold Down Mouse");
            var advCatHealth = TabInfoManager.RegisterCategory("Advanced Character Stats", 2);
            //#Advanced Health Stats
            TabInfoManager.RegisterStat(advCatHealth, "Phoenix Lives", (p) => p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            TabInfoManager.RegisterStat(advCatHealth, "Healing On Block", (p) => p.data.block.healing > 0, (p) => string.Format("{0:F0}", p.data.block.healing));
            TabInfoManager.RegisterStat(advCatHealth, "Decay", (p) => p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            TabInfoManager.RegisterStat(advCatHealth, "Regeneration", (p) => p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}s", p.data.healthHandler.regeneration));
            TabInfoManager.RegisterStat(advCatHealth, "Size", (p) => p.data.stats.sizeMultiplier > 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            TabInfoManager.RegisterStat(advCatHealth, "Jumps", (p) => p.data.stats.numberOfJumps > 1, (p) => string.Format("{0:F0}", p.data.stats.numberOfJumps));
            TabInfoManager.RegisterStat(advCatHealth, "Jump Height", (p) => p.data.stats.jump != 1, (p) => string.Format("{0:F2}", p.data.stats.jump));
            TabInfoManager.RegisterStat(advCatHealth, "Gravity", (p) => p.data.stats.gravity != 1, (p) => string.Format("{0:F2}", p.data.stats.gravity));
            var advCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            //#Advanced Gun Stats
            TabInfoManager.RegisterStat(advCatGun, "%Health Damage", (p) => p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Range", (p) => p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Speed", (p) => p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Size", (p) => p.data.weaponHandler.gun.size > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.size));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Size", (p) => p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Time Scale", (p) => p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Damage Growth", (p) => p.data.weaponHandler.gun.damageAfterDistanceMultiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            TabInfoManager.RegisterStat(advCatGun, "Gun Spread", (p) => p.data.weaponHandler.gun.spread != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            TabInfoManager.RegisterStat(advCatGun, "Even Gun Spread", (p) => p.data.weaponHandler.gun.evenSpread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.evenSpread));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Drag", (p) => p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            TabInfoManager.RegisterStat(advCatGun, "Cold Bullets", (p) => p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Gravity", (p) => p.data.weaponHandler.gun.gravity != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.gravity));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Knockback", (p) => p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            TabInfoManager.RegisterStat(advCatGun, "Time Between Bursts", (p) => p.data.weaponHandler.gun.timeBetweenBullets != 1 && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.timeBetweenBullets));
            TabInfoManager.RegisterStat(advCatGun, "%Ammo Regeneration", (p) => p.data.weaponHandler.gun.ammoReg > 0, (p) => string.Format("{0:0F}", p.data.weaponHandler.gun.ammoReg * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Recoil", (p) => p.data.weaponHandler.gun.bodyRecoil != 0 && p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil * p.data.weaponHandler.gun.recoilMuiltiplier)); ;
            TabInfoManager.RegisterStat(advCatGun, "Recoil Multiplier", (p) => p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.recoilMuiltiplier));
            TabInfoManager.RegisterStat(advCatGun, "Body Recoil", (p) => p.data.weaponHandler.gun.bodyRecoil != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil));
            var chargedCat = TabInfoManager.RegisterCategory("Charged Stats", 5);
            //#ChargedStats
            TabInfoManager.RegisterStat(chargedCat, "Charged Damage Multiplier", (p) => p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeDamageMultiplier != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeDamageMultiplier));
            TabInfoManager.RegisterStat(chargedCat, "Charged Bullet Speed", (p) => p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpeedTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpeedTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Gun Spread", (p) => p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Even Gun Spread", (p) => p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeEvenSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeEvenSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Recoil", (p) => p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeRecoilTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeRecoilTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Number Of Bullets", (p) => p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeNumberOfProjectilesTo != 0, (p) => string.Format("{0:F0}",p.data.weaponHandler.gun.chargeNumberOfProjectilesTo));
        }
    }
}