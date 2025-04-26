using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticWeapon : Gun
{
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);
        b.GetComponent<Projectile>().Initialize(1, 100, 2, 2, null); // version without special effect


        


        anim.SetTrigger("shoot");
        elapsed = 0;
        ammo -= 1;

        return true;
    }

    public override void Equip(FPSController p)
    {
        base.Equip(p);
        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);

    }
}


