using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 20f;
    public float health = 20f;
    public bool isDead = false;

    private void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
        }
    }
}
