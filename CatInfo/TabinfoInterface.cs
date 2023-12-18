using TabInfo.Utils;

namespace CatInfo
{
    public class TabinfoInterface
    {
        public static void Setup()
        {
            bool ASS = CatInfo.AllwaysShowStats;
            //its not ass its  ^ A.S.S ^  ^ 

            //#Basic Stats Extended
            var basicCat = TabInfoManager.basicStats;
            TabInfoManager.RegisterStat(basicCat, "Echo Blocks", (p) => ASS || p.data.block.additionalBlocks > 0, (p) => string.Format("{0:F0}", p.data.block.additionalBlocks));
            TabInfoManager.RegisterStat(basicCat, "Attack Speed", (p) => true, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.attackSpeed));
            TabInfoManager.RegisterStat(basicCat, "Life Steal", (p) => ASS || p.data.stats.lifeSteal > 0, (p) => string.Format("{0:F2}", p.data.stats.lifeSteal));
            TabInfoManager.RegisterStat(basicCat, "Bounces", (p) => ASS || p.data.weaponHandler.gun.reflects != 0, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.reflects));
            TabInfoManager.RegisterStat(basicCat, "Bursts", (p) => ASS || p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.bursts - 2));
            TabInfoManager.RegisterStat(basicCat, "Bullets", (p) => ASS || p.data.weaponHandler.gun.numberOfProjectiles > 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.numberOfProjectiles));
            TabInfoManager.RegisterStat(basicCat, "Bounce Damage", (p) => ASS || p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.dmgMOnBounce != 1 , (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.dmgMOnBounce - 1f) * 100f));
            TabInfoManager.RegisterStat(basicCat, "Bounce Speed", (p) => ASS || p.data.weaponHandler.gun.reflects > 0 && p.data.weaponHandler.gun.speedMOnBounce != 1, (p) => string.Format("{0:F0}%", (p.data.weaponHandler.gun.speedMOnBounce - 1f) * 100f));
            var usefulCat = TabInfoManager.RegisterCategory("Useful Stats", 4);
            //#Useful Stats
            TabInfoManager.RegisterStat(usefulCat, "Unblockable", (p) => ASS || p.data.weaponHandler.gun.unblockable == true, (p) => "Ignores Blocks");
            TabInfoManager.RegisterStat(usefulCat, "Ghost Bullets", (p) => ASS || p.data.weaponHandler.gun.ignoreWalls == true, (p) => "Ignores Walls");
            TabInfoManager.RegisterStat(usefulCat, "Chargable Gun", (p) => ASS || p.data.weaponHandler.gun.useCharge == true, (p) => "Plasma Charge");
            TabInfoManager.RegisterStat(usefulCat, "Demonic Gun", (p) => ASS || p.data.weaponHandler.gun.dontAllowAutoFire == true, (p) => "Cant Spray");
            var advCatHealth = TabInfoManager.RegisterCategory("Advanced Character Stats", 2);
            //#Advanced Health Stats
            TabInfoManager.RegisterStat(advCatHealth, "Phoenix Revives", (p) => ASS || p.data.stats.respawns > 0, (p) => string.Format("{0:F0}", p.data.stats.respawns));
            TabInfoManager.RegisterStat(advCatHealth, "Healing On Block", (p) => p.data.block.healing > 0, (p) => string.Format("{0:F0}HP", p.data.block.healing));
            TabInfoManager.RegisterStat(advCatHealth, "Decay", (p) => ASS || p.data.stats.secondsToTakeDamageOver > 0, (p) => string.Format("{0:F2}", p.data.stats.secondsToTakeDamageOver));
            TabInfoManager.RegisterStat(advCatHealth, "Regeneration", (p) => ASS || p.data.healthHandler.regeneration > 0, (p) => string.Format("{0:F2}HP/s", p.data.healthHandler.regeneration));
            TabInfoManager.RegisterStat(advCatHealth, "Size", (p) => ASS || p.data.stats.sizeMultiplier > 1, (p) => string.Format("{0:F2}", p.data.stats.sizeMultiplier));
            TabInfoManager.RegisterStat(advCatHealth, "Jumps", (p) => ASS || p.data.stats.numberOfJumps > 1, (p) => string.Format("{0:F0}", p.data.stats.numberOfJumps));
            TabInfoManager.RegisterStat(advCatHealth, "Jump Height", (p) => ASS || p.data.stats.jump != 1, (p) => string.Format("{0:F2}", p.data.stats.jump));
            TabInfoManager.RegisterStat(advCatHealth, "Gravity", (p) => ASS || p.data.stats.gravity != 1, (p) => string.Format("{0:F2}", p.data.stats.gravity));
            var advCatGun = TabInfoManager.RegisterCategory("Advanced Gun Stats", 3);
            //#Advanced Gun Stats
            TabInfoManager.RegisterStat(advCatGun, "%Health Culling", (p) => ASS || p.data.weaponHandler.gun.percentageDamage > 0, (p) => string.Format("{0:F1}%", p.data.weaponHandler.gun.percentageDamage * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Range", (p) => ASS || p.data.weaponHandler.gun.destroyBulletAfter > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.destroyBulletAfter));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Speed", (p) => ASS || p.data.weaponHandler.gun.projectileSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Size", (p) => ASS || p.data.weaponHandler.gun.size > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.size));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Size", (p) => ASS || p.data.weaponHandler.gun.projectileSize > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectileSize));
            TabInfoManager.RegisterStat(advCatGun, "Projectile Time Scale", (p) => ASS || p.data.weaponHandler.gun.projectielSimulatonSpeed != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.projectielSimulatonSpeed));
            TabInfoManager.RegisterStat(advCatGun, "Damage Growth", (p) => ASS || p.data.weaponHandler.gun.damageAfterDistanceMultiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.damageAfterDistanceMultiplier));
            TabInfoManager.RegisterStat(advCatGun, "Gun Spread", (p) => ASS || p.data.weaponHandler.gun.spread != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.spread));
            TabInfoManager.RegisterStat(advCatGun, "Even Gun Spread", (p) => ASS || p.data.weaponHandler.gun.evenSpread > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.evenSpread));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Drag", (p) => ASS || p.data.weaponHandler.gun.drag > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.drag));
            TabInfoManager.RegisterStat(advCatGun, "Cold Bullets", (p) => ASS || p.data.weaponHandler.gun.slow > 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.slow));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Gravity", (p) => ASS || p.data.weaponHandler.gun.gravity != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.gravity));
            TabInfoManager.RegisterStat(advCatGun, "Bullet Knockback", (p) => ASS || p.data.weaponHandler.gun.knockback != 1, (p) => string.Format("{0:F0}", p.data.weaponHandler.gun.knockback));
            TabInfoManager.RegisterStat(advCatGun, "Time Between Bursts", (p) => p.data.weaponHandler.gun.timeBetweenBullets != 1 && p.data.weaponHandler.gun.bursts > 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.timeBetweenBullets));
            TabInfoManager.RegisterStat(advCatGun, "%Ammo Regeneration", (p) => ASS || p.data.weaponHandler.gun.ammoReg > 0, (p) => string.Format("{0:0F}%", p.data.weaponHandler.gun.ammoReg * 100.0f));
            TabInfoManager.RegisterStat(advCatGun, "Recoil", (p) => p.data.weaponHandler.gun.bodyRecoil != 0 && p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil * p.data.weaponHandler.gun.recoilMuiltiplier)); ;
            TabInfoManager.RegisterStat(advCatGun, "Recoil Multiplier", (p) => ASS || p.data.weaponHandler.gun.recoilMuiltiplier != 1, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.recoilMuiltiplier));
            TabInfoManager.RegisterStat(advCatGun, "Body Recoil", (p) => ASS || p.data.weaponHandler.gun.bodyRecoil != 0, (p) => string.Format("{0:F2}", p.data.weaponHandler.gun.bodyRecoil));
            var chargedCat = TabInfoManager.RegisterCategory("Charged Stats", 5);
            //#ChargedStats
            TabInfoManager.RegisterStat(chargedCat, "Charged Damage Multiplier", (p) => ASS || p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeDamageMultiplier != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeDamageMultiplier));
            TabInfoManager.RegisterStat(chargedCat, "Charged Bullet Speed", (p) => ASS || p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpeedTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpeedTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Gun Spread", (p) => ASS || p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Even Gun Spread", (p) => ASS || p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeEvenSpreadTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeEvenSpreadTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Recoil", (p) => ASS || p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeRecoilTo != 1, (p) => string.Format("{0:F2}",p.data.weaponHandler.gun.chargeRecoilTo));
            TabInfoManager.RegisterStat(chargedCat, "Charged Number Of Bullets", (p) => ASS || p.data.weaponHandler.gun.useCharge && p.data.weaponHandler.gun.chargeNumberOfProjectilesTo != 0, (p) => string.Format("{0:F0}",p.data.weaponHandler.gun.chargeNumberOfProjectilesTo));
        }
    }
}
