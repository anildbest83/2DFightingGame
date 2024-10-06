using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject player;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        if (GameOverScreen != null)
            GameOverScreen.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Shooting>().enabled = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
