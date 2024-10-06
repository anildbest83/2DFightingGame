using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Weapon weaponInfo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(weaponInfo.damage);
            }
            GameObject.Find("Player").GetComponent<Score>().enemiesKilled++;
        }

        //Comment here
        Destroy(gameObject);
    }
}
