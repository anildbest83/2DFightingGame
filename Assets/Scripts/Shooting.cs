using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private Weapon currentWeapon;
    public GameObject bulletPrefab;

    private float nextTimeToFire;

    // Update is called once per frame
    void Update()
    {

        if (PauseMenu.gameIsPaused) return;
        if (Input.GetButton("Fire1") && nextTimeToFire <= Time.time)
        {
            nextTimeToFire = Time.time + 1/currentWeapon.fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * currentWeapon.BulletSpeed, ForceMode2D.Impulse);
    }
}
