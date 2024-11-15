using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunUnlockSystem : MonoBehaviour
{
    [SerializeField] private Score scoreSystem;
    [SerializeField] private Shooting shootingScript;

    private void Update()
    {
        if (shootingScript.currentWeapon.nextWeapon == null)
            return;

        if (scoreSystem.enemiesKilled == shootingScript.currentWeapon.nextWeapon.pointsNeededtoUnlock)
        {
            Unlock();
        }
    }
    private void Unlock()
    {
        shootingScript.currentWeapon = shootingScript.currentWeapon.nextWeapon;
    }
}
