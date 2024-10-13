using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 20f;
    public bool isDead = false;
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
        }
    }
}
