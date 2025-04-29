using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeGun : Gun
{
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);

        // Make the bullet very slow but high knockback (like freezing effect)
        b.GetComponent<Projectile>().Initialize(2, 30, 5, 20, null);

        anim.SetTrigger("shoot");
        elapsed = 0;
        ammo -= 1;

        return true;
    }

    public override void Equip(FPSController p)
    {
        base.Equip(p);
    }
}
