using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 20f;
    public bool isDead = false;

    public GameObject drop;
    private bool DoDrop;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        Drop();
        Destroy(gameObject);
    }

    private void Drop()
    {
        DoDrop = Random.Range(0, 2) < 0.5f;
        if (DoDrop != false)
            Instantiate(drop, transform.position, Quaternion.identity);
    }
}
