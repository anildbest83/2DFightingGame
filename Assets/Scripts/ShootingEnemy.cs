using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject Player;
    public Transform firePoint;
    public GameObject bullet;
    public float bulletSpeed = 6f;
    public float speed = 5f;
    public float shootingDistance = 5f;
    public float timeBetweenShots = 1f;

    private float distance;
    bool canFire = true;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (distance <= shootingDistance && canFire)
        {
            Shoot();
        }

        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;

        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }

    private void Shoot()
    {
        GameObject bulletOBJ = Instantiate(bullet, firePoint.position, firePoint.rotation);
        bulletOBJ.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        canFire = false;
        Invoke(nameof(ResetFire), timeBetweenShots);
    }

    private void ResetFire()
    {
        canFire = true;
    }
}
