using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunUnlockSystem : MonoBehaviour
{
    [SerializeField] private Score scoreSystem;
    [SerializeField] private Shooting shootingScript;
    [SerializeField] private Weapon nextGun;
    [SerializeField] private int nextUnlockPointsNeeded = 10;

    private void Update()
    {
        if (scoreSystem.enemiesKilled > nextUnlockPointsNeeded)
        {
            UnlockGun();
        }
    }

    private void UnlockGun()
    {
        shootingScript.currentWeapon = nextGun;
    }
}
