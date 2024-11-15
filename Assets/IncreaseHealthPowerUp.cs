using UnityEngine;

public class IncreaseHealthPowerUp : MonoBehaviour
{
    public float healthIncreaseAmount = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth.health < playerHealth.maxHealth - healthIncreaseAmount)
                playerHealth.health += healthIncreaseAmount;
            else
                playerHealth.health = playerHealth.maxHealth;

            Destroy(gameObject);
        }
    }
}
