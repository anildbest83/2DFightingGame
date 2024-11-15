using UnityEngine;

public class SpeedBoostPowerUp : MonoBehaviour
{
    public float SetSpeedTo = 8f;
    public float oldSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement.hasPowerUpActivated)
                return;

            oldSpeed = playerMovement.speed;
            playerMovement.speed = SetSpeedTo;
            playerMovement.hasPowerUpActivated = true;
            Destroy(gameObject);
        }
    }
}
