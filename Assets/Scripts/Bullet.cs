using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            GameObject.Find("Player").GetComponent<Score>().enemiesKilled++;
        }

        Destroy(gameObject);
    }
}
